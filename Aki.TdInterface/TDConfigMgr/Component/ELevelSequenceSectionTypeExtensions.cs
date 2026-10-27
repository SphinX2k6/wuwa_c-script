using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200098C RID: 2444
	public static class ELevelSequenceSectionTypeExtensions
	{
		// Token: 0x060036A7 RID: 13991 RVA: 0x0008E56C File Offset: 0x0008C76C
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

		// Token: 0x060036A8 RID: 13992 RVA: 0x0008E5A4 File Offset: 0x0008C7A4
		public static ELevelSequenceSectionType FromString(string name)
		{
			ELevelSequenceSectionType result;
			if (!ELevelSequenceSectionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELevelSequenceSectionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060036A9 RID: 13993 RVA: 0x0008E5CD File Offset: 0x0008C7CD
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

		// Token: 0x060036AA RID: 13994 RVA: 0x0008E606 File Offset: 0x0008C806
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Mark",
				"EventMark"
			};
		}

		// Token: 0x060036AB RID: 13995 RVA: 0x0008E61E File Offset: 0x0008C81E
		public static ELevelSequenceSectionType[] GetValues()
		{
			return new ELevelSequenceSectionType[]
			{
				ELevelSequenceSectionType.Mark,
				ELevelSequenceSectionType.EventMark
			};
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x0008E62A File Offset: 0x0008C82A
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
