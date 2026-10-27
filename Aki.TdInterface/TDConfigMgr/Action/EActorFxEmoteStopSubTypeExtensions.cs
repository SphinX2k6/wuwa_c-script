using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200228D RID: 8845
	public static class EActorFxEmoteStopSubTypeExtensions
	{
		// Token: 0x0600C1F9 RID: 49657 RVA: 0x001C523C File Offset: 0x001C343C
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

		// Token: 0x0600C1FA RID: 49658 RVA: 0x001C5274 File Offset: 0x001C3474
		public static EActorFxEmoteStopSubType FromString(string name)
		{
			EActorFxEmoteStopSubType result;
			if (!EActorFxEmoteStopSubTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EActorFxEmoteStopSubType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C1FB RID: 49659 RVA: 0x001C529D File Offset: 0x001C349D
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

		// Token: 0x0600C1FC RID: 49660 RVA: 0x001C52D6 File Offset: 0x001C34D6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"StopAll",
				"StopSockets"
			};
		}

		// Token: 0x0600C1FD RID: 49661 RVA: 0x001C52EE File Offset: 0x001C34EE
		public static EActorFxEmoteStopSubType[] GetValues()
		{
			return new EActorFxEmoteStopSubType[]
			{
				EActorFxEmoteStopSubType.StopAll,
				EActorFxEmoteStopSubType.StopSockets
			};
		}

		// Token: 0x0600C1FE RID: 49662 RVA: 0x001C52FA File Offset: 0x001C34FA
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
