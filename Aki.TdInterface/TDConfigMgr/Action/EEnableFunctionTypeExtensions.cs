using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200231B RID: 8987
	public static class EEnableFunctionTypeExtensions
	{
		// Token: 0x0600C478 RID: 50296 RVA: 0x001CAD94 File Offset: 0x001C8F94
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

		// Token: 0x0600C479 RID: 50297 RVA: 0x001CADDC File Offset: 0x001C8FDC
		public static EEnableFunctionType FromString(string name)
		{
			EEnableFunctionType result;
			if (!EEnableFunctionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEnableFunctionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C47A RID: 50298 RVA: 0x001CAE08 File Offset: 0x001C9008
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

		// Token: 0x0600C47B RID: 50299 RVA: 0x001CAE5E File Offset: 0x001C905E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TeleportDungeon",
				"MotorRadioUI",
				"InteractiveItems"
			};
		}

		// Token: 0x0600C47C RID: 50300 RVA: 0x001CAE7E File Offset: 0x001C907E
		public static EEnableFunctionType[] GetValues()
		{
			return new EEnableFunctionType[]
			{
				EEnableFunctionType.TeleportDungeon,
				EEnableFunctionType.MotorRadioUI,
				EEnableFunctionType.InteractiveItems
			};
		}

		// Token: 0x0600C47D RID: 50301 RVA: 0x001CAE8E File Offset: 0x001C908E
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
