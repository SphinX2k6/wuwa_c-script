using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008F2 RID: 2290
	public static class EAnimalModelTypeExtensions
	{
		// Token: 0x060033F2 RID: 13298 RVA: 0x00084CE4 File Offset: 0x00082EE4
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

		// Token: 0x060033F3 RID: 13299 RVA: 0x00084D0C File Offset: 0x00082F0C
		public static EAnimalModelType FromString(string name)
		{
			EAnimalModelType result;
			if (!EAnimalModelTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAnimalModelType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060033F4 RID: 13300 RVA: 0x00084D35 File Offset: 0x00082F35
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

		// Token: 0x060033F5 RID: 13301 RVA: 0x00084D5A File Offset: 0x00082F5A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Mesh"
			};
		}

		// Token: 0x060033F6 RID: 13302 RVA: 0x00084D6A File Offset: 0x00082F6A
		public static EAnimalModelType[] GetValues()
		{
			return new EAnimalModelType[1];
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x00084D72 File Offset: 0x00082F72
		public static string[] GetNames()
		{
			return new string[]
			{
				"Mesh"
			};
		}
	}
}
