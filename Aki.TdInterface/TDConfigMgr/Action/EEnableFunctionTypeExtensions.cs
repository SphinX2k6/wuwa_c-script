using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200258A RID: 9610
	public static class EEnableFunctionTypeExtensions
	{
		// Token: 0x0600D047 RID: 53319 RVA: 0x001E2C5C File Offset: 0x001E0E5C
		public static string ToEnumString(this EEnableFunctionType value)
		{
			string result;
			switch (value)
			{
			case EEnableFunctionType.TeleportDungeon:
				result = "TeleportDungeon";
				break;
			case EEnableFunctionType.MotorRadioUI:
				result = "MotorRadioUI";
				break;
			case EEnableFunctionType.InteractiveItems:
				result = "InteractiveItems";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D048 RID: 53320 RVA: 0x001E2CA4 File Offset: 0x001E0EA4
		public static EEnableFunctionType FromString(string name)
		{
			EEnableFunctionType result;
			if (!EEnableFunctionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEnableFunctionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D049 RID: 53321 RVA: 0x001E2CD0 File Offset: 0x001E0ED0
		public static bool TryFromString(string name, out EEnableFunctionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEnableFunctionType.TeleportDungeon;
				return false;
			}
			if (name == "TeleportDungeon")
			{
				value = EEnableFunctionType.TeleportDungeon;
				return true;
			}
			if (name == "MotorRadioUI")
			{
				value = EEnableFunctionType.MotorRadioUI;
				return true;
			}
			if (!(name == "InteractiveItems"))
			{
				value = EEnableFunctionType.TeleportDungeon;
				return false;
			}
			value = EEnableFunctionType.InteractiveItems;
			return true;
		}

		// Token: 0x0600D04A RID: 53322 RVA: 0x001E2D26 File Offset: 0x001E0F26
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TeleportDungeon",
				"MotorRadioUI",
				"InteractiveItems"
			};
		}

		// Token: 0x0600D04B RID: 53323 RVA: 0x001E2D46 File Offset: 0x001E0F46
		public static EEnableFunctionType[] GetValues()
		{
			return new EEnableFunctionType[]
			{
				EEnableFunctionType.TeleportDungeon,
				EEnableFunctionType.MotorRadioUI,
				EEnableFunctionType.InteractiveItems
			};
		}

		// Token: 0x0600D04C RID: 53324 RVA: 0x001E2D56 File Offset: 0x001E0F56
		public static string[] GetNames()
		{
			return new string[]
			{
				"TeleportDungeon",
				"MotorRadioUI",
				"InteractiveItems"
			};
		}
	}
}
