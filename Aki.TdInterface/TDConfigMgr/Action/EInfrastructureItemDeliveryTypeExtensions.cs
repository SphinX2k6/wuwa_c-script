using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025D2 RID: 9682
	public static class EInfrastructureItemDeliveryTypeExtensions
	{
		// Token: 0x0600D18B RID: 53643 RVA: 0x001E5A20 File Offset: 0x001E3C20
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

		// Token: 0x0600D18C RID: 53644 RVA: 0x001E5A58 File Offset: 0x001E3C58
		public static EInfrastructureItemDeliveryType FromString(string name)
		{
			EInfrastructureItemDeliveryType result;
			if (!EInfrastructureItemDeliveryTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInfrastructureItemDeliveryType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D18D RID: 53645 RVA: 0x001E5A81 File Offset: 0x001E3C81
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

		// Token: 0x0600D18E RID: 53646 RVA: 0x001E5ABA File Offset: 0x001E3CBA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Observatory",
				"RoadBuild"
			};
		}

		// Token: 0x0600D18F RID: 53647 RVA: 0x001E5AD2 File Offset: 0x001E3CD2
		public static EInfrastructureItemDeliveryType[] GetValues()
		{
			return new EInfrastructureItemDeliveryType[]
			{
				EInfrastructureItemDeliveryType.Observatory,
				EInfrastructureItemDeliveryType.RoadBuild
			};
		}

		// Token: 0x0600D190 RID: 53648 RVA: 0x001E5ADE File Offset: 0x001E3CDE
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
