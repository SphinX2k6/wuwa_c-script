using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A4E RID: 2638
	public static class EWuWaGoRoleTypeExtensions
	{
		// Token: 0x06003A10 RID: 14864 RVA: 0x00095D5C File Offset: 0x00093F5C
		public static string ToEnumString(this EWuWaGoRoleType value)
		{
			string result;
			switch (value)
			{
			case EWuWaGoRoleType.AircraftSoldiers:
				result = "AircraftSoldiers";
				break;
			case EWuWaGoRoleType.HeatFusionEnemy:
				result = "HeatFusionEnemy";
				break;
			case EWuWaGoRoleType.DiffractionEnemy:
				result = "DiffractionEnemy";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003A11 RID: 14865 RVA: 0x00095DA4 File Offset: 0x00093FA4
		public static EWuWaGoRoleType FromString(string name)
		{
			EWuWaGoRoleType result;
			if (!EWuWaGoRoleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWuWaGoRoleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003A12 RID: 14866 RVA: 0x00095DD0 File Offset: 0x00093FD0
		public static bool TryFromString(string name, out EWuWaGoRoleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EWuWaGoRoleType.AircraftSoldiers;
				return false;
			}
			if (name == "AircraftSoldiers")
			{
				value = EWuWaGoRoleType.AircraftSoldiers;
				return true;
			}
			if (name == "HeatFusionEnemy")
			{
				value = EWuWaGoRoleType.HeatFusionEnemy;
				return true;
			}
			if (!(name == "DiffractionEnemy"))
			{
				value = EWuWaGoRoleType.AircraftSoldiers;
				return false;
			}
			value = EWuWaGoRoleType.DiffractionEnemy;
			return true;
		}

		// Token: 0x06003A13 RID: 14867 RVA: 0x00095E26 File Offset: 0x00094026
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AircraftSoldiers",
				"HeatFusionEnemy",
				"DiffractionEnemy"
			};
		}

		// Token: 0x06003A14 RID: 14868 RVA: 0x00095E46 File Offset: 0x00094046
		public static EWuWaGoRoleType[] GetValues()
		{
			return new EWuWaGoRoleType[]
			{
				EWuWaGoRoleType.AircraftSoldiers,
				EWuWaGoRoleType.HeatFusionEnemy,
				EWuWaGoRoleType.DiffractionEnemy
			};
		}

		// Token: 0x06003A15 RID: 14869 RVA: 0x00095E56 File Offset: 0x00094056
		public static string[] GetNames()
		{
			return new string[]
			{
				"AircraftSoldiers",
				"HeatFusionEnemy",
				"DiffractionEnemy"
			};
		}
	}
}
