using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001264 RID: 4708
	public static class EPlayerDamageInfoTypeExtensions
	{
		// Token: 0x06006A69 RID: 27241 RVA: 0x000FF028 File Offset: 0x000FD228
		public static string ToEnumString(this EPlayerDamageInfoType value)
		{
			string result;
			if (value != EPlayerDamageInfoType.DamagePoint)
			{
				if (value != EPlayerDamageInfoType.DamagePercentage)
				{
					result = value.ToString();
				}
				else
				{
					result = "DamagePercentage";
				}
			}
			else
			{
				result = "DamagePoint";
			}
			return result;
		}

		// Token: 0x06006A6A RID: 27242 RVA: 0x000FF060 File Offset: 0x000FD260
		public static EPlayerDamageInfoType FromString(string name)
		{
			EPlayerDamageInfoType result;
			if (!EPlayerDamageInfoTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerDamageInfoType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A6B RID: 27243 RVA: 0x000FF089 File Offset: 0x000FD289
		public static bool TryFromString(string name, out EPlayerDamageInfoType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlayerDamageInfoType.DamagePoint;
				return false;
			}
			if (name == "DamagePoint")
			{
				value = EPlayerDamageInfoType.DamagePoint;
				return true;
			}
			if (!(name == "DamagePercentage"))
			{
				value = EPlayerDamageInfoType.DamagePoint;
				return false;
			}
			value = EPlayerDamageInfoType.DamagePercentage;
			return true;
		}

		// Token: 0x06006A6C RID: 27244 RVA: 0x000FF0C2 File Offset: 0x000FD2C2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DamagePoint",
				"DamagePercentage"
			};
		}

		// Token: 0x06006A6D RID: 27245 RVA: 0x000FF0DA File Offset: 0x000FD2DA
		public static EPlayerDamageInfoType[] GetValues()
		{
			return new EPlayerDamageInfoType[]
			{
				EPlayerDamageInfoType.DamagePoint,
				EPlayerDamageInfoType.DamagePercentage
			};
		}

		// Token: 0x06006A6E RID: 27246 RVA: 0x000FF0E6 File Offset: 0x000FD2E6
		public static string[] GetNames()
		{
			return new string[]
			{
				"DamagePoint",
				"DamagePercentage"
			};
		}
	}
}
