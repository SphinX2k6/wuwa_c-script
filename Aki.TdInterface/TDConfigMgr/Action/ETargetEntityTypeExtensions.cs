using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200245F RID: 9311
	public static class ETargetEntityTypeExtensions
	{
		// Token: 0x0600CA2A RID: 51754 RVA: 0x001DBE68 File Offset: 0x001DA068
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

		// Token: 0x0600CA2B RID: 51755 RVA: 0x001DBEC8 File Offset: 0x001DA0C8
		public static ETargetEntityType FromString(string name)
		{
			ETargetEntityType result;
			if (!ETargetEntityTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETargetEntityType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA2C RID: 51756 RVA: 0x001DBEF4 File Offset: 0x001DA0F4
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

		// Token: 0x0600CA2D RID: 51757 RVA: 0x001DBF6E File Offset: 0x001DA16E
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

		// Token: 0x0600CA2E RID: 51758 RVA: 0x001DBF9E File Offset: 0x001DA19E
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

		// Token: 0x0600CA2F RID: 51759 RVA: 0x001DBFB1 File Offset: 0x001DA1B1
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
