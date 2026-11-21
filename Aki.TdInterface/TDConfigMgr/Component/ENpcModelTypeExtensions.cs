using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A69 RID: 2665
	public static class ENpcModelTypeExtensions
	{
		// Token: 0x06003AEB RID: 15083 RVA: 0x00098078 File Offset: 0x00096278
		public static string ToEnumString(this ENpcModelType value)
		{
			string result;
			switch (value)
			{
			case ENpcModelType.Mesh:
				result = "Mesh";
				break;
			case ENpcModelType.Da:
				result = "Da";
				break;
			case ENpcModelType.CombineDa:
				result = "CombineDa";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003AEC RID: 15084 RVA: 0x000980C0 File Offset: 0x000962C0
		public static ENpcModelType FromString(string name)
		{
			ENpcModelType result;
			if (!ENpcModelTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcModelType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003AED RID: 15085 RVA: 0x000980EC File Offset: 0x000962EC
		public static bool TryFromString(string name, out ENpcModelType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENpcModelType.Mesh;
				return false;
			}
			if (name == "Mesh")
			{
				value = ENpcModelType.Mesh;
				return true;
			}
			if (name == "Da")
			{
				value = ENpcModelType.Da;
				return true;
			}
			if (!(name == "CombineDa"))
			{
				value = ENpcModelType.Mesh;
				return false;
			}
			value = ENpcModelType.CombineDa;
			return true;
		}

		// Token: 0x06003AEE RID: 15086 RVA: 0x00098142 File Offset: 0x00096342
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Mesh",
				"Da",
				"CombineDa"
			};
		}

		// Token: 0x06003AEF RID: 15087 RVA: 0x00098162 File Offset: 0x00096362
		public static ENpcModelType[] GetValues()
		{
			return new ENpcModelType[]
			{
				ENpcModelType.Mesh,
				ENpcModelType.Da,
				ENpcModelType.CombineDa
			};
		}

		// Token: 0x06003AF0 RID: 15088 RVA: 0x00098172 File Offset: 0x00096372
		public static string[] GetNames()
		{
			return new string[]
			{
				"Mesh",
				"Da",
				"CombineDa"
			};
		}
	}
}
