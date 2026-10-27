using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A16 RID: 2582
	public static class ESpecialAnimalTypeExtensions
	{
		// Token: 0x06003914 RID: 14612 RVA: 0x000936E4 File Offset: 0x000918E4
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

		// Token: 0x06003915 RID: 14613 RVA: 0x0009370C File Offset: 0x0009190C
		public static ESpecialAnimalType FromString(string name)
		{
			ESpecialAnimalType result;
			if (!ESpecialAnimalTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESpecialAnimalType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003916 RID: 14614 RVA: 0x00093735 File Offset: 0x00091935
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

		// Token: 0x06003917 RID: 14615 RVA: 0x0009375A File Offset: 0x0009195A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"CollectAnimal"
			};
		}

		// Token: 0x06003918 RID: 14616 RVA: 0x0009376A File Offset: 0x0009196A
		public static ESpecialAnimalType[] GetValues()
		{
			return new ESpecialAnimalType[1];
		}

		// Token: 0x06003919 RID: 14617 RVA: 0x00093772 File Offset: 0x00091972
		public static string[] GetNames()
		{
			return new string[]
			{
				"CollectAnimal"
			};
		}
	}
}
