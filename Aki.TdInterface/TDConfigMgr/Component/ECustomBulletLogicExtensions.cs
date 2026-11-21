using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C9 RID: 2505
	public static class ECustomBulletLogicExtensions
	{
		// Token: 0x0600381B RID: 14363 RVA: 0x00091954 File Offset: 0x0008FB54
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

		// Token: 0x0600381C RID: 14364 RVA: 0x0009197C File Offset: 0x0008FB7C
		public static ECustomBulletLogic FromString(string name)
		{
			ECustomBulletLogic result;
			if (!ECustomBulletLogicExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECustomBulletLogic 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600381D RID: 14365 RVA: 0x000919A5 File Offset: 0x0008FBA5
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

		// Token: 0x0600381E RID: 14366 RVA: 0x000919CA File Offset: 0x0008FBCA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TrafficBullet"
			};
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x000919DA File Offset: 0x0008FBDA
		public static ECustomBulletLogic[] GetValues()
		{
			return new ECustomBulletLogic[1];
		}

		// Token: 0x06003820 RID: 14368 RVA: 0x000919E2 File Offset: 0x0008FBE2
		public static string[] GetNames()
		{
			return new string[]
			{
				"TrafficBullet"
			};
		}
	}
}
