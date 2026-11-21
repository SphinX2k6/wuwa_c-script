using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002724 RID: 10020
	public static class ETransitionPopupArtTextTypeExtensions
	{
		// Token: 0x0600D77C RID: 55164 RVA: 0x001F7A40 File Offset: 0x001F5C40
		public static string ToEnumString(this ETransitionPopupArtTextType value)
		{
			string result;
			if (value == ETransitionPopupArtTextType.YuanCheng)
			{
				result = "YuanCheng";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D77D RID: 55165 RVA: 0x001F7A68 File Offset: 0x001F5C68
		public static ETransitionPopupArtTextType FromString(string name)
		{
			ETransitionPopupArtTextType result;
			if (!ETransitionPopupArtTextTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETransitionPopupArtTextType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D77E RID: 55166 RVA: 0x001F7A91 File Offset: 0x001F5C91
		public static bool TryFromString(string name, out ETransitionPopupArtTextType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETransitionPopupArtTextType.YuanCheng;
				return false;
			}
			if (name == "YuanCheng")
			{
				value = ETransitionPopupArtTextType.YuanCheng;
				return true;
			}
			value = ETransitionPopupArtTextType.YuanCheng;
			return false;
		}

		// Token: 0x0600D77F RID: 55167 RVA: 0x001F7AB6 File Offset: 0x001F5CB6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"YuanCheng"
			};
		}

		// Token: 0x0600D780 RID: 55168 RVA: 0x001F7AC6 File Offset: 0x001F5CC6
		public static ETransitionPopupArtTextType[] GetValues()
		{
			return new ETransitionPopupArtTextType[1];
		}

		// Token: 0x0600D781 RID: 55169 RVA: 0x001F7ACE File Offset: 0x001F5CCE
		public static string[] GetNames()
		{
			return new string[]
			{
				"YuanCheng"
			};
		}
	}
}
