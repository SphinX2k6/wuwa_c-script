using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200129E RID: 4766
	public static class ETargetBattleAttributeExtensions
	{
		// Token: 0x06006B6E RID: 27502 RVA: 0x001021F8 File Offset: 0x001003F8
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

		// Token: 0x06006B6F RID: 27503 RVA: 0x00102230 File Offset: 0x00100430
		public static ETargetBattleAttribute FromString(string name)
		{
			ETargetBattleAttribute result;
			if (!ETargetBattleAttributeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETargetBattleAttribute 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B70 RID: 27504 RVA: 0x00102259 File Offset: 0x00100459
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

		// Token: 0x06006B71 RID: 27505 RVA: 0x00102292 File Offset: 0x00100492
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Player",
				"Monster"
			};
		}

		// Token: 0x06006B72 RID: 27506 RVA: 0x001022AA File Offset: 0x001004AA
		public static ETargetBattleAttribute[] GetValues()
		{
			return new ETargetBattleAttribute[]
			{
				ETargetBattleAttribute.Player,
				ETargetBattleAttribute.Monster
			};
		}

		// Token: 0x06006B73 RID: 27507 RVA: 0x001022B6 File Offset: 0x001004B6
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
