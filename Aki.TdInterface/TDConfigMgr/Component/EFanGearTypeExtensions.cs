using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000944 RID: 2372
	public static class EFanGearTypeExtensions
	{
		// Token: 0x06003563 RID: 13667 RVA: 0x0008B734 File Offset: 0x00089934
		public static string ToEnumString(this EFanGearType value)
		{
			string result;
			if (value != EFanGearType.ReboundPlateGear)
			{
				if (value != EFanGearType.LightDeliver)
				{
					result = value.ToString();
				}
				else
				{
					result = "LightDeliver ";
				}
			}
			else
			{
				result = "ReboundPlateGear";
			}
			return result;
		}

		// Token: 0x06003564 RID: 13668 RVA: 0x0008B76C File Offset: 0x0008996C
		public static EFanGearType FromString(string name)
		{
			EFanGearType result;
			if (!EFanGearTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFanGearType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003565 RID: 13669 RVA: 0x0008B795 File Offset: 0x00089995
		public static bool TryFromString(string name, out EFanGearType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFanGearType.ReboundPlateGear;
				return false;
			}
			if (name == "ReboundPlateGear")
			{
				value = EFanGearType.ReboundPlateGear;
				return true;
			}
			if (!(name == "LightDeliver "))
			{
				value = EFanGearType.ReboundPlateGear;
				return false;
			}
			value = EFanGearType.LightDeliver;
			return true;
		}

		// Token: 0x06003566 RID: 13670 RVA: 0x0008B7CE File Offset: 0x000899CE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ReboundPlateGear",
				"LightDeliver "
			};
		}

		// Token: 0x06003567 RID: 13671 RVA: 0x0008B7E6 File Offset: 0x000899E6
		public static EFanGearType[] GetValues()
		{
			return new EFanGearType[]
			{
				EFanGearType.ReboundPlateGear,
				EFanGearType.LightDeliver
			};
		}

		// Token: 0x06003568 RID: 13672 RVA: 0x0008B7F2 File Offset: 0x000899F2
		public static string[] GetNames()
		{
			return new string[]
			{
				"ReboundPlateGear",
				"LightDeliver"
			};
		}
	}
}
