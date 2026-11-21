using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200099B RID: 2459
	public static class EAnimalModelTypeExtensions
	{
		// Token: 0x0600374C RID: 14156 RVA: 0x0008C510 File Offset: 0x0008A710
		public static string ToEnumString(this EAnimalModelType value)
		{
			string result;
			if (value == EAnimalModelType.Mesh)
			{
				result = "Mesh";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600374D RID: 14157 RVA: 0x0008C538 File Offset: 0x0008A738
		public static EAnimalModelType FromString(string name)
		{
			EAnimalModelType result;
			if (!EAnimalModelTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAnimalModelType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600374E RID: 14158 RVA: 0x0008C561 File Offset: 0x0008A761
		public static bool TryFromString(string name, out EAnimalModelType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAnimalModelType.Mesh;
				return false;
			}
			if (name == "Mesh")
			{
				value = EAnimalModelType.Mesh;
				return true;
			}
			value = EAnimalModelType.Mesh;
			return false;
		}

		// Token: 0x0600374F RID: 14159 RVA: 0x0008C586 File Offset: 0x0008A786
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Mesh"
			};
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x0008C596 File Offset: 0x0008A796
		public static EAnimalModelType[] GetValues()
		{
			return new EAnimalModelType[1];
		}

		// Token: 0x06003751 RID: 14161 RVA: 0x0008C59E File Offset: 0x0008A79E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Mesh"
			};
		}
	}
}
