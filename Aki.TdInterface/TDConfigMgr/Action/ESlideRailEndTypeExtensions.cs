using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026C0 RID: 9920
	public static class ESlideRailEndTypeExtensions
	{
		// Token: 0x0600D5BA RID: 54714 RVA: 0x001F0EFC File Offset: 0x001EF0FC
		public static string ToEnumString(this ESlideRailEndType value)
		{
			string result;
			if (value != ESlideRailEndType.Player)
			{
				if (value != ESlideRailEndType.AiFollower)
				{
					result = value.ToString();
				}
				else
				{
					result = "AiFollower";
				}
			}
			else
			{
				result = "Player";
			}
			return result;
		}

		// Token: 0x0600D5BB RID: 54715 RVA: 0x001F0F34 File Offset: 0x001EF134
		public static ESlideRailEndType FromString(string name)
		{
			ESlideRailEndType result;
			if (!ESlideRailEndTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESlideRailEndType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D5BC RID: 54716 RVA: 0x001F0F5D File Offset: 0x001EF15D
		public static bool TryFromString(string name, out ESlideRailEndType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESlideRailEndType.Player;
				return false;
			}
			if (name == "Player")
			{
				value = ESlideRailEndType.Player;
				return true;
			}
			if (!(name == "AiFollower"))
			{
				value = ESlideRailEndType.Player;
				return false;
			}
			value = ESlideRailEndType.AiFollower;
			return true;
		}

		// Token: 0x0600D5BD RID: 54717 RVA: 0x001F0F96 File Offset: 0x001EF196
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Player",
				"AiFollower"
			};
		}

		// Token: 0x0600D5BE RID: 54718 RVA: 0x001F0FAE File Offset: 0x001EF1AE
		public static ESlideRailEndType[] GetValues()
		{
			return new ESlideRailEndType[]
			{
				ESlideRailEndType.Player,
				ESlideRailEndType.AiFollower
			};
		}

		// Token: 0x0600D5BF RID: 54719 RVA: 0x001F0FBA File Offset: 0x001EF1BA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Player",
				"AiFollower"
			};
		}
	}
}
