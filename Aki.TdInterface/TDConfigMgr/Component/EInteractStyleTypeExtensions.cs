using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A2D RID: 2605
	public static class EInteractStyleTypeExtensions
	{
		// Token: 0x060039DD RID: 14813 RVA: 0x00095A24 File Offset: 0x00093C24
		public static string ToEnumString(this EInteractStyleType value)
		{
			string result;
			if (value != EInteractStyleType.Panorama)
			{
				if (value != EInteractStyleType.EntityPart)
				{
					result = value.ToString();
				}
				else
				{
					result = "EntityPart";
				}
			}
			else
			{
				result = "Panorama";
			}
			return result;
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x00095A5C File Offset: 0x00093C5C
		public static EInteractStyleType FromString(string name)
		{
			EInteractStyleType result;
			if (!EInteractStyleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInteractStyleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060039DF RID: 14815 RVA: 0x00095A85 File Offset: 0x00093C85
		public static bool TryFromString(string name, out EInteractStyleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInteractStyleType.Panorama;
				return false;
			}
			if (name == "Panorama")
			{
				value = EInteractStyleType.Panorama;
				return true;
			}
			if (!(name == "EntityPart"))
			{
				value = EInteractStyleType.Panorama;
				return false;
			}
			value = EInteractStyleType.EntityPart;
			return true;
		}

		// Token: 0x060039E0 RID: 14816 RVA: 0x00095ABE File Offset: 0x00093CBE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Panorama",
				"EntityPart"
			};
		}

		// Token: 0x060039E1 RID: 14817 RVA: 0x00095AD6 File Offset: 0x00093CD6
		public static EInteractStyleType[] GetValues()
		{
			return new EInteractStyleType[]
			{
				EInteractStyleType.Panorama,
				EInteractStyleType.EntityPart
			};
		}

		// Token: 0x060039E2 RID: 14818 RVA: 0x00095AE2 File Offset: 0x00093CE2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Panorama",
				"EntityPart"
			};
		}
	}
}
