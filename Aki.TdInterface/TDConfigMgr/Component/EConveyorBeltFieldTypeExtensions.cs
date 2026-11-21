using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C3 RID: 2499
	public static class EConveyorBeltFieldTypeExtensions
	{
		// Token: 0x06003800 RID: 14336 RVA: 0x00091688 File Offset: 0x0008F888
		public static string ToEnumString(this EConveyorBeltFieldType value)
		{
			string result;
			if (value != EConveyorBeltFieldType.DirectionalField)
			{
				if (value != EConveyorBeltFieldType.PointField)
				{
					result = value.ToString();
				}
				else
				{
					result = "PointField";
				}
			}
			else
			{
				result = "DirectionalField";
			}
			return result;
		}

		// Token: 0x06003801 RID: 14337 RVA: 0x000916C0 File Offset: 0x0008F8C0
		public static EConveyorBeltFieldType FromString(string name)
		{
			EConveyorBeltFieldType result;
			if (!EConveyorBeltFieldTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EConveyorBeltFieldType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003802 RID: 14338 RVA: 0x000916E9 File Offset: 0x0008F8E9
		public static bool TryFromString(string name, out EConveyorBeltFieldType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EConveyorBeltFieldType.DirectionalField;
				return false;
			}
			if (name == "DirectionalField")
			{
				value = EConveyorBeltFieldType.DirectionalField;
				return true;
			}
			if (!(name == "PointField"))
			{
				value = EConveyorBeltFieldType.DirectionalField;
				return false;
			}
			value = EConveyorBeltFieldType.PointField;
			return true;
		}

		// Token: 0x06003803 RID: 14339 RVA: 0x00091722 File Offset: 0x0008F922
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DirectionalField",
				"PointField"
			};
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x0009173A File Offset: 0x0008F93A
		public static EConveyorBeltFieldType[] GetValues()
		{
			return new EConveyorBeltFieldType[]
			{
				EConveyorBeltFieldType.DirectionalField,
				EConveyorBeltFieldType.PointField
			};
		}

		// Token: 0x06003805 RID: 14341 RVA: 0x00091746 File Offset: 0x0008F946
		public static string[] GetNames()
		{
			return new string[]
			{
				"DirectionalField",
				"PointField"
			};
		}
	}
}
