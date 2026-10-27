using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009DE RID: 2526
	public static class EProceduralMaterialTypeExtensions
	{
		// Token: 0x06003818 RID: 14360 RVA: 0x000917E4 File Offset: 0x0008F9E4
		public static string ToEnumString(this EProceduralMaterialType value)
		{
			string result;
			if (value == EProceduralMaterialType.CustomPrimitiveData)
			{
				result = "CustomPrimitiveData";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x0009180C File Offset: 0x0008FA0C
		public static EProceduralMaterialType FromString(string name)
		{
			EProceduralMaterialType result;
			if (!EProceduralMaterialTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EProceduralMaterialType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600381A RID: 14362 RVA: 0x00091835 File Offset: 0x0008FA35
		public static bool TryFromString(string name, out EProceduralMaterialType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EProceduralMaterialType.CustomPrimitiveData;
				return false;
			}
			if (name == "CustomPrimitiveData")
			{
				value = EProceduralMaterialType.CustomPrimitiveData;
				return true;
			}
			value = EProceduralMaterialType.CustomPrimitiveData;
			return false;
		}

		// Token: 0x0600381B RID: 14363 RVA: 0x0009185A File Offset: 0x0008FA5A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CustomPrimitiveData"
			};
		}

		// Token: 0x0600381C RID: 14364 RVA: 0x0009186A File Offset: 0x0008FA6A
		public static EProceduralMaterialType[] GetValues()
		{
			return new EProceduralMaterialType[1];
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x00091872 File Offset: 0x0008FA72
		public static string[] GetNames()
		{
			return new string[]
			{
				"CustomPrimitiveData"
			};
		}
	}
}
