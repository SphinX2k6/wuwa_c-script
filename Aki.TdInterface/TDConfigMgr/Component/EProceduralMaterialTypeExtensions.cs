using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AA3 RID: 2723
	public static class EProceduralMaterialTypeExtensions
	{
		// Token: 0x06003BF0 RID: 15344 RVA: 0x0009A0A4 File Offset: 0x000982A4
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

		// Token: 0x06003BF1 RID: 15345 RVA: 0x0009A0CC File Offset: 0x000982CC
		public static EProceduralMaterialType FromString(string name)
		{
			EProceduralMaterialType result;
			if (!EProceduralMaterialTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EProceduralMaterialType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003BF2 RID: 15346 RVA: 0x0009A0F5 File Offset: 0x000982F5
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

		// Token: 0x06003BF3 RID: 15347 RVA: 0x0009A11A File Offset: 0x0009831A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CustomPrimitiveData"
			};
		}

		// Token: 0x06003BF4 RID: 15348 RVA: 0x0009A12A File Offset: 0x0009832A
		public static EProceduralMaterialType[] GetValues()
		{
			return new EProceduralMaterialType[1];
		}

		// Token: 0x06003BF5 RID: 15349 RVA: 0x0009A132 File Offset: 0x00098332
		public static string[] GetNames()
		{
			return new string[]
			{
				"CustomPrimitiveData"
			};
		}
	}
}
