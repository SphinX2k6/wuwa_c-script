using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A35 RID: 2613
	public static class EItemFoundationExtensions
	{
		// Token: 0x06003A01 RID: 14849 RVA: 0x00095E80 File Offset: 0x00094080
		public static string ToEnumString(this EItemFoundation value)
		{
			string result;
			switch (value)
			{
			case EItemFoundation.CategoryMatching:
				result = "CategoryMatching";
				break;
			case EItemFoundation.BuildingBlock:
				result = "BuildingBlock";
				break;
			case EItemFoundation.PulseDevice:
				result = "PulseDevice";
				break;
			case EItemFoundation.RangeAdsorption:
				result = "RangeAdsorption";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003A02 RID: 14850 RVA: 0x00095ED4 File Offset: 0x000940D4
		public static EItemFoundation FromString(string name)
		{
			EItemFoundation result;
			if (!EItemFoundationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EItemFoundation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A03 RID: 14851 RVA: 0x00095F00 File Offset: 0x00094100
		public static bool TryFromString(string name, out EItemFoundation value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EItemFoundation.CategoryMatching;
				return false;
			}
			if (name == "CategoryMatching")
			{
				value = EItemFoundation.CategoryMatching;
				return true;
			}
			if (name == "BuildingBlock")
			{
				value = EItemFoundation.BuildingBlock;
				return true;
			}
			if (name == "PulseDevice")
			{
				value = EItemFoundation.PulseDevice;
				return true;
			}
			if (!(name == "RangeAdsorption"))
			{
				value = EItemFoundation.CategoryMatching;
				return false;
			}
			value = EItemFoundation.RangeAdsorption;
			return true;
		}

		// Token: 0x06003A04 RID: 14852 RVA: 0x00095F68 File Offset: 0x00094168
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CategoryMatching",
				"BuildingBlock",
				"PulseDevice",
				"RangeAdsorption"
			};
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x00095F90 File Offset: 0x00094190
		public static EItemFoundation[] GetValues()
		{
			return new EItemFoundation[]
			{
				EItemFoundation.CategoryMatching,
				EItemFoundation.BuildingBlock,
				EItemFoundation.PulseDevice,
				EItemFoundation.RangeAdsorption
			};
		}

		// Token: 0x06003A06 RID: 14854 RVA: 0x00095FA3 File Offset: 0x000941A3
		public static string[] GetNames()
		{
			return new string[]
			{
				"CategoryMatching",
				"BuildingBlock",
				"PulseDevice",
				"RangeAdsorption"
			};
		}
	}
}
