using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F3 RID: 2547
	public static class EFanGearTypeExtensions
	{
		// Token: 0x060038D8 RID: 14552 RVA: 0x000933EC File Offset: 0x000915EC
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

		// Token: 0x060038D9 RID: 14553 RVA: 0x00093424 File Offset: 0x00091624
		public static EFanGearType FromString(string name)
		{
			EFanGearType result;
			if (!EFanGearTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFanGearType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x0009344D File Offset: 0x0009164D
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

		// Token: 0x060038DB RID: 14555 RVA: 0x00093486 File Offset: 0x00091686
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ReboundPlateGear",
				"LightDeliver "
			};
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x0009349E File Offset: 0x0009169E
		public static EFanGearType[] GetValues()
		{
			return new EFanGearType[]
			{
				EFanGearType.ReboundPlateGear,
				EFanGearType.LightDeliver
			};
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x000934AA File Offset: 0x000916AA
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
