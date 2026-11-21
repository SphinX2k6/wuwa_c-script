using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200262E RID: 9774
	public static class EMovieCameraTypeExtensions
	{
		// Token: 0x0600D329 RID: 54057 RVA: 0x001EB030 File Offset: 0x001E9230
		public static string ToEnumString(this EMovieCameraType value)
		{
			string result;
			switch (value)
			{
			case EMovieCameraType.Common:
				result = "Common";
				break;
			case EMovieCameraType.Spec:
				result = "Spec";
				break;
			case EMovieCameraType.RandomInGroup:
				result = "RandomInGroup";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D32A RID: 54058 RVA: 0x001EB078 File Offset: 0x001E9278
		public static EMovieCameraType FromString(string name)
		{
			EMovieCameraType result;
			if (!EMovieCameraTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMovieCameraType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D32B RID: 54059 RVA: 0x001EB0A4 File Offset: 0x001E92A4
		public static bool TryFromString(string name, out EMovieCameraType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMovieCameraType.Common;
				return false;
			}
			if (name == "Common")
			{
				value = EMovieCameraType.Common;
				return true;
			}
			if (name == "Spec")
			{
				value = EMovieCameraType.Spec;
				return true;
			}
			if (!(name == "RandomInGroup"))
			{
				value = EMovieCameraType.Common;
				return false;
			}
			value = EMovieCameraType.RandomInGroup;
			return true;
		}

		// Token: 0x0600D32C RID: 54060 RVA: 0x001EB0FA File Offset: 0x001E92FA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Common",
				"Spec",
				"RandomInGroup"
			};
		}

		// Token: 0x0600D32D RID: 54061 RVA: 0x001EB11A File Offset: 0x001E931A
		public static EMovieCameraType[] GetValues()
		{
			return new EMovieCameraType[]
			{
				EMovieCameraType.Common,
				EMovieCameraType.Spec,
				EMovieCameraType.RandomInGroup
			};
		}

		// Token: 0x0600D32E RID: 54062 RVA: 0x001EB12A File Offset: 0x001E932A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Common",
				"Spec",
				"RandomInGroup"
			};
		}
	}
}
