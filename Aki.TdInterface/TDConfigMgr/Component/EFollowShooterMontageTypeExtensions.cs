using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009FD RID: 2557
	public static class EFollowShooterMontageTypeExtensions
	{
		// Token: 0x06003905 RID: 14597 RVA: 0x000938E0 File Offset: 0x00091AE0
		public static string ToEnumString(this EFollowShooterMontageType value)
		{
			string result;
			if (value != EFollowShooterMontageType.Born)
			{
				if (value != EFollowShooterMontageType.Destroy)
				{
					result = value.ToString();
				}
				else
				{
					result = "Destroy";
				}
			}
			else
			{
				result = "Born";
			}
			return result;
		}

		// Token: 0x06003906 RID: 14598 RVA: 0x00093918 File Offset: 0x00091B18
		public static EFollowShooterMontageType FromString(string name)
		{
			EFollowShooterMontageType result;
			if (!EFollowShooterMontageTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFollowShooterMontageType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003907 RID: 14599 RVA: 0x00093941 File Offset: 0x00091B41
		public static bool TryFromString(string name, out EFollowShooterMontageType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFollowShooterMontageType.Born;
				return false;
			}
			if (name == "Born")
			{
				value = EFollowShooterMontageType.Born;
				return true;
			}
			if (!(name == "Destroy"))
			{
				value = EFollowShooterMontageType.Born;
				return false;
			}
			value = EFollowShooterMontageType.Destroy;
			return true;
		}

		// Token: 0x06003908 RID: 14600 RVA: 0x0009397A File Offset: 0x00091B7A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Born",
				"Destroy"
			};
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x00093992 File Offset: 0x00091B92
		public static EFollowShooterMontageType[] GetValues()
		{
			return new EFollowShooterMontageType[]
			{
				EFollowShooterMontageType.Born,
				EFollowShooterMontageType.Destroy
			};
		}

		// Token: 0x0600390A RID: 14602 RVA: 0x0009399E File Offset: 0x00091B9E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Born",
				"Destroy"
			};
		}
	}
}
