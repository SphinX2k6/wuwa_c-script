using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ADB RID: 2779
	public static class ESpecialAnimalTypeExtensions
	{
		// Token: 0x06003CEC RID: 15596 RVA: 0x0009BFD4 File Offset: 0x0009A1D4
		public static string ToEnumString(this ESpecialAnimalType value)
		{
			string result;
			if (value == ESpecialAnimalType.CollectAnimal)
			{
				result = "CollectAnimal";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003CED RID: 15597 RVA: 0x0009BFFC File Offset: 0x0009A1FC
		public static ESpecialAnimalType FromString(string name)
		{
			ESpecialAnimalType result;
			if (!ESpecialAnimalTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecialAnimalType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003CEE RID: 15598 RVA: 0x0009C025 File Offset: 0x0009A225
		public static bool TryFromString(string name, out ESpecialAnimalType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESpecialAnimalType.CollectAnimal;
				return false;
			}
			if (name == "CollectAnimal")
			{
				value = ESpecialAnimalType.CollectAnimal;
				return true;
			}
			value = ESpecialAnimalType.CollectAnimal;
			return false;
		}

		// Token: 0x06003CEF RID: 15599 RVA: 0x0009C04A File Offset: 0x0009A24A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CollectAnimal"
			};
		}

		// Token: 0x06003CF0 RID: 15600 RVA: 0x0009C05A File Offset: 0x0009A25A
		public static ESpecialAnimalType[] GetValues()
		{
			return new ESpecialAnimalType[1];
		}

		// Token: 0x06003CF1 RID: 15601 RVA: 0x0009C062 File Offset: 0x0009A262
		public static string[] GetNames()
		{
			return new string[]
			{
				"CollectAnimal"
			};
		}
	}
}
