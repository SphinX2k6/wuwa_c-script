using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026F2 RID: 9970
	public static class ETalkEffectActionTypeExtensions
	{
		// Token: 0x0600D69B RID: 54939 RVA: 0x001F5154 File Offset: 0x001F3354
		public static string ToEnumString(this ETalkEffectActionType value)
		{
			string result;
			if (value != ETalkEffectActionType.Play)
			{
				if (value != ETalkEffectActionType.Stop)
				{
					result = value.ToString();
				}
				else
				{
					result = "Stop";
				}
			}
			else
			{
				result = "Play";
			}
			return result;
		}

		// Token: 0x0600D69C RID: 54940 RVA: 0x001F518C File Offset: 0x001F338C
		public static ETalkEffectActionType FromString(string name)
		{
			ETalkEffectActionType result;
			if (!ETalkEffectActionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkEffectActionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D69D RID: 54941 RVA: 0x001F51B5 File Offset: 0x001F33B5
		public static bool TryFromString(string name, out ETalkEffectActionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETalkEffectActionType.Play;
				return false;
			}
			if (name == "Play")
			{
				value = ETalkEffectActionType.Play;
				return true;
			}
			if (!(name == "Stop"))
			{
				value = ETalkEffectActionType.Play;
				return false;
			}
			value = ETalkEffectActionType.Stop;
			return true;
		}

		// Token: 0x0600D69E RID: 54942 RVA: 0x001F51EE File Offset: 0x001F33EE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Play",
				"Stop"
			};
		}

		// Token: 0x0600D69F RID: 54943 RVA: 0x001F5206 File Offset: 0x001F3406
		public static ETalkEffectActionType[] GetValues()
		{
			return new ETalkEffectActionType[]
			{
				ETalkEffectActionType.Play,
				ETalkEffectActionType.Stop
			};
		}

		// Token: 0x0600D6A0 RID: 54944 RVA: 0x001F5212 File Offset: 0x001F3412
		public static string[] GetNames()
		{
			return new string[]
			{
				"Play",
				"Stop"
			};
		}
	}
}
