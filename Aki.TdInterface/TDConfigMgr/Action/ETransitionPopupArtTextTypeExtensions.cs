using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002481 RID: 9345
	public static class ETransitionPopupArtTextTypeExtensions
	{
		// Token: 0x0600CAC3 RID: 51907 RVA: 0x001DD878 File Offset: 0x001DBA78
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

		// Token: 0x0600CAC4 RID: 51908 RVA: 0x001DD8A0 File Offset: 0x001DBAA0
		public static ETransitionPopupArtTextType FromString(string name)
		{
			ETransitionPopupArtTextType result;
			if (!ETransitionPopupArtTextTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETransitionPopupArtTextType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CAC5 RID: 51909 RVA: 0x001DD8C9 File Offset: 0x001DBAC9
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

		// Token: 0x0600CAC6 RID: 51910 RVA: 0x001DD8EE File Offset: 0x001DBAEE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"YuanCheng"
			};
		}

		// Token: 0x0600CAC7 RID: 51911 RVA: 0x001DD8FE File Offset: 0x001DBAFE
		public static ETransitionPopupArtTextType[] GetValues()
		{
			return new ETransitionPopupArtTextType[1];
		}

		// Token: 0x0600CAC8 RID: 51912 RVA: 0x001DD906 File Offset: 0x001DBB06
		public static string[] GetNames()
		{
			return new string[]
			{
				"YuanCheng"
			};
		}
	}
}
