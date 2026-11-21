using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E9 RID: 2537
	public static class EExhibitItemTypeExtensions
	{
		// Token: 0x060038AB RID: 14507 RVA: 0x00092B28 File Offset: 0x00090D28
		public static string ToEnumString(this EExhibitItemType value)
		{
			string result;
			if (value != EExhibitItemType.Phantom)
			{
				if (value != EExhibitItemType.Weapon)
				{
					result = value.ToString();
				}
				else
				{
					result = "Weapon";
				}
			}
			else
			{
				result = "Phantom";
			}
			return result;
		}

		// Token: 0x060038AC RID: 14508 RVA: 0x00092B60 File Offset: 0x00090D60
		public static EExhibitItemType FromString(string name)
		{
			EExhibitItemType result;
			if (!EExhibitItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExhibitItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060038AD RID: 14509 RVA: 0x00092B89 File Offset: 0x00090D89
		public static bool TryFromString(string name, out EExhibitItemType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EExhibitItemType.Phantom;
				return false;
			}
			if (name == "Phantom")
			{
				value = EExhibitItemType.Phantom;
				return true;
			}
			if (!(name == "Weapon"))
			{
				value = EExhibitItemType.Phantom;
				return false;
			}
			value = EExhibitItemType.Weapon;
			return true;
		}

		// Token: 0x060038AE RID: 14510 RVA: 0x00092BC2 File Offset: 0x00090DC2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Phantom",
				"Weapon"
			};
		}

		// Token: 0x060038AF RID: 14511 RVA: 0x00092BDA File Offset: 0x00090DDA
		public static EExhibitItemType[] GetValues()
		{
			return new EExhibitItemType[]
			{
				EExhibitItemType.Phantom,
				EExhibitItemType.Weapon
			};
		}

		// Token: 0x060038B0 RID: 14512 RVA: 0x00092BE6 File Offset: 0x00090DE6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Phantom",
				"Weapon"
			};
		}
	}
}
