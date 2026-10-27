using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200236F RID: 9071
	public static class ELiftMoveTypeExtensions
	{
		// Token: 0x0600C5F2 RID: 50674 RVA: 0x001CFEF8 File Offset: 0x001CE0F8
		public static string ToEnumString(this ELiftMoveType value)
		{
			string result;
			switch (value)
			{
			case ELiftMoveType.Default:
				result = "Default";
				break;
			case ELiftMoveType.Teleport:
				result = "Teleport";
				break;
			case ELiftMoveType.CustomSpeed:
				result = "CustomSpeed";
				break;
			case ELiftMoveType.Circular:
				result = "Circular";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C5F3 RID: 50675 RVA: 0x001CFF4C File Offset: 0x001CE14C
		public static ELiftMoveType FromString(string name)
		{
			ELiftMoveType result;
			if (!ELiftMoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELiftMoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C5F4 RID: 50676 RVA: 0x001CFF78 File Offset: 0x001CE178
		public static bool TryFromString(string name, out ELiftMoveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELiftMoveType.Default;
				return false;
			}
			if (name == "Default")
			{
				value = ELiftMoveType.Default;
				return true;
			}
			if (name == "Teleport")
			{
				value = ELiftMoveType.Teleport;
				return true;
			}
			if (name == "CustomSpeed")
			{
				value = ELiftMoveType.CustomSpeed;
				return true;
			}
			if (!(name == "Circular"))
			{
				value = ELiftMoveType.Default;
				return false;
			}
			value = ELiftMoveType.Circular;
			return true;
		}

		// Token: 0x0600C5F5 RID: 50677 RVA: 0x001CFFE0 File Offset: 0x001CE1E0
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default",
				"Teleport",
				"CustomSpeed",
				"Circular"
			};
		}

		// Token: 0x0600C5F6 RID: 50678 RVA: 0x001D0008 File Offset: 0x001CE208
		public static ELiftMoveType[] GetValues()
		{
			return new ELiftMoveType[]
			{
				ELiftMoveType.Default,
				ELiftMoveType.Teleport,
				ELiftMoveType.CustomSpeed,
				ELiftMoveType.Circular
			};
		}

		// Token: 0x0600C5F7 RID: 50679 RVA: 0x001D001B File Offset: 0x001CE21B
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default",
				"Teleport",
				"CustomSpeed",
				"Circular"
			};
		}
	}
}
