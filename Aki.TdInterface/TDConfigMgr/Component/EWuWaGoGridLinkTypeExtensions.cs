using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A48 RID: 2632
	public static class EWuWaGoGridLinkTypeExtensions
	{
		// Token: 0x060039F5 RID: 14837 RVA: 0x000958DC File Offset: 0x00093ADC
		public static string ToEnumString(this EWuWaGoGridLinkType value)
		{
			string result;
			switch (value)
			{
			case EWuWaGoGridLinkType.EmptyGrid:
				result = "EmptyGrid";
				break;
			case EWuWaGoGridLinkType.SingleLinkGrid:
				result = "SingleLinkGrid";
				break;
			case EWuWaGoGridLinkType.RightAngleLinkGrid:
				result = "RightAngleLinkGrid";
				break;
			case EWuWaGoGridLinkType.ThreeLinkGrid:
				result = "ThreeLinkGrid";
				break;
			case EWuWaGoGridLinkType.StraightLinkGrid:
				result = "StraightLinkGrid";
				break;
			case EWuWaGoGridLinkType.AllLinkGrid:
				result = "AllLinkGrid";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060039F6 RID: 14838 RVA: 0x00095948 File Offset: 0x00093B48
		public static EWuWaGoGridLinkType FromString(string name)
		{
			EWuWaGoGridLinkType result;
			if (!EWuWaGoGridLinkTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWuWaGoGridLinkType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039F7 RID: 14839 RVA: 0x00095974 File Offset: 0x00093B74
		public static bool TryFromString(string name, out EWuWaGoGridLinkType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EWuWaGoGridLinkType.EmptyGrid;
				return false;
			}
			if (name == "EmptyGrid")
			{
				value = EWuWaGoGridLinkType.EmptyGrid;
				return true;
			}
			if (name == "SingleLinkGrid")
			{
				value = EWuWaGoGridLinkType.SingleLinkGrid;
				return true;
			}
			if (name == "RightAngleLinkGrid")
			{
				value = EWuWaGoGridLinkType.RightAngleLinkGrid;
				return true;
			}
			if (name == "ThreeLinkGrid")
			{
				value = EWuWaGoGridLinkType.ThreeLinkGrid;
				return true;
			}
			if (name == "StraightLinkGrid")
			{
				value = EWuWaGoGridLinkType.StraightLinkGrid;
				return true;
			}
			if (!(name == "AllLinkGrid"))
			{
				value = EWuWaGoGridLinkType.EmptyGrid;
				return false;
			}
			value = EWuWaGoGridLinkType.AllLinkGrid;
			return true;
		}

		// Token: 0x060039F8 RID: 14840 RVA: 0x00095A00 File Offset: 0x00093C00
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EmptyGrid",
				"SingleLinkGrid",
				"RightAngleLinkGrid",
				"ThreeLinkGrid",
				"StraightLinkGrid",
				"AllLinkGrid"
			};
		}

		// Token: 0x060039F9 RID: 14841 RVA: 0x00095A38 File Offset: 0x00093C38
		public static EWuWaGoGridLinkType[] GetValues()
		{
			return new EWuWaGoGridLinkType[]
			{
				EWuWaGoGridLinkType.EmptyGrid,
				EWuWaGoGridLinkType.SingleLinkGrid,
				EWuWaGoGridLinkType.RightAngleLinkGrid,
				EWuWaGoGridLinkType.ThreeLinkGrid,
				EWuWaGoGridLinkType.StraightLinkGrid,
				EWuWaGoGridLinkType.AllLinkGrid
			};
		}

		// Token: 0x060039FA RID: 14842 RVA: 0x00095A4B File Offset: 0x00093C4B
		public static string[] GetNames()
		{
			return new string[]
			{
				"EmptyGrid",
				"SingleLinkGrid",
				"RightAngleLinkGrid",
				"ThreeLinkGrid",
				"StraightLinkGrid",
				"AllLinkGrid"
			};
		}
	}
}
