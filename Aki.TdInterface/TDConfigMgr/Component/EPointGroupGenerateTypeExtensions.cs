using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A9D RID: 2717
	public static class EPointGroupGenerateTypeExtensions
	{
		// Token: 0x06003BD5 RID: 15317 RVA: 0x00099DA0 File Offset: 0x00097FA0
		public static string ToEnumString(this EPointGroupGenerateType value)
		{
			string result;
			if (value == EPointGroupGenerateType.Layer)
			{
				result = "Layer";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x00099DC8 File Offset: 0x00097FC8
		public static EPointGroupGenerateType FromString(string name)
		{
			EPointGroupGenerateType result;
			if (!EPointGroupGenerateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPointGroupGenerateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x00099DF1 File Offset: 0x00097FF1
		public static bool TryFromString(string name, out EPointGroupGenerateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPointGroupGenerateType.Layer;
				return false;
			}
			if (name == "Layer")
			{
				value = EPointGroupGenerateType.Layer;
				return true;
			}
			value = EPointGroupGenerateType.Layer;
			return false;
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x00099E16 File Offset: 0x00098016
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Layer"
			};
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x00099E26 File Offset: 0x00098026
		public static EPointGroupGenerateType[] GetValues()
		{
			return new EPointGroupGenerateType[1];
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x00099E2E File Offset: 0x0009802E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Layer"
			};
		}
	}
}
