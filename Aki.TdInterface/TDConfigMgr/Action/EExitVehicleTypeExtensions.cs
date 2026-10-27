using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200232B RID: 9003
	public static class EExitVehicleTypeExtensions
	{
		// Token: 0x0600C4C0 RID: 50368 RVA: 0x001CB9AC File Offset: 0x001C9BAC
		public static string ToEnumString(this EExitVehicleType value)
		{
			string result;
			switch (value)
			{
			case EExitVehicleType.Launch:
				result = "Launch";
				break;
			case EExitVehicleType.Teleport:
				result = "Teleport";
				break;
			case EExitVehicleType.StandUp:
				result = "StandUp";
				break;
			case EExitVehicleType.SeatStandUp:
				result = "SeatStandUp";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C4C1 RID: 50369 RVA: 0x001CBA00 File Offset: 0x001C9C00
		public static EExitVehicleType FromString(string name)
		{
			EExitVehicleType result;
			if (!EExitVehicleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExitVehicleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C4C2 RID: 50370 RVA: 0x001CBA2C File Offset: 0x001C9C2C
		public static bool TryFromString(string name, out EExitVehicleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EExitVehicleType.Launch;
				return false;
			}
			if (name == "Launch")
			{
				value = EExitVehicleType.Launch;
				return true;
			}
			if (name == "Teleport")
			{
				value = EExitVehicleType.Teleport;
				return true;
			}
			if (name == "StandUp")
			{
				value = EExitVehicleType.StandUp;
				return true;
			}
			if (!(name == "SeatStandUp"))
			{
				value = EExitVehicleType.Launch;
				return false;
			}
			value = EExitVehicleType.SeatStandUp;
			return true;
		}

		// Token: 0x0600C4C3 RID: 50371 RVA: 0x001CBA94 File Offset: 0x001C9C94
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Launch",
				"Teleport",
				"StandUp",
				"SeatStandUp"
			};
		}

		// Token: 0x0600C4C4 RID: 50372 RVA: 0x001CBABC File Offset: 0x001C9CBC
		public static EExitVehicleType[] GetValues()
		{
			return new EExitVehicleType[]
			{
				EExitVehicleType.Launch,
				EExitVehicleType.Teleport,
				EExitVehicleType.StandUp,
				EExitVehicleType.SeatStandUp
			};
		}

		// Token: 0x0600C4C5 RID: 50373 RVA: 0x001CBACF File Offset: 0x001C9CCF
		public static string[] GetNames()
		{
			return new string[]
			{
				"Launch",
				"Teleport",
				"StandUp",
				"SeatStandUp"
			};
		}
	}
}
