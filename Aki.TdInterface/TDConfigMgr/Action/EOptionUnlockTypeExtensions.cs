using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200264C RID: 9804
	public static class EOptionUnlockTypeExtensions
	{
		// Token: 0x0600D3B0 RID: 54192 RVA: 0x001EC0C0 File Offset: 0x001EA2C0
		public static string ToEnumString(this EOptionUnlockType value)
		{
			string result;
			switch (value)
			{
			case EOptionUnlockType.OnMecha:
				result = "OnMecha";
				break;
			case EOptionUnlockType.OnMechaJetFlight:
				result = "OnMechaJetFlight";
				break;
			case EOptionUnlockType.InWater:
				result = "InWater";
				break;
			case EOptionUnlockType.OnWaterSurfaceSwimming:
				result = "OnWaterSurfaceSwimming";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D3B1 RID: 54193 RVA: 0x001EC114 File Offset: 0x001EA314
		public static EOptionUnlockType FromString(string name)
		{
			EOptionUnlockType result;
			if (!EOptionUnlockTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EOptionUnlockType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D3B2 RID: 54194 RVA: 0x001EC140 File Offset: 0x001EA340
		public static bool TryFromString(string name, out EOptionUnlockType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EOptionUnlockType.OnMecha;
				return false;
			}
			if (name == "OnMecha")
			{
				value = EOptionUnlockType.OnMecha;
				return true;
			}
			if (name == "OnMechaJetFlight")
			{
				value = EOptionUnlockType.OnMechaJetFlight;
				return true;
			}
			if (name == "InWater")
			{
				value = EOptionUnlockType.InWater;
				return true;
			}
			if (!(name == "OnWaterSurfaceSwimming"))
			{
				value = EOptionUnlockType.OnMecha;
				return false;
			}
			value = EOptionUnlockType.OnWaterSurfaceSwimming;
			return true;
		}

		// Token: 0x0600D3B3 RID: 54195 RVA: 0x001EC1A8 File Offset: 0x001EA3A8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"OnMecha",
				"OnMechaJetFlight",
				"InWater",
				"OnWaterSurfaceSwimming"
			};
		}

		// Token: 0x0600D3B4 RID: 54196 RVA: 0x001EC1D0 File Offset: 0x001EA3D0
		public static EOptionUnlockType[] GetValues()
		{
			return new EOptionUnlockType[]
			{
				EOptionUnlockType.OnMecha,
				EOptionUnlockType.OnMechaJetFlight,
				EOptionUnlockType.InWater,
				EOptionUnlockType.OnWaterSurfaceSwimming
			};
		}

		// Token: 0x0600D3B5 RID: 54197 RVA: 0x001EC1E3 File Offset: 0x001EA3E3
		public static string[] GetNames()
		{
			return new string[]
			{
				"OnMecha",
				"OnMechaJetFlight",
				"InWater",
				"OnWaterSurfaceSwimming"
			};
		}
	}
}
