using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022FF RID: 8959
	public static class EDetectBattleConditionTypeExtensions
	{
		// Token: 0x0600C3FA RID: 50170 RVA: 0x001C9E2C File Offset: 0x001C802C
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

		// Token: 0x0600C3FB RID: 50171 RVA: 0x001C9E54 File Offset: 0x001C8054
		public static EDetectBattleConditionType FromString(string name)
		{
			EDetectBattleConditionType result;
			if (!EDetectBattleConditionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDetectBattleConditionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C3FC RID: 50172 RVA: 0x001C9E7D File Offset: 0x001C807D
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

		// Token: 0x0600C3FD RID: 50173 RVA: 0x001C9EA2 File Offset: 0x001C80A2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DetectBattleTag"
			};
		}

		// Token: 0x0600C3FE RID: 50174 RVA: 0x001C9EB2 File Offset: 0x001C80B2
		public static EDetectBattleConditionType[] GetValues()
		{
			return new EDetectBattleConditionType[1];
		}

		// Token: 0x0600C3FF RID: 50175 RVA: 0x001C9EBA File Offset: 0x001C80BA
		public static string[] GetNames()
		{
			return new string[]
			{
				"DetectBattleTag"
			};
		}
	}
}
