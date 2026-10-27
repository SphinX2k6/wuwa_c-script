using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200244B RID: 9291
	public static class ESystemOptionTypeExtensions
	{
		// Token: 0x0600C9D0 RID: 51664 RVA: 0x001D8A38 File Offset: 0x001D6C38
		public static string ToEnumString(this ESystemOptionType value)
		{
			string result;
			switch (value)
			{
			case ESystemOptionType.RogueRandomEvent:
				result = "RogueRandomEvent";
				break;
			case ESystemOptionType.PermanentRogueRandomEvent:
				result = "PermanentRogueRandomEvent";
				break;
			case ESystemOptionType.GravityControl:
				result = "GravityControl";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C9D1 RID: 51665 RVA: 0x001D8A80 File Offset: 0x001D6C80
		public static ESystemOptionType FromString(string name)
		{
			ESystemOptionType result;
			if (!ESystemOptionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESystemOptionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C9D2 RID: 51666 RVA: 0x001D8AAC File Offset: 0x001D6CAC
		public static bool TryFromString(string name, out ESystemOptionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESystemOptionType.RogueRandomEvent;
				return false;
			}
			if (name == "RogueRandomEvent")
			{
				value = ESystemOptionType.RogueRandomEvent;
				return true;
			}
			if (name == "PermanentRogueRandomEvent")
			{
				value = ESystemOptionType.PermanentRogueRandomEvent;
				return true;
			}
			if (!(name == "GravityControl"))
			{
				value = ESystemOptionType.RogueRandomEvent;
				return false;
			}
			value = ESystemOptionType.GravityControl;
			return true;
		}

		// Token: 0x0600C9D3 RID: 51667 RVA: 0x001D8B02 File Offset: 0x001D6D02
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RogueRandomEvent",
				"PermanentRogueRandomEvent",
				"GravityControl"
			};
		}

		// Token: 0x0600C9D4 RID: 51668 RVA: 0x001D8B22 File Offset: 0x001D6D22
		public static ESystemOptionType[] GetValues()
		{
			return new ESystemOptionType[]
			{
				ESystemOptionType.RogueRandomEvent,
				ESystemOptionType.PermanentRogueRandomEvent,
				ESystemOptionType.GravityControl
			};
		}

		// Token: 0x0600C9D5 RID: 51669 RVA: 0x001D8B32 File Offset: 0x001D6D32
		public static string[] GetNames()
		{
			return new string[]
			{
				"RogueRandomEvent",
				"PermanentRogueRandomEvent",
				"GravityControl"
			};
		}
	}
}
