using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200259C RID: 9628
	public static class EExitVehicleTypeExtensions
	{
		// Token: 0x0600D098 RID: 53400 RVA: 0x001E3A64 File Offset: 0x001E1C64
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

		// Token: 0x0600D099 RID: 53401 RVA: 0x001E3AB8 File Offset: 0x001E1CB8
		public static EExitVehicleType FromString(string name)
		{
			EExitVehicleType result;
			if (!EExitVehicleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExitVehicleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D09A RID: 53402 RVA: 0x001E3AE4 File Offset: 0x001E1CE4
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

		// Token: 0x0600D09B RID: 53403 RVA: 0x001E3B4C File Offset: 0x001E1D4C
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

		// Token: 0x0600D09C RID: 53404 RVA: 0x001E3B74 File Offset: 0x001E1D74
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

		// Token: 0x0600D09D RID: 53405 RVA: 0x001E3B87 File Offset: 0x001E1D87
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
