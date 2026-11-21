using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B11 RID: 2833
	public static class EWuWaGoGridLinkTypeExtensions
	{
		// Token: 0x06003DDF RID: 15839 RVA: 0x0009E4AC File Offset: 0x0009C6AC
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

		// Token: 0x06003DE0 RID: 15840 RVA: 0x0009E518 File Offset: 0x0009C718
		public static EWuWaGoGridLinkType FromString(string name)
		{
			EWuWaGoGridLinkType result;
			if (!EWuWaGoGridLinkTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWuWaGoGridLinkType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003DE1 RID: 15841 RVA: 0x0009E544 File Offset: 0x0009C744
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

		// Token: 0x06003DE2 RID: 15842 RVA: 0x0009E5D0 File Offset: 0x0009C7D0
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

		// Token: 0x06003DE3 RID: 15843 RVA: 0x0009E608 File Offset: 0x0009C808
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

		// Token: 0x06003DE4 RID: 15844 RVA: 0x0009E61B File Offset: 0x0009C81B
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
