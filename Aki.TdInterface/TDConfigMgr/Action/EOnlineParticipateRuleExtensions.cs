using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002646 RID: 9798
	public static class EOnlineParticipateRuleExtensions
	{
		// Token: 0x0600D395 RID: 54165 RVA: 0x001EBDBC File Offset: 0x001E9FBC
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

		// Token: 0x0600D396 RID: 54166 RVA: 0x001EBDF4 File Offset: 0x001E9FF4
		public static EOnlineParticipateRule FromString(string name)
		{
			EOnlineParticipateRule result;
			if (!EOnlineParticipateRuleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EOnlineParticipateRule 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D397 RID: 54167 RVA: 0x001EBE1D File Offset: 0x001EA01D
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

		// Token: 0x0600D398 RID: 54168 RVA: 0x001EBE56 File Offset: 0x001EA056
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"AnyPlayer",
				"AllPlayers"
			};
		}

		// Token: 0x0600D399 RID: 54169 RVA: 0x001EBE6E File Offset: 0x001EA06E
		public static EOnlineParticipateRule[] GetValues()
		{
			return new EOnlineParticipateRule[]
			{
				EOnlineParticipateRule.AnyPlayer,
				EOnlineParticipateRule.AllPlayers
			};
		}

		// Token: 0x0600D39A RID: 54170 RVA: 0x001EBE7A File Offset: 0x001EA07A
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
