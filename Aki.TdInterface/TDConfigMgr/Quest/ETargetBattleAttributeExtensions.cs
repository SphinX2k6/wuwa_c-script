using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013E4 RID: 5092
	public static class ETargetBattleAttributeExtensions
	{
		// Token: 0x060071DC RID: 29148 RVA: 0x001101C0 File Offset: 0x0010E3C0
		public static string ToEnumString(this ETargetBattleAttribute value)
		{
			string result;
			if (value != ETargetBattleAttribute.Player)
			{
				if (value != ETargetBattleAttribute.Monster)
				{
					result = value.ToString();
				}
				else
				{
					result = "Monster";
				}
			}
			else
			{
				result = "Player";
			}
			return result;
		}

		// Token: 0x060071DD RID: 29149 RVA: 0x001101F8 File Offset: 0x0010E3F8
		public static ETargetBattleAttribute FromString(string name)
		{
			ETargetBattleAttribute result;
			if (!ETargetBattleAttributeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETargetBattleAttribute 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x00110221 File Offset: 0x0010E421
		public static bool TryFromString(string name, out ETargetBattleAttribute value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETargetBattleAttribute.Player;
				return false;
			}
			if (name == "Player")
			{
				value = ETargetBattleAttribute.Player;
				return true;
			}
			if (!(name == "Monster"))
			{
				value = ETargetBattleAttribute.Player;
				return false;
			}
			value = ETargetBattleAttribute.Monster;
			return true;
		}

		// Token: 0x060071DF RID: 29151 RVA: 0x0011025A File Offset: 0x0010E45A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Player",
				"Monster"
			};
		}

		// Token: 0x060071E0 RID: 29152 RVA: 0x00110272 File Offset: 0x0010E472
		public static ETargetBattleAttribute[] GetValues()
		{
			return new ETargetBattleAttribute[]
			{
				ETargetBattleAttribute.Player,
				ETargetBattleAttribute.Monster
			};
		}

		// Token: 0x060071E1 RID: 29153 RVA: 0x0011027E File Offset: 0x0010E47E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Player",
				"Monster"
			};
		}
	}
}
