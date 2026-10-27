using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002413 RID: 9235
	public static class ESetVehicleSpeedImmediatelyTypeExtensions
	{
		// Token: 0x0600C8D4 RID: 51412 RVA: 0x001D61B0 File Offset: 0x001D43B0
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

		// Token: 0x0600C8D5 RID: 51413 RVA: 0x001D61E8 File Offset: 0x001D43E8
		public static ESetVehicleSpeedImmediatelyType FromString(string name)
		{
			ESetVehicleSpeedImmediatelyType result;
			if (!ESetVehicleSpeedImmediatelyTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetVehicleSpeedImmediatelyType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C8D6 RID: 51414 RVA: 0x001D6211 File Offset: 0x001D4411
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

		// Token: 0x0600C8D7 RID: 51415 RVA: 0x001D624A File Offset: 0x001D444A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TotalSpeed",
				"HorizontalVerticalSpeed"
			};
		}

		// Token: 0x0600C8D8 RID: 51416 RVA: 0x001D6262 File Offset: 0x001D4462
		public static ESetVehicleSpeedImmediatelyType[] GetValues()
		{
			return new ESetVehicleSpeedImmediatelyType[]
			{
				ESetVehicleSpeedImmediatelyType.TotalSpeed,
				ESetVehicleSpeedImmediatelyType.HorizontalVerticalSpeed
			};
		}

		// Token: 0x0600C8D9 RID: 51417 RVA: 0x001D626E File Offset: 0x001D446E
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
