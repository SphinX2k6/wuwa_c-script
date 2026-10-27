using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200248D RID: 9357
	public static class ETuningStandVisualTypeExtensions
	{
		// Token: 0x0600CAF9 RID: 51961 RVA: 0x001DE2C0 File Offset: 0x001DC4C0
		public static string ToEnumString(this ETuningStandVisualType value)
		{
			string result;
			if (value != ETuningStandVisualType.Tuning)
			{
				if (value != ETuningStandVisualType.Challenge)
				{
					result = value.ToString();
				}
				else
				{
					result = "Challenge";
				}
			}
			else
			{
				result = "Tuning";
			}
			return result;
		}

		// Token: 0x0600CAFA RID: 51962 RVA: 0x001DE2F8 File Offset: 0x001DC4F8
		public static ETuningStandVisualType FromString(string name)
		{
			ETuningStandVisualType result;
			if (!ETuningStandVisualTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETuningStandVisualType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CAFB RID: 51963 RVA: 0x001DE321 File Offset: 0x001DC521
		public static bool TryFromString(string name, out ETuningStandVisualType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETuningStandVisualType.Tuning;
				return false;
			}
			if (name == "Tuning")
			{
				value = ETuningStandVisualType.Tuning;
				return true;
			}
			if (!(name == "Challenge"))
			{
				value = ETuningStandVisualType.Tuning;
				return false;
			}
			value = ETuningStandVisualType.Challenge;
			return true;
		}

		// Token: 0x0600CAFC RID: 51964 RVA: 0x001DE35A File Offset: 0x001DC55A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Tuning",
				"Challenge"
			};
		}

		// Token: 0x0600CAFD RID: 51965 RVA: 0x001DE372 File Offset: 0x001DC572
		public static ETuningStandVisualType[] GetValues()
		{
			return new ETuningStandVisualType[]
			{
				ETuningStandVisualType.Tuning,
				ETuningStandVisualType.Challenge
			};
		}

		// Token: 0x0600CAFE RID: 51966 RVA: 0x001DE37E File Offset: 0x001DC57E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Tuning",
				"Challenge"
			};
		}
	}
}
