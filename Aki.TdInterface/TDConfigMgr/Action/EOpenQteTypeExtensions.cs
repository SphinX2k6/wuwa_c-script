using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002648 RID: 9800
	public static class EOpenQteTypeExtensions
	{
		// Token: 0x0600D39E RID: 54174 RVA: 0x001EBED0 File Offset: 0x001EA0D0
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

		// Token: 0x0600D39F RID: 54175 RVA: 0x001EBF08 File Offset: 0x001EA108
		public static EOpenQteType FromString(string name)
		{
			EOpenQteType result;
			if (!EOpenQteTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EOpenQteType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D3A0 RID: 54176 RVA: 0x001EBF31 File Offset: 0x001EA131
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

		// Token: 0x0600D3A1 RID: 54177 RVA: 0x001EBF6A File Offset: 0x001EA16A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PanelQte",
				"LevelQte"
			};
		}

		// Token: 0x0600D3A2 RID: 54178 RVA: 0x001EBF82 File Offset: 0x001EA182
		public static EOpenQteType[] GetValues()
		{
			return new EOpenQteType[]
			{
				EOpenQteType.PanelQte,
				EOpenQteType.LevelQte
			};
		}

		// Token: 0x0600D3A3 RID: 54179 RVA: 0x001EBF8E File Offset: 0x001EA18E
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
