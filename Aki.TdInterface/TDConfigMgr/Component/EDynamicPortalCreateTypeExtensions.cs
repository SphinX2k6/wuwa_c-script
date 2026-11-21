using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D5 RID: 2517
	public static class EDynamicPortalCreateTypeExtensions
	{
		// Token: 0x06003851 RID: 14417 RVA: 0x00091FDC File Offset: 0x000901DC
		public static string ToEnumString(this EDynamicPortalCreateType value)
		{
			string result;
			if (value == EDynamicPortalCreateType.Bullet)
			{
				result = "Bullet";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06003852 RID: 14418 RVA: 0x00092004 File Offset: 0x00090204
		public static EDynamicPortalCreateType FromString(string name)
		{
			EDynamicPortalCreateType result;
			if (!EDynamicPortalCreateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDynamicPortalCreateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003853 RID: 14419 RVA: 0x0009202D File Offset: 0x0009022D
		public static bool TryFromString(string name, out EDynamicPortalCreateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDynamicPortalCreateType.Bullet;
				return false;
			}
			if (name == "Bullet")
			{
				value = EDynamicPortalCreateType.Bullet;
				return true;
			}
			value = EDynamicPortalCreateType.Bullet;
			return false;
		}

		// Token: 0x06003854 RID: 14420 RVA: 0x00092052 File Offset: 0x00090252
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Bullet"
			};
		}

		// Token: 0x06003855 RID: 14421 RVA: 0x00092062 File Offset: 0x00090262
		public static EDynamicPortalCreateType[] GetValues()
		{
			return new EDynamicPortalCreateType[1];
		}

		// Token: 0x06003856 RID: 14422 RVA: 0x0009206A File Offset: 0x0009026A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Bullet"
			};
		}
	}
}
