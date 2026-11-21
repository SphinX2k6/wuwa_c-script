using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026F4 RID: 9972
	public static class ETalkEffectTypeExtensions
	{
		// Token: 0x0600D6A4 RID: 54948 RVA: 0x001F5268 File Offset: 0x001F3468
		public static string ToEnumString(this ETalkEffectType value)
		{
			string result;
			if (value == ETalkEffectType.Effect)
			{
				result = "Effect";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D6A5 RID: 54949 RVA: 0x001F5290 File Offset: 0x001F3490
		public static ETalkEffectType FromString(string name)
		{
			ETalkEffectType result;
			if (!ETalkEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D6A6 RID: 54950 RVA: 0x001F52B9 File Offset: 0x001F34B9
		public static bool TryFromString(string name, out ETalkEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETalkEffectType.Effect;
				return false;
			}
			if (name == "Effect")
			{
				value = ETalkEffectType.Effect;
				return true;
			}
			value = ETalkEffectType.Effect;
			return false;
		}

		// Token: 0x0600D6A7 RID: 54951 RVA: 0x001F52DE File Offset: 0x001F34DE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Effect"
			};
		}

		// Token: 0x0600D6A8 RID: 54952 RVA: 0x001F52EE File Offset: 0x001F34EE
		public static ETalkEffectType[] GetValues()
		{
			return new ETalkEffectType[1];
		}

		// Token: 0x0600D6A9 RID: 54953 RVA: 0x001F52F6 File Offset: 0x001F34F6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Effect"
			};
		}
	}
}
