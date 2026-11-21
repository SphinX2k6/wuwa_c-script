using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200256E RID: 9582
	public static class EDetectBattleConditionTypeExtensions
	{
		// Token: 0x0600CFC9 RID: 53193 RVA: 0x001E1CF4 File Offset: 0x001DFEF4
		public static string ToEnumString(this EDetectBattleConditionType value)
		{
			string result;
			if (value == EDetectBattleConditionType.DetectBattleTag)
			{
				result = "DetectBattleTag";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CFCA RID: 53194 RVA: 0x001E1D1C File Offset: 0x001DFF1C
		public static EDetectBattleConditionType FromString(string name)
		{
			EDetectBattleConditionType result;
			if (!EDetectBattleConditionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDetectBattleConditionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CFCB RID: 53195 RVA: 0x001E1D45 File Offset: 0x001DFF45
		public static bool TryFromString(string name, out EDetectBattleConditionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDetectBattleConditionType.DetectBattleTag;
				return false;
			}
			if (name == "DetectBattleTag")
			{
				value = EDetectBattleConditionType.DetectBattleTag;
				return true;
			}
			value = EDetectBattleConditionType.DetectBattleTag;
			return false;
		}

		// Token: 0x0600CFCC RID: 53196 RVA: 0x001E1D6A File Offset: 0x001DFF6A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DetectBattleTag"
			};
		}

		// Token: 0x0600CFCD RID: 53197 RVA: 0x001E1D7A File Offset: 0x001DFF7A
		public static EDetectBattleConditionType[] GetValues()
		{
			return new EDetectBattleConditionType[1];
		}

		// Token: 0x0600CFCE RID: 53198 RVA: 0x001E1D82 File Offset: 0x001DFF82
		public static string[] GetNames()
		{
			return new string[]
			{
				"DetectBattleTag"
			};
		}
	}
}
