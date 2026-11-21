using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002700 RID: 9984
	public static class ETargetEntityTypeExtensions
	{
		// Token: 0x0600D6DA RID: 55002 RVA: 0x001F5F1C File Offset: 0x001F411C
		public static string ToEnumString(this ETargetEntityType value)
		{
			string result;
			switch (value)
			{
			case ETargetEntityType.Target:
				result = "Target";
				break;
			case ETargetEntityType.Self:
				result = "Self";
				break;
			case ETargetEntityType.Triggered:
				result = "Triggered";
				break;
			case ETargetEntityType.Player:
				result = "Player";
				break;
			case ETargetEntityType.Vehicle:
				result = "Vehicle";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D6DB RID: 55003 RVA: 0x001F5F7C File Offset: 0x001F417C
		public static ETargetEntityType FromString(string name)
		{
			ETargetEntityType result;
			if (!ETargetEntityTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETargetEntityType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D6DC RID: 55004 RVA: 0x001F5FA8 File Offset: 0x001F41A8
		public static bool TryFromString(string name, out ETargetEntityType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETargetEntityType.Target;
				return false;
			}
			if (name == "Target")
			{
				value = ETargetEntityType.Target;
				return true;
			}
			if (name == "Self")
			{
				value = ETargetEntityType.Self;
				return true;
			}
			if (name == "Triggered")
			{
				value = ETargetEntityType.Triggered;
				return true;
			}
			if (name == "Player")
			{
				value = ETargetEntityType.Player;
				return true;
			}
			if (!(name == "Vehicle"))
			{
				value = ETargetEntityType.Target;
				return false;
			}
			value = ETargetEntityType.Vehicle;
			return true;
		}

		// Token: 0x0600D6DD RID: 55005 RVA: 0x001F6022 File Offset: 0x001F4222
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Target",
				"Self",
				"Triggered",
				"Player",
				"Vehicle"
			};
		}

		// Token: 0x0600D6DE RID: 55006 RVA: 0x001F6052 File Offset: 0x001F4252
		public static ETargetEntityType[] GetValues()
		{
			return new ETargetEntityType[]
			{
				ETargetEntityType.Target,
				ETargetEntityType.Self,
				ETargetEntityType.Triggered,
				ETargetEntityType.Player,
				ETargetEntityType.Vehicle
			};
		}

		// Token: 0x0600D6DF RID: 55007 RVA: 0x001F6065 File Offset: 0x001F4265
		public static string[] GetNames()
		{
			return new string[]
			{
				"Target",
				"Self",
				"Triggered",
				"Player",
				"Vehicle"
			};
		}
	}
}
