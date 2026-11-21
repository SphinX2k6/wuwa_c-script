using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A77 RID: 2679
	public static class EPasserbyNpcGenerateTypeExtensions
	{
		// Token: 0x06003B2A RID: 15146 RVA: 0x00098A88 File Offset: 0x00096C88
		public static string ToEnumString(this EPasserbyNpcGenerateType value)
		{
			string result;
			if (value == EPasserbyNpcGenerateType.RandomStand)
			{
				result = "RandomStand";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003B2B RID: 15147 RVA: 0x00098AB0 File Offset: 0x00096CB0
		public static EPasserbyNpcGenerateType FromString(string name)
		{
			EPasserbyNpcGenerateType result;
			if (!EPasserbyNpcGenerateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPasserbyNpcGenerateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B2C RID: 15148 RVA: 0x00098AD9 File Offset: 0x00096CD9
		public static bool TryFromString(string name, out EPasserbyNpcGenerateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPasserbyNpcGenerateType.RandomStand;
				return false;
			}
			if (name == "RandomStand")
			{
				value = EPasserbyNpcGenerateType.RandomStand;
				return true;
			}
			value = EPasserbyNpcGenerateType.RandomStand;
			return false;
		}

		// Token: 0x06003B2D RID: 15149 RVA: 0x00098AFE File Offset: 0x00096CFE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RandomStand"
			};
		}

		// Token: 0x06003B2E RID: 15150 RVA: 0x00098B0E File Offset: 0x00096D0E
		public static EPasserbyNpcGenerateType[] GetValues()
		{
			return new EPasserbyNpcGenerateType[1];
		}

		// Token: 0x06003B2F RID: 15151 RVA: 0x00098B16 File Offset: 0x00096D16
		public static string[] GetNames()
		{
			return new string[]
			{
				"RandomStand"
			};
		}
	}
}
