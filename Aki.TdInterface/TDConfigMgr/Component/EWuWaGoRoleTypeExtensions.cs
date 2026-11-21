using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B17 RID: 2839
	public static class EWuWaGoRoleTypeExtensions
	{
		// Token: 0x06003DFA RID: 15866 RVA: 0x0009E92C File Offset: 0x0009CB2C
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

		// Token: 0x06003DFB RID: 15867 RVA: 0x0009E974 File Offset: 0x0009CB74
		public static EWuWaGoRoleType FromString(string name)
		{
			EWuWaGoRoleType result;
			if (!EWuWaGoRoleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EWuWaGoRoleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x0009E9A0 File Offset: 0x0009CBA0
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

		// Token: 0x06003DFD RID: 15869 RVA: 0x0009E9F6 File Offset: 0x0009CBF6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AircraftSoldiers",
				"HeatFusionEnemy",
				"DiffractionEnemy"
			};
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x0009EA16 File Offset: 0x0009CC16
		public static EWuWaGoRoleType[] GetValues()
		{
			return new EWuWaGoRoleType[]
			{
				EWuWaGoRoleType.AircraftSoldiers,
				EWuWaGoRoleType.HeatFusionEnemy,
				EWuWaGoRoleType.DiffractionEnemy
			};
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x0009EA26 File Offset: 0x0009CC26
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
