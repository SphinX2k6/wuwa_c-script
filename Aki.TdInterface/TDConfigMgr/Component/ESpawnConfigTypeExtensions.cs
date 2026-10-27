using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A10 RID: 2576
	public static class ESpawnConfigTypeExtensions
	{
		// Token: 0x060038F9 RID: 14585 RVA: 0x00093450 File Offset: 0x00091650
		public static string ToEnumString(this ESpawnConfigType value)
		{
			string result;
			if (value == ESpawnConfigType.TemplateMatrix)
			{
				result = "TemplateMatrix";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060038FA RID: 14586 RVA: 0x00093478 File Offset: 0x00091678
		public static ESpawnConfigType FromString(string name)
		{
			ESpawnConfigType result;
			if (!ESpawnConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpawnConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038FB RID: 14587 RVA: 0x000934A1 File Offset: 0x000916A1
		public static bool TryFromString(string name, out ESpawnConfigType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESpawnConfigType.TemplateMatrix;
				return false;
			}
			if (name == "TemplateMatrix")
			{
				value = ESpawnConfigType.TemplateMatrix;
				return true;
			}
			value = ESpawnConfigType.TemplateMatrix;
			return false;
		}

		// Token: 0x060038FC RID: 14588 RVA: 0x000934C6 File Offset: 0x000916C6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TemplateMatrix"
			};
		}

		// Token: 0x060038FD RID: 14589 RVA: 0x000934D6 File Offset: 0x000916D6
		public static ESpawnConfigType[] GetValues()
		{
			return new ESpawnConfigType[1];
		}

		// Token: 0x060038FE RID: 14590 RVA: 0x000934DE File Offset: 0x000916DE
		public static string[] GetNames()
		{
			return new string[]
			{
				"TemplateMatrix"
			};
		}
	}
}
