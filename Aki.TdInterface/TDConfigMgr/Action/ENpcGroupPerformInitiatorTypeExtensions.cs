using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023AD RID: 9133
	public static class ENpcGroupPerformInitiatorTypeExtensions
	{
		// Token: 0x0600C709 RID: 50953 RVA: 0x001D24B8 File Offset: 0x001D06B8
		public static string ToEnumString(this ENpcGroupPerformInitiatorType value)
		{
			string result;
			if (value == ENpcGroupPerformInitiatorType.Player)
			{
				result = "Player";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C70A RID: 50954 RVA: 0x001D24E0 File Offset: 0x001D06E0
		public static ENpcGroupPerformInitiatorType FromString(string name)
		{
			ENpcGroupPerformInitiatorType result;
			if (!ENpcGroupPerformInitiatorTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcGroupPerformInitiatorType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C70B RID: 50955 RVA: 0x001D2509 File Offset: 0x001D0709
		public static bool TryFromString(string name, out ENpcGroupPerformInitiatorType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ENpcGroupPerformInitiatorType.Player;
				return false;
			}
			if (name == "Player")
			{
				value = ENpcGroupPerformInitiatorType.Player;
				return true;
			}
			value = ENpcGroupPerformInitiatorType.Player;
			return false;
		}

		// Token: 0x0600C70C RID: 50956 RVA: 0x001D252E File Offset: 0x001D072E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Player"
			};
		}

		// Token: 0x0600C70D RID: 50957 RVA: 0x001D253E File Offset: 0x001D073E
		public static ENpcGroupPerformInitiatorType[] GetValues()
		{
			return new ENpcGroupPerformInitiatorType[1];
		}

		// Token: 0x0600C70E RID: 50958 RVA: 0x001D2546 File Offset: 0x001D0746
		public static string[] GetNames()
		{
			return new string[]
			{
				"Player"
			};
		}
	}
}
