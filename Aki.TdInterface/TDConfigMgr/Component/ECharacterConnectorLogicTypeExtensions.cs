using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000908 RID: 2312
	public static class ECharacterConnectorLogicTypeExtensions
	{
		// Token: 0x06003455 RID: 13397 RVA: 0x00085A5C File Offset: 0x00083C5C
		public static string ToEnumString(this ECharacterConnectorLogicType value)
		{
			string result;
			if (value == ECharacterConnectorLogicType.Range)
			{
				result = "Range";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003456 RID: 13398 RVA: 0x00085A84 File Offset: 0x00083C84
		public static ECharacterConnectorLogicType FromString(string name)
		{
			ECharacterConnectorLogicType result;
			if (!ECharacterConnectorLogicTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECharacterConnectorLogicType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003457 RID: 13399 RVA: 0x00085AAD File Offset: 0x00083CAD
		public static bool TryFromString(string name, out ECharacterConnectorLogicType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECharacterConnectorLogicType.Range;
				return false;
			}
			if (name == "Range")
			{
				value = ECharacterConnectorLogicType.Range;
				return true;
			}
			value = ECharacterConnectorLogicType.Range;
			return false;
		}

		// Token: 0x06003458 RID: 13400 RVA: 0x00085AD2 File Offset: 0x00083CD2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Range"
			};
		}

		// Token: 0x06003459 RID: 13401 RVA: 0x00085AE2 File Offset: 0x00083CE2
		public static ECharacterConnectorLogicType[] GetValues()
		{
			return new ECharacterConnectorLogicType[1];
		}

		// Token: 0x0600345A RID: 13402 RVA: 0x00085AEA File Offset: 0x00083CEA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Range"
			};
		}
	}
}
