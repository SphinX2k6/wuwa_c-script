using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A3B RID: 2619
	public static class ELevelAiCycleModeExtensions
	{
		// Token: 0x06003A1C RID: 14876 RVA: 0x000962A4 File Offset: 0x000944A4
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

		// Token: 0x06003A1D RID: 14877 RVA: 0x000962CC File Offset: 0x000944CC
		public static ELevelAiCycleMode FromString(string name)
		{
			ELevelAiCycleMode result;
			if (!ELevelAiCycleModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELevelAiCycleMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x000962F5 File Offset: 0x000944F5
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

		// Token: 0x06003A1F RID: 14879 RVA: 0x0009631A File Offset: 0x0009451A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Loop"
			};
		}

		// Token: 0x06003A20 RID: 14880 RVA: 0x0009632A File Offset: 0x0009452A
		public static ELevelAiCycleMode[] GetValues()
		{
			return new ELevelAiCycleMode[1];
		}

		// Token: 0x06003A21 RID: 14881 RVA: 0x00096332 File Offset: 0x00094532
		public static string[] GetNames()
		{
			return new string[]
			{
				"Loop"
			};
		}
	}
}
