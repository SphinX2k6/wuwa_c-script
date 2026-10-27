using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002451 RID: 9297
	public static class ETalkEffectActionTypeExtensions
	{
		// Token: 0x0600C9EB RID: 51691 RVA: 0x001DB0E4 File Offset: 0x001D92E4
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

		// Token: 0x0600C9EC RID: 51692 RVA: 0x001DB11C File Offset: 0x001D931C
		public static ETalkEffectActionType FromString(string name)
		{
			ETalkEffectActionType result;
			if (!ETalkEffectActionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkEffectActionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C9ED RID: 51693 RVA: 0x001DB145 File Offset: 0x001D9345
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

		// Token: 0x0600C9EE RID: 51694 RVA: 0x001DB17E File Offset: 0x001D937E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Play",
				"Stop"
			};
		}

		// Token: 0x0600C9EF RID: 51695 RVA: 0x001DB196 File Offset: 0x001D9396
		public static ETalkEffectActionType[] GetValues()
		{
			return new ETalkEffectActionType[]
			{
				ETalkEffectActionType.Play,
				ETalkEffectActionType.Stop
			};
		}

		// Token: 0x0600C9F0 RID: 51696 RVA: 0x001DB1A2 File Offset: 0x001D93A2
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
