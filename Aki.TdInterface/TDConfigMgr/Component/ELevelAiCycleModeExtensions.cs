using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000988 RID: 2440
	public static class ELevelAiCycleModeExtensions
	{
		// Token: 0x06003695 RID: 13973 RVA: 0x0008E338 File Offset: 0x0008C538
		public static string ToEnumString(this ELevelAiCycleMode value)
		{
			string result;
			if (value == ELevelAiCycleMode.Loop)
			{
				result = "Loop";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003696 RID: 13974 RVA: 0x0008E360 File Offset: 0x0008C560
		public static ELevelAiCycleMode FromString(string name)
		{
			ELevelAiCycleMode result;
			if (!ELevelAiCycleModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELevelAiCycleMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003697 RID: 13975 RVA: 0x0008E389 File Offset: 0x0008C589
		public static bool TryFromString(string name, out ELevelAiCycleMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELevelAiCycleMode.Loop;
				return false;
			}
			if (name == "Loop")
			{
				value = ELevelAiCycleMode.Loop;
				return true;
			}
			value = ELevelAiCycleMode.Loop;
			return false;
		}

		// Token: 0x06003698 RID: 13976 RVA: 0x0008E3AE File Offset: 0x0008C5AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Loop"
			};
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x0008E3BE File Offset: 0x0008C5BE
		public static ELevelAiCycleMode[] GetValues()
		{
			return new ELevelAiCycleMode[1];
		}

		// Token: 0x0600369A RID: 13978 RVA: 0x0008E3C6 File Offset: 0x0008C5C6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Loop"
			};
		}
	}
}
