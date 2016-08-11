using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hzconsole
{
    public class MGoods
    {
        /// <summary>
        /// 商品编号 例:UUID或者数字
        /// </summary>
        public string goodsguid { get; set; }

        /// <summary>
        /// 品目编号 品目编号  参照品目文档写入
        /// </summary>
        public string goodsclassguid { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        public string name { get; set; }
        
        /// <summary>
        /// 品牌名称
        /// </summary>
        public string goodsbrandname { get; set; }

        /// <summary>
        /// 市场价(16,2)
        /// </summary>
        public float marketprice { get; set; }

        /// <summary>
        /// 库存量(4)
        /// </summary>
        public int inventory { get; set; }

        /// <summary>
        /// 商品主图缩略图 Base64方式编码为字符串
        /// </summary>
        public string img { get; set; }

        /// <summary>
        /// 商品主图大图 Base64方式编码为字符串
        /// </summary>
        public string bigimg { get; set; }

        /// <summary>
        /// 图片类型 图片文件类型后缀，如：gif,jpg
        /// </summary>
        public string pictype { get; set; }

        /// <summary>
        /// 商品详细描述 项目详细描述的html文本
        /// </summary>
        public string goodsdesc { get; set; }

        /// <summary>
        /// 商品属性描述 以html格式封装的商品属性，例：<li>上市时间：：2012年</li>
        /// </summary>
        public string goodsparamhtml { get; set; }

        /// <summary>
        /// 商品新编号 建议:UUID
        /// </summary>
        public string goodscode { get; set; }

        /// <summary>
        /// 商品属性集合 与属性描述2选1
        /// </summary>
        public string goodsparams { get; set; }
    }
}
