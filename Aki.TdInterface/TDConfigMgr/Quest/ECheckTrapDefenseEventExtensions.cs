using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001230 RID: 4656
	public static class ECheckTrapDefenseEventExtensions
	{
		// Token: 0x0600697F RID: 27007 RVA: 0x000FB75C File Offset: 0x000F995C
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

		// Token: 0x06006980 RID: 27008 RVA: 0x000FB794 File Offset: 0x000F9994
		public static ECheckTrapDefenseEvent FromString(string name)
		{
			ECheckTrapDefenseEvent result;
			if (!ECheckTrapDefenseEventExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECheckTrapDefenseEvent 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006981 RID: 27009 RVA: 0x000FB7BD File Offset: 0x000F99BD
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

		// Token: 0x06006982 RID: 27010 RVA: 0x000FB7F6 File Offset: 0x000F99F6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MonsterKilled",
				"BdBuffQualityUp"
			};
		}

		// Token: 0x06006983 RID: 27011 RVA: 0x000FB80E File Offset: 0x000F9A0E
		public static ECheckTrapDefenseEvent[] GetValues()
		{
			return new ECheckTrapDefenseEvent[]
			{
				ECheckTrapDefenseEvent.MonsterKilled,
				ECheckTrapDefenseEvent.BdBuffQualityUp
			};
		}

		// Token: 0x06006984 RID: 27012 RVA: 0x000FB81A File Offset: 0x000F9A1A
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
