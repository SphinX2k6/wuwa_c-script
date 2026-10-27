using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000928 RID: 2344
	public static class EDynamicPortalCreateTypeExtensions
	{
		// Token: 0x060034E5 RID: 13541 RVA: 0x0008A45C File Offset: 0x0008865C
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

		// Token: 0x060034E6 RID: 13542 RVA: 0x0008A484 File Offset: 0x00088684
		public static EDynamicPortalCreateType FromString(string name)
		{
			EDynamicPortalCreateType result;
			if (!EDynamicPortalCreateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDynamicPortalCreateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x0008A4AD File Offset: 0x000886AD
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

		// Token: 0x060034E8 RID: 13544 RVA: 0x0008A4D2 File Offset: 0x000886D2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Bullet"
			};
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x0008A4E2 File Offset: 0x000886E2
		public static EDynamicPortalCreateType[] GetValues()
		{
			return new EDynamicPortalCreateType[1];
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x0008A4EA File Offset: 0x000886EA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Bullet"
			};
		}
	}
}
