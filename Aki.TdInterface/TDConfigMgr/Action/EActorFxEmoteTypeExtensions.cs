using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024FC RID: 9468
	public static class EActorFxEmoteTypeExtensions
	{
		// Token: 0x0600CDC8 RID: 52680 RVA: 0x001DD044 File Offset: 0x001DB244
		public static string ToEnumString(this EActorFxEmoteType value)
		{
			string result;
			if (value != EActorFxEmoteType.Play)
			{
				if (value != EActorFxEmoteType.Stop)
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

		// Token: 0x0600CDC9 RID: 52681 RVA: 0x001DD07C File Offset: 0x001DB27C
		public static EActorFxEmoteType FromString(string name)
		{
			EActorFxEmoteType result;
			if (!EActorFxEmoteTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActorFxEmoteType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CDCA RID: 52682 RVA: 0x001DD0A5 File Offset: 0x001DB2A5
		public static bool TryFromString(string name, out EActorFxEmoteType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EActorFxEmoteType.Play;
				return false;
			}
			if (name == "Play")
			{
				value = EActorFxEmoteType.Play;
				return true;
			}
			if (!(name == "Stop"))
			{
				value = EActorFxEmoteType.Play;
				return false;
			}
			value = EActorFxEmoteType.Stop;
			return true;
		}

		// Token: 0x0600CDCB RID: 52683 RVA: 0x001DD0DE File Offset: 0x001DB2DE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Play",
				"Stop"
			};
		}

		// Token: 0x0600CDCC RID: 52684 RVA: 0x001DD0F6 File Offset: 0x001DB2F6
		public static EActorFxEmoteType[] GetValues()
		{
			return new EActorFxEmoteType[]
			{
				EActorFxEmoteType.Play,
				EActorFxEmoteType.Stop
			};
		}

		// Token: 0x0600CDCD RID: 52685 RVA: 0x001DD102 File Offset: 0x001DB302
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
