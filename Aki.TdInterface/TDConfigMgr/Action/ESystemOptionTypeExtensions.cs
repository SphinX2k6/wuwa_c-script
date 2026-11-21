using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026EC RID: 9964
	public static class ESystemOptionTypeExtensions
	{
		// Token: 0x0600D680 RID: 54912 RVA: 0x001F2900 File Offset: 0x001F0B00
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
			case ESystemOptionType.LiveInteractSc:
				result = "LiveInteractSc";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D681 RID: 54913 RVA: 0x001F2954 File Offset: 0x001F0B54
		public static ESystemOptionType FromString(string name)
		{
			ESystemOptionType result;
			if (!ESystemOptionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESystemOptionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D682 RID: 54914 RVA: 0x001F2980 File Offset: 0x001F0B80
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
			if (name == "GravityControl")
			{
				value = ESystemOptionType.GravityControl;
				return true;
			}
			if (!(name == "LiveInteractSc"))
			{
				value = ESystemOptionType.RogueRandomEvent;
				return false;
			}
			value = ESystemOptionType.LiveInteractSc;
			return true;
		}

		// Token: 0x0600D683 RID: 54915 RVA: 0x001F29E8 File Offset: 0x001F0BE8
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RogueRandomEvent",
				"PermanentRogueRandomEvent",
				"GravityControl",
				"LiveInteractSc"
			};
		}

		// Token: 0x0600D684 RID: 54916 RVA: 0x001F2A10 File Offset: 0x001F0C10
		public static ESystemOptionType[] GetValues()
		{
			return new ESystemOptionType[]
			{
				ESystemOptionType.RogueRandomEvent,
				ESystemOptionType.PermanentRogueRandomEvent,
				ESystemOptionType.GravityControl,
				ESystemOptionType.LiveInteractSc
			};
		}

		// Token: 0x0600D685 RID: 54917 RVA: 0x001F2A23 File Offset: 0x001F0C23
		public static string[] GetNames()
		{
			return new string[]
			{
				"RogueRandomEvent",
				"PermanentRogueRandomEvent",
				"GravityControl",
				"LiveInteractSc"
			};
		}
	}
}
