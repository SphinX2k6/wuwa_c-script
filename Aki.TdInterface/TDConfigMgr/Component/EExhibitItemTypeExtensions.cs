using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200093C RID: 2364
	public static class EExhibitItemTypeExtensions
	{
		// Token: 0x0600353F RID: 13631 RVA: 0x0008AFA8 File Offset: 0x000891A8
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

		// Token: 0x06003540 RID: 13632 RVA: 0x0008AFE0 File Offset: 0x000891E0
		public static EExhibitItemType FromString(string name)
		{
			EExhibitItemType result;
			if (!EExhibitItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EExhibitItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x0008B009 File Offset: 0x00089209
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

		// Token: 0x06003542 RID: 13634 RVA: 0x0008B042 File Offset: 0x00089242
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Phantom",
				"Weapon"
			};
		}

		// Token: 0x06003543 RID: 13635 RVA: 0x0008B05A File Offset: 0x0008925A
		public static EExhibitItemType[] GetValues()
		{
			return new EExhibitItemType[]
			{
				EExhibitItemType.Phantom,
				EExhibitItemType.Weapon
			};
		}

		// Token: 0x06003544 RID: 13636 RVA: 0x0008B066 File Offset: 0x00089266
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
