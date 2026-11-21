using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002570 RID: 9584
	public static class EDetectBattleTagTypeExtensions
	{
		// Token: 0x0600CFD2 RID: 53202 RVA: 0x001E1DD0 File Offset: 0x001DFFD0
		public static string ToEnumString(this EDetectBattleTagType value)
		{
			string result;
			if (value == EDetectBattleTagType.MonsterOnTheGround)
			{
				result = "怪物.common.关卡.通信专用.进入战斗";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CFD3 RID: 53203 RVA: 0x001E1DF8 File Offset: 0x001DFFF8
		public static EDetectBattleTagType FromString(string name)
		{
			EDetectBattleTagType result;
			if (!EDetectBattleTagTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDetectBattleTagType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CFD4 RID: 53204 RVA: 0x001E1E21 File Offset: 0x001E0021
		public static bool TryFromString(string name, out EDetectBattleTagType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDetectBattleTagType.MonsterOnTheGround;
				return false;
			}
			if (name == "怪物.common.关卡.通信专用.进入战斗")
			{
				value = EDetectBattleTagType.MonsterOnTheGround;
				return true;
			}
			value = EDetectBattleTagType.MonsterOnTheGround;
			return false;
		}

		// Token: 0x0600CFD5 RID: 53205 RVA: 0x001E1E46 File Offset: 0x001E0046
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"怪物.common.关卡.通信专用.进入战斗"
			};
		}

		// Token: 0x0600CFD6 RID: 53206 RVA: 0x001E1E56 File Offset: 0x001E0056
		public static EDetectBattleTagType[] GetValues()
		{
			return new EDetectBattleTagType[1];
		}

		// Token: 0x0600CFD7 RID: 53207 RVA: 0x001E1E5E File Offset: 0x001E005E
		public static string[] GetNames()
		{
			return new string[]
			{
				"MonsterOnTheGround"
			};
		}
	}
}
