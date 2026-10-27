using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200095C RID: 2396
	public static class EGroupAiModeExtensions
	{
		// Token: 0x060035CF RID: 13775 RVA: 0x0008C2D4 File Offset: 0x0008A4D4
		public static string ToEnumString(this EGroupAiMode value)
		{
			string result;
			switch (value)
			{
			case EGroupAiMode.Default:
				result = "Default";
				break;
			case EGroupAiMode.Patrol:
				result = "Patrol";
				break;
			case EGroupAiMode.MonsterEcology:
				result = "MonsterEcology";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060035D0 RID: 13776 RVA: 0x0008C31C File Offset: 0x0008A51C
		public static EGroupAiMode FromString(string name)
		{
			EGroupAiMode result;
			if (!EGroupAiModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGroupAiMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060035D1 RID: 13777 RVA: 0x0008C348 File Offset: 0x0008A548
		public static bool TryFromString(string name, out EGroupAiMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGroupAiMode.Default;
				return false;
			}
			if (name == "Default")
			{
				value = EGroupAiMode.Default;
				return true;
			}
			if (name == "Patrol")
			{
				value = EGroupAiMode.Patrol;
				return true;
			}
			if (!(name == "MonsterEcology"))
			{
				value = EGroupAiMode.Default;
				return false;
			}
			value = EGroupAiMode.MonsterEcology;
			return true;
		}

		// Token: 0x060035D2 RID: 13778 RVA: 0x0008C39E File Offset: 0x0008A59E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default",
				"Patrol",
				"MonsterEcology"
			};
		}

		// Token: 0x060035D3 RID: 13779 RVA: 0x0008C3BE File Offset: 0x0008A5BE
		public static EGroupAiMode[] GetValues()
		{
			return new EGroupAiMode[]
			{
				EGroupAiMode.Default,
				EGroupAiMode.Patrol,
				EGroupAiMode.MonsterEcology
			};
		}

		// Token: 0x060035D4 RID: 13780 RVA: 0x0008C3CE File Offset: 0x0008A5CE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default",
				"Patrol",
				"MonsterEcology"
			};
		}
	}
}
