using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002740 RID: 10048
	public static class EVehicleOptionExtensions
	{
		// Token: 0x0600D7FA RID: 55290 RVA: 0x001F8DA0 File Offset: 0x001F6FA0
		public static string ToEnumString(this EVehicleOption value)
		{
			string result;
			switch (value)
			{
			case EVehicleOption.EnterVehicle:
				result = "EnterVehicle";
				break;
			case EVehicleOption.ExitVehicle:
				result = "ExitVehicle";
				break;
			case EVehicleOption.GongduolaWaterfallClimbing:
				result = "GongduolaWaterfallClimbing";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D7FB RID: 55291 RVA: 0x001F8DE8 File Offset: 0x001F6FE8
		public static EVehicleOption FromString(string name)
		{
			EVehicleOption result;
			if (!EVehicleOptionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVehicleOption 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D7FC RID: 55292 RVA: 0x001F8E14 File Offset: 0x001F7014
		public static bool TryFromString(string name, out EVehicleOption value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVehicleOption.EnterVehicle;
				return false;
			}
			if (name == "EnterVehicle")
			{
				value = EVehicleOption.EnterVehicle;
				return true;
			}
			if (name == "ExitVehicle")
			{
				value = EVehicleOption.ExitVehicle;
				return true;
			}
			if (!(name == "GongduolaWaterfallClimbing"))
			{
				value = EVehicleOption.EnterVehicle;
				return false;
			}
			value = EVehicleOption.GongduolaWaterfallClimbing;
			return true;
		}

		// Token: 0x0600D7FD RID: 55293 RVA: 0x001F8E6A File Offset: 0x001F706A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EnterVehicle",
				"ExitVehicle",
				"GongduolaWaterfallClimbing"
			};
		}

		// Token: 0x0600D7FE RID: 55294 RVA: 0x001F8E8A File Offset: 0x001F708A
		public static EVehicleOption[] GetValues()
		{
			return new EVehicleOption[]
			{
				EVehicleOption.EnterVehicle,
				EVehicleOption.ExitVehicle,
				EVehicleOption.GongduolaWaterfallClimbing
			};
		}

		// Token: 0x0600D7FF RID: 55295 RVA: 0x001F8E9A File Offset: 0x001F709A
		public static string[] GetNames()
		{
			return new string[]
			{
				"EnterVehicle",
				"ExitVehicle",
				"GongduolaWaterfallClimbing"
			};
		}
	}
}
