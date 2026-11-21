using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AA7 RID: 2727
	public static class EProgressBarControlTypeExtensions
	{
		// Token: 0x06003C02 RID: 15362 RVA: 0x0009A294 File Offset: 0x00098494
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

		// Token: 0x06003C03 RID: 15363 RVA: 0x0009A2F4 File Offset: 0x000984F4
		public static EProgressBarControlType FromString(string name)
		{
			EProgressBarControlType result;
			if (!EProgressBarControlTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EProgressBarControlType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003C04 RID: 15364 RVA: 0x0009A320 File Offset: 0x00098520
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

		// Token: 0x06003C05 RID: 15365 RVA: 0x0009A39A File Offset: 0x0009859A
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

		// Token: 0x06003C06 RID: 15366 RVA: 0x0009A3CA File Offset: 0x000985CA
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

		// Token: 0x06003C07 RID: 15367 RVA: 0x0009A3DD File Offset: 0x000985DD
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
