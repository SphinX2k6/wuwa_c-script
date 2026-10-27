using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001278 RID: 4728
	public static class ERecallDataTypeExtensions
	{
		// Token: 0x06006AC3 RID: 27331 RVA: 0x001000E4 File Offset: 0x000FE2E4
		public static string ToEnumString(this ERecallDataType value)
		{
			string result;
			if (value != ERecallDataType.LevelPlay)
			{
				if (value != ERecallDataType.Quest)
				{
					result = value.ToString();
				}
				else
				{
					result = "Quest";
				}
			}
			else
			{
				result = "LevelPlay";
			}
			return result;
		}

		// Token: 0x06006AC4 RID: 27332 RVA: 0x0010011C File Offset: 0x000FE31C
		public static ERecallDataType FromString(string name)
		{
			ERecallDataType result;
			if (!ERecallDataTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERecallDataType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006AC5 RID: 27333 RVA: 0x00100145 File Offset: 0x000FE345
		public static bool TryFromString(string name, out ERecallDataType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERecallDataType.LevelPlay;
				return false;
			}
			if (name == "LevelPlay")
			{
				value = ERecallDataType.LevelPlay;
				return true;
			}
			if (!(name == "Quest"))
			{
				value = ERecallDataType.LevelPlay;
				return false;
			}
			value = ERecallDataType.Quest;
			return true;
		}

		// Token: 0x06006AC6 RID: 27334 RVA: 0x0010017E File Offset: 0x000FE37E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelPlay",
				"Quest"
			};
		}

		// Token: 0x06006AC7 RID: 27335 RVA: 0x00100196 File Offset: 0x000FE396
		public static ERecallDataType[] GetValues()
		{
			return new ERecallDataType[]
			{
				ERecallDataType.LevelPlay,
				ERecallDataType.Quest
			};
		}

		// Token: 0x06006AC8 RID: 27336 RVA: 0x001001A2 File Offset: 0x000FE3A2
		public static string[] GetNames()
		{
			return new string[]
			{
				"LevelPlay",
				"Quest"
			};
		}
	}
}
