using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200263A RID: 9786
	public static class ENpcGroupPerformInitiatorTypeExtensions
	{
		// Token: 0x0600D35F RID: 54111 RVA: 0x001EB734 File Offset: 0x001E9934
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

		// Token: 0x0600D360 RID: 54112 RVA: 0x001EB75C File Offset: 0x001E995C
		public static ENpcGroupPerformInitiatorType FromString(string name)
		{
			ENpcGroupPerformInitiatorType result;
			if (!ENpcGroupPerformInitiatorTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ENpcGroupPerformInitiatorType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D361 RID: 54113 RVA: 0x001EB785 File Offset: 0x001E9985
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

		// Token: 0x0600D362 RID: 54114 RVA: 0x001EB7AA File Offset: 0x001E99AA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Player"
			};
		}

		// Token: 0x0600D363 RID: 54115 RVA: 0x001EB7BA File Offset: 0x001E99BA
		public static ENpcGroupPerformInitiatorType[] GetValues()
		{
			return new ENpcGroupPerformInitiatorType[1];
		}

		// Token: 0x0600D364 RID: 54116 RVA: 0x001EB7C2 File Offset: 0x001E99C2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Player"
			};
		}
	}
}
