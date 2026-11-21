using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A3F RID: 2623
	public static class ELevelSequenceSectionTypeExtensions
	{
		// Token: 0x06003A2E RID: 14894 RVA: 0x000964D8 File Offset: 0x000946D8
		public static string ToEnumString(this ELevelSequenceSectionType value)
		{
			string result;
			if (value != ELevelSequenceSectionType.Mark)
			{
				if (value != ELevelSequenceSectionType.EventMark)
				{
					result = value.ToString();
				}
				else
				{
					result = "EventMark";
				}
			}
			else
			{
				result = "Mark";
			}
			return result;
		}

		// Token: 0x06003A2F RID: 14895 RVA: 0x00096510 File Offset: 0x00094710
		public static ELevelSequenceSectionType FromString(string name)
		{
			ELevelSequenceSectionType result;
			if (!ELevelSequenceSectionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELevelSequenceSectionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A30 RID: 14896 RVA: 0x00096539 File Offset: 0x00094739
		public static bool TryFromString(string name, out ELevelSequenceSectionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELevelSequenceSectionType.Mark;
				return false;
			}
			if (name == "Mark")
			{
				value = ELevelSequenceSectionType.Mark;
				return true;
			}
			if (!(name == "EventMark"))
			{
				value = ELevelSequenceSectionType.Mark;
				return false;
			}
			value = ELevelSequenceSectionType.EventMark;
			return true;
		}

		// Token: 0x06003A31 RID: 14897 RVA: 0x00096572 File Offset: 0x00094772
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Mark",
				"EventMark"
			};
		}

		// Token: 0x06003A32 RID: 14898 RVA: 0x0009658A File Offset: 0x0009478A
		public static ELevelSequenceSectionType[] GetValues()
		{
			return new ELevelSequenceSectionType[]
			{
				ELevelSequenceSectionType.Mark,
				ELevelSequenceSectionType.EventMark
			};
		}

		// Token: 0x06003A33 RID: 14899 RVA: 0x00096596 File Offset: 0x00094796
		public static string[] GetNames()
		{
			return new string[]
			{
				"Mark",
				"EventMark"
			};
		}
	}
}
