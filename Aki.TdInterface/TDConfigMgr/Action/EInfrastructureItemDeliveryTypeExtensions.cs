using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200235D RID: 9053
	public static class EInfrastructureItemDeliveryTypeExtensions
	{
		// Token: 0x0600C5A1 RID: 50593 RVA: 0x001CD740 File Offset: 0x001CB940
		public static string ToEnumString(this EInfrastructureItemDeliveryType value)
		{
			string result;
			if (value != EInfrastructureItemDeliveryType.Observatory)
			{
				if (value != EInfrastructureItemDeliveryType.RoadBuild)
				{
					result = value.ToString();
				}
				else
				{
					result = "RoadBuild";
				}
			}
			else
			{
				result = "Observatory";
			}
			return result;
		}

		// Token: 0x0600C5A2 RID: 50594 RVA: 0x001CD778 File Offset: 0x001CB978
		public static EInfrastructureItemDeliveryType FromString(string name)
		{
			EInfrastructureItemDeliveryType result;
			if (!EInfrastructureItemDeliveryTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInfrastructureItemDeliveryType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C5A3 RID: 50595 RVA: 0x001CD7A1 File Offset: 0x001CB9A1
		public static bool TryFromString(string name, out EInfrastructureItemDeliveryType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInfrastructureItemDeliveryType.Observatory;
				return false;
			}
			if (name == "Observatory")
			{
				value = EInfrastructureItemDeliveryType.Observatory;
				return true;
			}
			if (!(name == "RoadBuild"))
			{
				value = EInfrastructureItemDeliveryType.Observatory;
				return false;
			}
			value = EInfrastructureItemDeliveryType.RoadBuild;
			return true;
		}

		// Token: 0x0600C5A4 RID: 50596 RVA: 0x001CD7DA File Offset: 0x001CB9DA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Observatory",
				"RoadBuild"
			};
		}

		// Token: 0x0600C5A5 RID: 50597 RVA: 0x001CD7F2 File Offset: 0x001CB9F2
		public static EInfrastructureItemDeliveryType[] GetValues()
		{
			return new EInfrastructureItemDeliveryType[]
			{
				EInfrastructureItemDeliveryType.Observatory,
				EInfrastructureItemDeliveryType.RoadBuild
			};
		}

		// Token: 0x0600C5A6 RID: 50598 RVA: 0x001CD7FE File Offset: 0x001CB9FE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Observatory",
				"RoadBuild"
			};
		}
	}
}
