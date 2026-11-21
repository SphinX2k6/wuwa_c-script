using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B1 RID: 2481
	public static class ECharacterConnectorLogicTypeExtensions
	{
		// Token: 0x060037AF RID: 14255 RVA: 0x0008D2CC File Offset: 0x0008B4CC
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

		// Token: 0x060037B0 RID: 14256 RVA: 0x0008D2F4 File Offset: 0x0008B4F4
		public static ECharacterConnectorLogicType FromString(string name)
		{
			ECharacterConnectorLogicType result;
			if (!ECharacterConnectorLogicTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECharacterConnectorLogicType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037B1 RID: 14257 RVA: 0x0008D31D File Offset: 0x0008B51D
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

		// Token: 0x060037B2 RID: 14258 RVA: 0x0008D342 File Offset: 0x0008B542
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Range"
			};
		}

		// Token: 0x060037B3 RID: 14259 RVA: 0x0008D352 File Offset: 0x0008B552
		public static ECharacterConnectorLogicType[] GetValues()
		{
			return new ECharacterConnectorLogicType[1];
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x0008D35A File Offset: 0x0008B55A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Range"
			};
		}
	}
}
