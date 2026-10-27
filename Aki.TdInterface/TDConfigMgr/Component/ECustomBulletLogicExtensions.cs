using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200091C RID: 2332
	public static class ECustomBulletLogicExtensions
	{
		// Token: 0x060034AF RID: 13487 RVA: 0x00089DD4 File Offset: 0x00087FD4
		public static string ToEnumString(this ECustomBulletLogic value)
		{
			string result;
			if (value == ECustomBulletLogic.TrafficBullet)
			{
				result = "TrafficBullet";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x00089DFC File Offset: 0x00087FFC
		public static ECustomBulletLogic FromString(string name)
		{
			ECustomBulletLogic result;
			if (!ECustomBulletLogicExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECustomBulletLogic 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x00089E25 File Offset: 0x00088025
		public static bool TryFromString(string name, out ECustomBulletLogic value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECustomBulletLogic.TrafficBullet;
				return false;
			}
			if (name == "TrafficBullet")
			{
				value = ECustomBulletLogic.TrafficBullet;
				return true;
			}
			value = ECustomBulletLogic.TrafficBullet;
			return false;
		}

		// Token: 0x060034B2 RID: 13490 RVA: 0x00089E4A File Offset: 0x0008804A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TrafficBullet"
			};
		}

		// Token: 0x060034B3 RID: 13491 RVA: 0x00089E5A File Offset: 0x0008805A
		public static ECustomBulletLogic[] GetValues()
		{
			return new ECustomBulletLogic[1];
		}

		// Token: 0x060034B4 RID: 13492 RVA: 0x00089E62 File Offset: 0x00088062
		public static string[] GetNames()
		{
			return new string[]
			{
				"TrafficBullet"
			};
		}
	}
}
