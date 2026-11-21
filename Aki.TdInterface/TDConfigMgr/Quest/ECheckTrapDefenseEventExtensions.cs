using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200136C RID: 4972
	public static class ECheckTrapDefenseEventExtensions
	{
		// Token: 0x06006FC0 RID: 28608 RVA: 0x00109068 File Offset: 0x00107268
		public static string ToEnumString(this ECheckTrapDefenseEvent value)
		{
			string result;
			if (value != ECheckTrapDefenseEvent.MonsterKilled)
			{
				if (value != ECheckTrapDefenseEvent.BdBuffQualityUp)
				{
					result = value.ToString();
				}
				else
				{
					result = "BdBuffQualityUp";
				}
			}
			else
			{
				result = "MonsterKilled";
			}
			return result;
		}

		// Token: 0x06006FC1 RID: 28609 RVA: 0x001090A0 File Offset: 0x001072A0
		public static ECheckTrapDefenseEvent FromString(string name)
		{
			ECheckTrapDefenseEvent result;
			if (!ECheckTrapDefenseEventExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECheckTrapDefenseEvent 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006FC2 RID: 28610 RVA: 0x001090C9 File Offset: 0x001072C9
		public static bool TryFromString(string name, out ECheckTrapDefenseEvent value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECheckTrapDefenseEvent.MonsterKilled;
				return false;
			}
			if (name == "MonsterKilled")
			{
				value = ECheckTrapDefenseEvent.MonsterKilled;
				return true;
			}
			if (!(name == "BdBuffQualityUp"))
			{
				value = ECheckTrapDefenseEvent.MonsterKilled;
				return false;
			}
			value = ECheckTrapDefenseEvent.BdBuffQualityUp;
			return true;
		}

		// Token: 0x06006FC3 RID: 28611 RVA: 0x00109102 File Offset: 0x00107302
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MonsterKilled",
				"BdBuffQualityUp"
			};
		}

		// Token: 0x06006FC4 RID: 28612 RVA: 0x0010911A File Offset: 0x0010731A
		public static ECheckTrapDefenseEvent[] GetValues()
		{
			return new ECheckTrapDefenseEvent[]
			{
				ECheckTrapDefenseEvent.MonsterKilled,
				ECheckTrapDefenseEvent.BdBuffQualityUp
			};
		}

		// Token: 0x06006FC5 RID: 28613 RVA: 0x00109126 File Offset: 0x00107326
		public static string[] GetNames()
		{
			return new string[]
			{
				"MonsterKilled",
				"BdBuffQualityUp"
			};
		}
	}
}
