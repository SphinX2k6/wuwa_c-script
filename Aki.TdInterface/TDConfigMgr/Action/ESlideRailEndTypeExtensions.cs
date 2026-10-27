using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002421 RID: 9249
	public static class ESlideRailEndTypeExtensions
	{
		// Token: 0x0600C913 RID: 51475 RVA: 0x001D7228 File Offset: 0x001D5428
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

		// Token: 0x0600C914 RID: 51476 RVA: 0x001D7260 File Offset: 0x001D5460
		public static ESlideRailEndType FromString(string name)
		{
			ESlideRailEndType result;
			if (!ESlideRailEndTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESlideRailEndType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C915 RID: 51477 RVA: 0x001D7289 File Offset: 0x001D5489
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

		// Token: 0x0600C916 RID: 51478 RVA: 0x001D72C2 File Offset: 0x001D54C2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Player",
				"AiFollower"
			};
		}

		// Token: 0x0600C917 RID: 51479 RVA: 0x001D72DA File Offset: 0x001D54DA
		public static ESlideRailEndType[] GetValues()
		{
			return new ESlideRailEndType[]
			{
				ESlideRailEndType.Player,
				ESlideRailEndType.AiFollower
			};
		}

		// Token: 0x0600C918 RID: 51480 RVA: 0x001D72E6 File Offset: 0x001D54E6
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
