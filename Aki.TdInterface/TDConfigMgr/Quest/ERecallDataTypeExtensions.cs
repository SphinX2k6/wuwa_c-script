using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013B8 RID: 5048
	public static class ERecallDataTypeExtensions
	{
		// Token: 0x06007116 RID: 28950 RVA: 0x0010DD10 File Offset: 0x0010BF10
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

		// Token: 0x06007117 RID: 28951 RVA: 0x0010DD48 File Offset: 0x0010BF48
		public static ERecallDataType FromString(string name)
		{
			ERecallDataType result;
			if (!ERecallDataTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERecallDataType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007118 RID: 28952 RVA: 0x0010DD71 File Offset: 0x0010BF71
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

		// Token: 0x06007119 RID: 28953 RVA: 0x0010DDAA File Offset: 0x0010BFAA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelPlay",
				"Quest"
			};
		}

		// Token: 0x0600711A RID: 28954 RVA: 0x0010DDC2 File Offset: 0x0010BFC2
		public static ERecallDataType[] GetValues()
		{
			return new ERecallDataType[]
			{
				ERecallDataType.LevelPlay,
				ERecallDataType.Quest
			};
		}

		// Token: 0x0600711B RID: 28955 RVA: 0x0010DDCE File Offset: 0x0010BFCE
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
