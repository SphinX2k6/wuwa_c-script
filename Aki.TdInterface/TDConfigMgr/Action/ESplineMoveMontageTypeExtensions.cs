using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026C8 RID: 9928
	public static class ESplineMoveMontageTypeExtensions
	{
		// Token: 0x0600D5DE RID: 54750 RVA: 0x001F1314 File Offset: 0x001EF514
		public static string ToEnumString(this ESplineMoveMontageType value)
		{
			string result;
			if (value == ESplineMoveMontageType.ThreeStageMontage)
			{
				result = "ThreeStageMontage";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D5DF RID: 54751 RVA: 0x001F133C File Offset: 0x001EF53C
		public static ESplineMoveMontageType FromString(string name)
		{
			ESplineMoveMontageType result;
			if (!ESplineMoveMontageTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESplineMoveMontageType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D5E0 RID: 54752 RVA: 0x001F1365 File Offset: 0x001EF565
		public static bool TryFromString(string name, out ESplineMoveMontageType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESplineMoveMontageType.ThreeStageMontage;
				return false;
			}
			if (name == "ThreeStageMontage")
			{
				value = ESplineMoveMontageType.ThreeStageMontage;
				return true;
			}
			value = ESplineMoveMontageType.ThreeStageMontage;
			return false;
		}

		// Token: 0x0600D5E1 RID: 54753 RVA: 0x001F138A File Offset: 0x001EF58A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ThreeStageMontage"
			};
		}

		// Token: 0x0600D5E2 RID: 54754 RVA: 0x001F139A File Offset: 0x001EF59A
		public static ESplineMoveMontageType[] GetValues()
		{
			return new ESplineMoveMontageType[1];
		}

		// Token: 0x0600D5E3 RID: 54755 RVA: 0x001F13A2 File Offset: 0x001EF5A2
		public static string[] GetNames()
		{
			return new string[]
			{
				"ThreeStageMontage"
			};
		}
	}
}
