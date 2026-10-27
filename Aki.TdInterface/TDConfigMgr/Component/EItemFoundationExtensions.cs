using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000982 RID: 2434
	public static class EItemFoundationExtensions
	{
		// Token: 0x0600367A RID: 13946 RVA: 0x0008DF14 File Offset: 0x0008C114
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

		// Token: 0x0600367B RID: 13947 RVA: 0x0008DF68 File Offset: 0x0008C168
		public static EItemFoundation FromString(string name)
		{
			EItemFoundation result;
			if (!EItemFoundationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EItemFoundation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600367C RID: 13948 RVA: 0x0008DF94 File Offset: 0x0008C194
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

		// Token: 0x0600367D RID: 13949 RVA: 0x0008DFFC File Offset: 0x0008C1FC
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

		// Token: 0x0600367E RID: 13950 RVA: 0x0008E024 File Offset: 0x0008C224
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

		// Token: 0x0600367F RID: 13951 RVA: 0x0008E037 File Offset: 0x0008C237
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
