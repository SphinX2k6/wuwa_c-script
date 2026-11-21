using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200261E RID: 9758
	public static class EMotorRadioDisableRangeTypeExtensions
	{
		// Token: 0x0600D2E1 RID: 53985 RVA: 0x001EA69C File Offset: 0x001E889C
		public static string ToEnumString(this EMotorRadioDisableRangeType value)
		{
			string result;
			switch (value)
			{
			case EMotorRadioDisableRangeType.ByAreaId:
				result = "ByAreaId";
				break;
			case EMotorRadioDisableRangeType.ByAbsoluteRange:
				result = "ByAbsoluteRange";
				break;
			case EMotorRadioDisableRangeType.ByRangeEntities:
				result = "ByRangeEntities";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D2E2 RID: 53986 RVA: 0x001EA6E4 File Offset: 0x001E88E4
		public static EMotorRadioDisableRangeType FromString(string name)
		{
			EMotorRadioDisableRangeType result;
			if (!EMotorRadioDisableRangeTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorRadioDisableRangeType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D2E3 RID: 53987 RVA: 0x001EA710 File Offset: 0x001E8910
		public static bool TryFromString(string name, out EMotorRadioDisableRangeType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMotorRadioDisableRangeType.ByAreaId;
				return false;
			}
			if (name == "ByAreaId")
			{
				value = EMotorRadioDisableRangeType.ByAreaId;
				return true;
			}
			if (name == "ByAbsoluteRange")
			{
				value = EMotorRadioDisableRangeType.ByAbsoluteRange;
				return true;
			}
			if (!(name == "ByRangeEntities"))
			{
				value = EMotorRadioDisableRangeType.ByAreaId;
				return false;
			}
			value = EMotorRadioDisableRangeType.ByRangeEntities;
			return true;
		}

		// Token: 0x0600D2E4 RID: 53988 RVA: 0x001EA766 File Offset: 0x001E8966
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ByAreaId",
				"ByAbsoluteRange",
				"ByRangeEntities"
			};
		}

		// Token: 0x0600D2E5 RID: 53989 RVA: 0x001EA786 File Offset: 0x001E8986
		public static EMotorRadioDisableRangeType[] GetValues()
		{
			return new EMotorRadioDisableRangeType[]
			{
				EMotorRadioDisableRangeType.ByAreaId,
				EMotorRadioDisableRangeType.ByAbsoluteRange,
				EMotorRadioDisableRangeType.ByRangeEntities
			};
		}

		// Token: 0x0600D2E6 RID: 53990 RVA: 0x001EA796 File Offset: 0x001E8996
		public static string[] GetNames()
		{
			return new string[]
			{
				"ByAreaId",
				"ByAbsoluteRange",
				"ByRangeEntities"
			};
		}
	}
}
