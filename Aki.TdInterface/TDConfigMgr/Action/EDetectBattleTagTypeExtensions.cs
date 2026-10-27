using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002301 RID: 8961
	public static class EDetectBattleTagTypeExtensions
	{
		// Token: 0x0600C403 RID: 50179 RVA: 0x001C9F08 File Offset: 0x001C8108
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

		// Token: 0x0600C404 RID: 50180 RVA: 0x001C9F30 File Offset: 0x001C8130
		public static EDetectBattleTagType FromString(string name)
		{
			EDetectBattleTagType result;
			if (!EDetectBattleTagTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDetectBattleTagType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C405 RID: 50181 RVA: 0x001C9F59 File Offset: 0x001C8159
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

		// Token: 0x0600C406 RID: 50182 RVA: 0x001C9F7E File Offset: 0x001C817E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"怪物.common.关卡.通信专用.进入战斗"
			};
		}

		// Token: 0x0600C407 RID: 50183 RVA: 0x001C9F8E File Offset: 0x001C818E
		public static EDetectBattleTagType[] GetValues()
		{
			return new EDetectBattleTagType[1];
		}

		// Token: 0x0600C408 RID: 50184 RVA: 0x001C9F96 File Offset: 0x001C8196
		public static string[] GetNames()
		{
			return new string[]
			{
				"MonsterOnTheGround"
			};
		}
	}
}
