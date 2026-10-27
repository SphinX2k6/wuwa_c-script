using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B7 RID: 9143
	public static class EOpenQteTypeExtensions
	{
		// Token: 0x0600C736 RID: 50998 RVA: 0x001D2A9C File Offset: 0x001D0C9C
		public static string ToEnumString(this EOpenQteType value)
		{
			string result;
			if (value != EOpenQteType.PanelQte)
			{
				if (value != EOpenQteType.LevelQte)
				{
					result = value.ToString();
				}
				else
				{
					result = "LevelQte";
				}
			}
			else
			{
				result = "PanelQte";
			}
			return result;
		}

		// Token: 0x0600C737 RID: 50999 RVA: 0x001D2AD4 File Offset: 0x001D0CD4
		public static EOpenQteType FromString(string name)
		{
			EOpenQteType result;
			if (!EOpenQteTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EOpenQteType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C738 RID: 51000 RVA: 0x001D2AFD File Offset: 0x001D0CFD
		public static bool TryFromString(string name, out EOpenQteType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EOpenQteType.PanelQte;
				return false;
			}
			if (name == "PanelQte")
			{
				value = EOpenQteType.PanelQte;
				return true;
			}
			if (!(name == "LevelQte"))
			{
				value = EOpenQteType.PanelQte;
				return false;
			}
			value = EOpenQteType.LevelQte;
			return true;
		}

		// Token: 0x0600C739 RID: 51001 RVA: 0x001D2B36 File Offset: 0x001D0D36
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PanelQte",
				"LevelQte"
			};
		}

		// Token: 0x0600C73A RID: 51002 RVA: 0x001D2B4E File Offset: 0x001D0D4E
		public static EOpenQteType[] GetValues()
		{
			return new EOpenQteType[]
			{
				EOpenQteType.PanelQte,
				EOpenQteType.LevelQte
			};
		}

		// Token: 0x0600C73B RID: 51003 RVA: 0x001D2B5A File Offset: 0x001D0D5A
		public static string[] GetNames()
		{
			return new string[]
			{
				"PanelQte",
				"LevelQte"
			};
		}
	}
}
