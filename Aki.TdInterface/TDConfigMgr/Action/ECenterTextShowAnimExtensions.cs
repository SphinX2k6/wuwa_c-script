using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022CF RID: 8911
	public static class ECenterTextShowAnimExtensions
	{
		// Token: 0x0600C322 RID: 49954 RVA: 0x001C8404 File Offset: 0x001C6604
		public static string ToEnumString(this ECenterTextShowAnim value)
		{
			string result;
			switch (value)
			{
			case ECenterTextShowAnim.ShowAll:
				result = "ShowAll";
				break;
			case ECenterTextShowAnim.FadeOut:
				result = "FadeOut";
				break;
			case ECenterTextShowAnim.TypeWriter:
				result = "TypeWriter";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C323 RID: 49955 RVA: 0x001C844C File Offset: 0x001C664C
		public static ECenterTextShowAnim FromString(string name)
		{
			ECenterTextShowAnim result;
			if (!ECenterTextShowAnimExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECenterTextShowAnim 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C324 RID: 49956 RVA: 0x001C8478 File Offset: 0x001C6678
		public static bool TryFromString(string name, out ECenterTextShowAnim value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECenterTextShowAnim.ShowAll;
				return false;
			}
			if (name == "ShowAll")
			{
				value = ECenterTextShowAnim.ShowAll;
				return true;
			}
			if (name == "FadeOut")
			{
				value = ECenterTextShowAnim.FadeOut;
				return true;
			}
			if (!(name == "TypeWriter"))
			{
				value = ECenterTextShowAnim.ShowAll;
				return false;
			}
			value = ECenterTextShowAnim.TypeWriter;
			return true;
		}

		// Token: 0x0600C325 RID: 49957 RVA: 0x001C84CE File Offset: 0x001C66CE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ShowAll",
				"FadeOut",
				"TypeWriter"
			};
		}

		// Token: 0x0600C326 RID: 49958 RVA: 0x001C84EE File Offset: 0x001C66EE
		public static ECenterTextShowAnim[] GetValues()
		{
			return new ECenterTextShowAnim[]
			{
				ECenterTextShowAnim.ShowAll,
				ECenterTextShowAnim.FadeOut,
				ECenterTextShowAnim.TypeWriter
			};
		}

		// Token: 0x0600C327 RID: 49959 RVA: 0x001C84FE File Offset: 0x001C66FE
		public static string[] GetNames()
		{
			return new string[]
			{
				"ShowAll",
				"FadeOut",
				"TypeWriter"
			};
		}
	}
}
