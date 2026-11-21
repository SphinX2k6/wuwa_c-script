using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026B2 RID: 9906
	public static class ESetVehicleSpeedImmediatelyTypeExtensions
	{
		// Token: 0x0600D57B RID: 54651 RVA: 0x001EFDAC File Offset: 0x001EDFAC
		public static string ToEnumString(this ESetVehicleSpeedImmediatelyType value)
		{
			string result;
			if (value != ESetVehicleSpeedImmediatelyType.TotalSpeed)
			{
				if (value != ESetVehicleSpeedImmediatelyType.HorizontalVerticalSpeed)
				{
					result = value.ToString();
				}
				else
				{
					result = "HorizontalVerticalSpeed";
				}
			}
			else
			{
				result = "TotalSpeed";
			}
			return result;
		}

		// Token: 0x0600D57C RID: 54652 RVA: 0x001EFDE4 File Offset: 0x001EDFE4
		public static ESetVehicleSpeedImmediatelyType FromString(string name)
		{
			ESetVehicleSpeedImmediatelyType result;
			if (!ESetVehicleSpeedImmediatelyTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetVehicleSpeedImmediatelyType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D57D RID: 54653 RVA: 0x001EFE0D File Offset: 0x001EE00D
		public static bool TryFromString(string name, out ESetVehicleSpeedImmediatelyType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESetVehicleSpeedImmediatelyType.TotalSpeed;
				return false;
			}
			if (name == "TotalSpeed")
			{
				value = ESetVehicleSpeedImmediatelyType.TotalSpeed;
				return true;
			}
			if (!(name == "HorizontalVerticalSpeed"))
			{
				value = ESetVehicleSpeedImmediatelyType.TotalSpeed;
				return false;
			}
			value = ESetVehicleSpeedImmediatelyType.HorizontalVerticalSpeed;
			return true;
		}

		// Token: 0x0600D57E RID: 54654 RVA: 0x001EFE46 File Offset: 0x001EE046
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TotalSpeed",
				"HorizontalVerticalSpeed"
			};
		}

		// Token: 0x0600D57F RID: 54655 RVA: 0x001EFE5E File Offset: 0x001EE05E
		public static ESetVehicleSpeedImmediatelyType[] GetValues()
		{
			return new ESetVehicleSpeedImmediatelyType[]
			{
				ESetVehicleSpeedImmediatelyType.TotalSpeed,
				ESetVehicleSpeedImmediatelyType.HorizontalVerticalSpeed
			};
		}

		// Token: 0x0600D580 RID: 54656 RVA: 0x001EFE6A File Offset: 0x001EE06A
		public static string[] GetNames()
		{
			return new string[]
			{
				"TotalSpeed",
				"HorizontalVerticalSpeed"
			};
		}
	}
}
