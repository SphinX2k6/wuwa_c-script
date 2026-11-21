using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AA1 RID: 2721
	public static class EPortalTypeExtensions
	{
		// Token: 0x06003BE7 RID: 15335 RVA: 0x00099F90 File Offset: 0x00098190
		public static string ToEnumString(this EPortalType value)
		{
			string result;
			if (value != EPortalType.Static)
			{
				if (value != EPortalType.Dynamic)
				{
					result = value.ToString();
				}
				else
				{
					result = "Dynamic";
				}
			}
			else
			{
				result = "Static";
			}
			return result;
		}

		// Token: 0x06003BE8 RID: 15336 RVA: 0x00099FC8 File Offset: 0x000981C8
		public static EPortalType FromString(string name)
		{
			EPortalType result;
			if (!EPortalTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPortalType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003BE9 RID: 15337 RVA: 0x00099FF1 File Offset: 0x000981F1
		public static bool TryFromString(string name, out EPortalType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPortalType.Static;
				return false;
			}
			if (name == "Static")
			{
				value = EPortalType.Static;
				return true;
			}
			if (!(name == "Dynamic"))
			{
				value = EPortalType.Static;
				return false;
			}
			value = EPortalType.Dynamic;
			return true;
		}

		// Token: 0x06003BEA RID: 15338 RVA: 0x0009A02A File Offset: 0x0009822A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Static",
				"Dynamic"
			};
		}

		// Token: 0x06003BEB RID: 15339 RVA: 0x0009A042 File Offset: 0x00098242
		public static EPortalType[] GetValues()
		{
			return new EPortalType[]
			{
				EPortalType.Static,
				EPortalType.Dynamic
			};
		}

		// Token: 0x06003BEC RID: 15340 RVA: 0x0009A04E File Offset: 0x0009824E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Static",
				"Dynamic"
			};
		}
	}
}
