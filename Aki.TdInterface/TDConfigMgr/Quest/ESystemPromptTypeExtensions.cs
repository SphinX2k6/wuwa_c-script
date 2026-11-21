using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013DC RID: 5084
	public static class ESystemPromptTypeExtensions
	{
		// Token: 0x060071B8 RID: 29112 RVA: 0x0010FD6C File Offset: 0x0010DF6C
		public static string ToEnumString(this ESystemPromptType value)
		{
			string result;
			if (value == ESystemPromptType.AreaName)
			{
				result = "AreaName";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060071B9 RID: 29113 RVA: 0x0010FD94 File Offset: 0x0010DF94
		public static ESystemPromptType FromString(string name)
		{
			ESystemPromptType result;
			if (!ESystemPromptTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESystemPromptType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060071BA RID: 29114 RVA: 0x0010FDBD File Offset: 0x0010DFBD
		public static bool TryFromString(string name, out ESystemPromptType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESystemPromptType.AreaName;
				return false;
			}
			if (name == "AreaName")
			{
				value = ESystemPromptType.AreaName;
				return true;
			}
			value = ESystemPromptType.AreaName;
			return false;
		}

		// Token: 0x060071BB RID: 29115 RVA: 0x0010FDE2 File Offset: 0x0010DFE2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AreaName"
			};
		}

		// Token: 0x060071BC RID: 29116 RVA: 0x0010FDF2 File Offset: 0x0010DFF2
		public static ESystemPromptType[] GetValues()
		{
			return new ESystemPromptType[1];
		}

		// Token: 0x060071BD RID: 29117 RVA: 0x0010FDFA File Offset: 0x0010DFFA
		public static string[] GetNames()
		{
			return new string[]
			{
				"AreaName"
			};
		}
	}
}
