using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023B5 RID: 9141
	public static class EOnlineParticipateRuleExtensions
	{
		// Token: 0x0600C72D RID: 50989 RVA: 0x001D2988 File Offset: 0x001D0B88
		public static string ToEnumString(this EOnlineParticipateRule value)
		{
			string result;
			if (value != EOnlineParticipateRule.AnyPlayer)
			{
				if (value != EOnlineParticipateRule.AllPlayers)
				{
					result = value.ToString();
				}
				else
				{
					result = "AllPlayers";
				}
			}
			else
			{
				result = "AnyPlayer";
			}
			return result;
		}

		// Token: 0x0600C72E RID: 50990 RVA: 0x001D29C0 File Offset: 0x001D0BC0
		public static EOnlineParticipateRule FromString(string name)
		{
			EOnlineParticipateRule result;
			if (!EOnlineParticipateRuleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EOnlineParticipateRule 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C72F RID: 50991 RVA: 0x001D29E9 File Offset: 0x001D0BE9
		public static bool TryFromString(string name, out EOnlineParticipateRule value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EOnlineParticipateRule.AnyPlayer;
				return false;
			}
			if (name == "AnyPlayer")
			{
				value = EOnlineParticipateRule.AnyPlayer;
				return true;
			}
			if (!(name == "AllPlayers"))
			{
				value = EOnlineParticipateRule.AnyPlayer;
				return false;
			}
			value = EOnlineParticipateRule.AllPlayers;
			return true;
		}

		// Token: 0x0600C730 RID: 50992 RVA: 0x001D2A22 File Offset: 0x001D0C22
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AnyPlayer",
				"AllPlayers"
			};
		}

		// Token: 0x0600C731 RID: 50993 RVA: 0x001D2A3A File Offset: 0x001D0C3A
		public static EOnlineParticipateRule[] GetValues()
		{
			return new EOnlineParticipateRule[]
			{
				EOnlineParticipateRule.AnyPlayer,
				EOnlineParticipateRule.AllPlayers
			};
		}

		// Token: 0x0600C732 RID: 50994 RVA: 0x001D2A46 File Offset: 0x001D0C46
		public static string[] GetNames()
		{
			return new string[]
			{
				"AnyPlayer",
				"AllPlayers"
			};
		}
	}
}
