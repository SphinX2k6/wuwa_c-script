using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A3 RID: 9123
	public static class EMovieCameraTypeExtensions
	{
		// Token: 0x0600C6DC RID: 50908 RVA: 0x001D1E90 File Offset: 0x001D0090
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

		// Token: 0x0600C6DD RID: 50909 RVA: 0x001D1ED8 File Offset: 0x001D00D8
		public static EMovieCameraType FromString(string name)
		{
			EMovieCameraType result;
			if (!EMovieCameraTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMovieCameraType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C6DE RID: 50910 RVA: 0x001D1F04 File Offset: 0x001D0104
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

		// Token: 0x0600C6DF RID: 50911 RVA: 0x001D1F5A File Offset: 0x001D015A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Common",
				"Spec",
				"RandomInGroup"
			};
		}

		// Token: 0x0600C6E0 RID: 50912 RVA: 0x001D1F7A File Offset: 0x001D017A
		public static EMovieCameraType[] GetValues()
		{
			return new EMovieCameraType[]
			{
				EMovieCameraType.Common,
				EMovieCameraType.Spec,
				EMovieCameraType.RandomInGroup
			};
		}

		// Token: 0x0600C6E1 RID: 50913 RVA: 0x001D1F8A File Offset: 0x001D018A
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
