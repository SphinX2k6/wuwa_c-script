using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024FA RID: 9466
	public static class EActorFxEmoteStopSubTypeExtensions
	{
		// Token: 0x0600CDBF RID: 52671 RVA: 0x001DCF30 File Offset: 0x001DB130
		public static string ToEnumString(this EActorFxEmoteStopSubType value)
		{
			string result;
			if (value != EActorFxEmoteStopSubType.StopAll)
			{
				if (value != EActorFxEmoteStopSubType.StopSockets)
				{
					result = value.ToString();
				}
				else
				{
					result = "StopSockets";
				}
			}
			else
			{
				result = "StopAll";
			}
			return result;
		}

		// Token: 0x0600CDC0 RID: 52672 RVA: 0x001DCF68 File Offset: 0x001DB168
		public static EActorFxEmoteStopSubType FromString(string name)
		{
			EActorFxEmoteStopSubType result;
			if (!EActorFxEmoteStopSubTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActorFxEmoteStopSubType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CDC1 RID: 52673 RVA: 0x001DCF91 File Offset: 0x001DB191
		public static bool TryFromString(string name, out EActorFxEmoteStopSubType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EActorFxEmoteStopSubType.StopAll;
				return false;
			}
			if (name == "StopAll")
			{
				value = EActorFxEmoteStopSubType.StopAll;
				return true;
			}
			if (!(name == "StopSockets"))
			{
				value = EActorFxEmoteStopSubType.StopAll;
				return false;
			}
			value = EActorFxEmoteStopSubType.StopSockets;
			return true;
		}

		// Token: 0x0600CDC2 RID: 52674 RVA: 0x001DCFCA File Offset: 0x001DB1CA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"StopAll",
				"StopSockets"
			};
		}

		// Token: 0x0600CDC3 RID: 52675 RVA: 0x001DCFE2 File Offset: 0x001DB1E2
		public static EActorFxEmoteStopSubType[] GetValues()
		{
			return new EActorFxEmoteStopSubType[]
			{
				EActorFxEmoteStopSubType.StopAll,
				EActorFxEmoteStopSubType.StopSockets
			};
		}

		// Token: 0x0600CDC4 RID: 52676 RVA: 0x001DCFEE File Offset: 0x001DB1EE
		public static string[] GetNames()
		{
			return new string[]
			{
				"StopAll",
				"StopSockets"
			};
		}
	}
}
