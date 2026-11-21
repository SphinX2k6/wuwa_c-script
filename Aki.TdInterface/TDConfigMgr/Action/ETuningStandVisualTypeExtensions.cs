using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002730 RID: 10032
	public static class ETuningStandVisualTypeExtensions
	{
		// Token: 0x0600D7B2 RID: 55218 RVA: 0x001F8488 File Offset: 0x001F6688
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

		// Token: 0x0600D7B3 RID: 55219 RVA: 0x001F84C0 File Offset: 0x001F66C0
		public static ETuningStandVisualType FromString(string name)
		{
			ETuningStandVisualType result;
			if (!ETuningStandVisualTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETuningStandVisualType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D7B4 RID: 55220 RVA: 0x001F84E9 File Offset: 0x001F66E9
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

		// Token: 0x0600D7B5 RID: 55221 RVA: 0x001F8522 File Offset: 0x001F6722
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Tuning",
				"Challenge"
			};
		}

		// Token: 0x0600D7B6 RID: 55222 RVA: 0x001F853A File Offset: 0x001F673A
		public static ETuningStandVisualType[] GetValues()
		{
			return new ETuningStandVisualType[]
			{
				ETuningStandVisualType.Tuning,
				ETuningStandVisualType.Challenge
			};
		}

		// Token: 0x0600D7B7 RID: 55223 RVA: 0x001F8546 File Offset: 0x001F6746
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
