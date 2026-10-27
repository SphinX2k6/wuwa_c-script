using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E2 RID: 2530
	public static class EProgressBarControlTypeExtensions
	{
		// Token: 0x0600382A RID: 14378 RVA: 0x000919D4 File Offset: 0x0008FBD4
		public static string ToEnumString(this EProgressBarControlType value)
		{
			string result;
			switch (value)
			{
			case EProgressBarControlType.CaptureStrategicPoint:
				result = "CaptureStrategicPoint";
				break;
			case EProgressBarControlType.CaptureStrategicPoint2:
				result = "CaptureStrategicPoint2";
				break;
			case EProgressBarControlType.ChargingDevice:
				result = "ChargingDevice";
				break;
			case EProgressBarControlType.TimedStrikeDevice:
				result = "TimedStrikeDevice";
				break;
			case EProgressBarControlType.MatchTargetChargingDevice:
				result = "MatchTargetChargingDevice";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600382B RID: 14379 RVA: 0x00091A34 File Offset: 0x0008FC34
		public static EProgressBarControlType FromString(string name)
		{
			EProgressBarControlType result;
			if (!EProgressBarControlTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EProgressBarControlType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600382C RID: 14380 RVA: 0x00091A60 File Offset: 0x0008FC60
		public static bool TryFromString(string name, out EProgressBarControlType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EProgressBarControlType.CaptureStrategicPoint;
				return false;
			}
			if (name == "CaptureStrategicPoint")
			{
				value = EProgressBarControlType.CaptureStrategicPoint;
				return true;
			}
			if (name == "CaptureStrategicPoint2")
			{
				value = EProgressBarControlType.CaptureStrategicPoint2;
				return true;
			}
			if (name == "ChargingDevice")
			{
				value = EProgressBarControlType.ChargingDevice;
				return true;
			}
			if (name == "TimedStrikeDevice")
			{
				value = EProgressBarControlType.TimedStrikeDevice;
				return true;
			}
			if (!(name == "MatchTargetChargingDevice"))
			{
				value = EProgressBarControlType.CaptureStrategicPoint;
				return false;
			}
			value = EProgressBarControlType.MatchTargetChargingDevice;
			return true;
		}

		// Token: 0x0600382D RID: 14381 RVA: 0x00091ADA File Offset: 0x0008FCDA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CaptureStrategicPoint",
				"CaptureStrategicPoint2",
				"ChargingDevice",
				"TimedStrikeDevice",
				"MatchTargetChargingDevice"
			};
		}

		// Token: 0x0600382E RID: 14382 RVA: 0x00091B0A File Offset: 0x0008FD0A
		public static EProgressBarControlType[] GetValues()
		{
			return new EProgressBarControlType[]
			{
				EProgressBarControlType.CaptureStrategicPoint,
				EProgressBarControlType.CaptureStrategicPoint2,
				EProgressBarControlType.ChargingDevice,
				EProgressBarControlType.TimedStrikeDevice,
				EProgressBarControlType.MatchTargetChargingDevice
			};
		}

		// Token: 0x0600382F RID: 14383 RVA: 0x00091B1D File Offset: 0x0008FD1D
		public static string[] GetNames()
		{
			return new string[]
			{
				"CaptureStrategicPoint",
				"CaptureStrategicPoint2",
				"ChargingDevice",
				"TimedStrikeDevice",
				"MatchTargetChargingDevice"
			};
		}
	}
}
