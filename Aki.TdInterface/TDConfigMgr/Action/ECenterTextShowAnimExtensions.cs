using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200253E RID: 9534
	public static class ECenterTextShowAnimExtensions
	{
		// Token: 0x0600CEF1 RID: 52977 RVA: 0x001E020C File Offset: 0x001DE40C
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

		// Token: 0x0600CEF2 RID: 52978 RVA: 0x001E0254 File Offset: 0x001DE454
		public static ECenterTextShowAnim FromString(string name)
		{
			ECenterTextShowAnim result;
			if (!ECenterTextShowAnimExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECenterTextShowAnim 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CEF3 RID: 52979 RVA: 0x001E0280 File Offset: 0x001DE480
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

		// Token: 0x0600CEF4 RID: 52980 RVA: 0x001E02D6 File Offset: 0x001DE4D6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ShowAll",
				"FadeOut",
				"TypeWriter"
			};
		}

		// Token: 0x0600CEF5 RID: 52981 RVA: 0x001E02F6 File Offset: 0x001DE4F6
		public static ECenterTextShowAnim[] GetValues()
		{
			return new ECenterTextShowAnim[]
			{
				ECenterTextShowAnim.ShowAll,
				ECenterTextShowAnim.FadeOut,
				ECenterTextShowAnim.TypeWriter
			};
		}

		// Token: 0x0600CEF6 RID: 52982 RVA: 0x001E0306 File Offset: 0x001DE506
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
