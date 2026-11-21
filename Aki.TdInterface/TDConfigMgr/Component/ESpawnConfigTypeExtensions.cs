using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AD5 RID: 2773
	public static class ESpawnConfigTypeExtensions
	{
		// Token: 0x06003CD1 RID: 15569 RVA: 0x0009BD40 File Offset: 0x00099F40
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

		// Token: 0x06003CD2 RID: 15570 RVA: 0x0009BD68 File Offset: 0x00099F68
		public static ESpawnConfigType FromString(string name)
		{
			ESpawnConfigType result;
			if (!ESpawnConfigTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpawnConfigType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003CD3 RID: 15571 RVA: 0x0009BD91 File Offset: 0x00099F91
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

		// Token: 0x06003CD4 RID: 15572 RVA: 0x0009BDB6 File Offset: 0x00099FB6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TemplateMatrix"
			};
		}

		// Token: 0x06003CD5 RID: 15573 RVA: 0x0009BDC6 File Offset: 0x00099FC6
		public static ESpawnConfigType[] GetValues()
		{
			return new ESpawnConfigType[1];
		}

		// Token: 0x06003CD6 RID: 15574 RVA: 0x0009BDCE File Offset: 0x00099FCE
		public static string[] GetNames()
		{
			return new string[]
			{
				"TemplateMatrix"
			};
		}
	}
}
