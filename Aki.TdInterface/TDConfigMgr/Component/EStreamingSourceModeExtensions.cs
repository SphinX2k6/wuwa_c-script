using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A22 RID: 2594
	public static class EStreamingSourceModeExtensions
	{
		// Token: 0x0600394A RID: 14666 RVA: 0x000940D0 File Offset: 0x000922D0
		public static string ToEnumString(this EStreamingSourceMode value)
		{
			string result;
			if (value != EStreamingSourceMode.Fixed)
			{
				if (value != EStreamingSourceMode.Conditional)
				{
					result = value.ToString();
				}
				else
				{
					result = "Conditional";
				}
			}
			else
			{
				result = "Fixed";
			}
			return result;
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x00094108 File Offset: 0x00092308
		public static EStreamingSourceMode FromString(string name)
		{
			EStreamingSourceMode result;
			if (!EStreamingSourceModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EStreamingSourceMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600394C RID: 14668 RVA: 0x00094131 File Offset: 0x00092331
		public static bool TryFromString(string name, out EStreamingSourceMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EStreamingSourceMode.Fixed;
				return false;
			}
			if (name == "Fixed")
			{
				value = EStreamingSourceMode.Fixed;
				return true;
			}
			if (!(name == "Conditional"))
			{
				value = EStreamingSourceMode.Fixed;
				return false;
			}
			value = EStreamingSourceMode.Conditional;
			return true;
		}

		// Token: 0x0600394D RID: 14669 RVA: 0x0009416A File Offset: 0x0009236A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Fixed",
				"Conditional"
			};
		}

		// Token: 0x0600394E RID: 14670 RVA: 0x00094182 File Offset: 0x00092382
		public static EStreamingSourceMode[] GetValues()
		{
			return new EStreamingSourceMode[]
			{
				EStreamingSourceMode.Fixed,
				EStreamingSourceMode.Conditional
			};
		}

		// Token: 0x0600394F RID: 14671 RVA: 0x0009418E File Offset: 0x0009238E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Fixed",
				"Conditional"
			};
		}
	}
}
