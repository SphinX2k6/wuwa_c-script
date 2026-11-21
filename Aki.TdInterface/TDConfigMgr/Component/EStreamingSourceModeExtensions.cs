using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AE7 RID: 2791
	public static class EStreamingSourceModeExtensions
	{
		// Token: 0x06003D22 RID: 15650 RVA: 0x0009CA04 File Offset: 0x0009AC04
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

		// Token: 0x06003D23 RID: 15651 RVA: 0x0009CA3C File Offset: 0x0009AC3C
		public static EStreamingSourceMode FromString(string name)
		{
			EStreamingSourceMode result;
			if (!EStreamingSourceModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EStreamingSourceMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D24 RID: 15652 RVA: 0x0009CA65 File Offset: 0x0009AC65
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

		// Token: 0x06003D25 RID: 15653 RVA: 0x0009CA9E File Offset: 0x0009AC9E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Fixed",
				"Conditional"
			};
		}

		// Token: 0x06003D26 RID: 15654 RVA: 0x0009CAB6 File Offset: 0x0009ACB6
		public static EStreamingSourceMode[] GetValues()
		{
			return new EStreamingSourceMode[]
			{
				EStreamingSourceMode.Fixed,
				EStreamingSourceMode.Conditional
			};
		}

		// Token: 0x06003D27 RID: 15655 RVA: 0x0009CAC2 File Offset: 0x0009ACC2
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
