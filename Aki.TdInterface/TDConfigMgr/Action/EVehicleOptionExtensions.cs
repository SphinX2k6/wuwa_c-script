using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200249D RID: 9373
	public static class EVehicleOptionExtensions
	{
		// Token: 0x0600CB41 RID: 52033 RVA: 0x001DEBD8 File Offset: 0x001DCDD8
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

		// Token: 0x0600CB42 RID: 52034 RVA: 0x001DEC20 File Offset: 0x001DCE20
		public static EVehicleOption FromString(string name)
		{
			EVehicleOption result;
			if (!EVehicleOptionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVehicleOption 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CB43 RID: 52035 RVA: 0x001DEC4C File Offset: 0x001DCE4C
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

		// Token: 0x0600CB44 RID: 52036 RVA: 0x001DECA2 File Offset: 0x001DCEA2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EnterVehicle",
				"ExitVehicle",
				"GongduolaWaterfallClimbing"
			};
		}

		// Token: 0x0600CB45 RID: 52037 RVA: 0x001DECC2 File Offset: 0x001DCEC2
		public static EVehicleOption[] GetValues()
		{
			return new EVehicleOption[]
			{
				EVehicleOption.EnterVehicle,
				EVehicleOption.ExitVehicle,
				EVehicleOption.GongduolaWaterfallClimbing
			};
		}

		// Token: 0x0600CB46 RID: 52038 RVA: 0x001DECD2 File Offset: 0x001DCED2
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
