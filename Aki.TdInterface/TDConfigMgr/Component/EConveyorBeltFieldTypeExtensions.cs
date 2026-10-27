using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000916 RID: 2326
	public static class EConveyorBeltFieldTypeExtensions
	{
		// Token: 0x06003494 RID: 13460 RVA: 0x00089B08 File Offset: 0x00087D08
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

		// Token: 0x06003495 RID: 13461 RVA: 0x00089B40 File Offset: 0x00087D40
		public static EConveyorBeltFieldType FromString(string name)
		{
			EConveyorBeltFieldType result;
			if (!EConveyorBeltFieldTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EConveyorBeltFieldType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x00089B69 File Offset: 0x00087D69
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

		// Token: 0x06003497 RID: 13463 RVA: 0x00089BA2 File Offset: 0x00087DA2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DirectionalField",
				"PointField"
			};
		}

		// Token: 0x06003498 RID: 13464 RVA: 0x00089BBA File Offset: 0x00087DBA
		public static EConveyorBeltFieldType[] GetValues()
		{
			return new EConveyorBeltFieldType[]
			{
				EConveyorBeltFieldType.DirectionalField,
				EConveyorBeltFieldType.PointField
			};
		}

		// Token: 0x06003499 RID: 13465 RVA: 0x00089BC6 File Offset: 0x00087DC6
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
