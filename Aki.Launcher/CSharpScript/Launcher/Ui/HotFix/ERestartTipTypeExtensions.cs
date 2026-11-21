using System;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000F0 RID: 240
	public static class ERestartTipTypeExtensions
	{
		// Token: 0x06000810 RID: 2064 RVA: 0x0003EE6C File Offset: 0x0003D06C
		public static string ToEnumString(this ERestartTipType value)
		{
			string result;
			switch (value)
			{
			case ERestartTipType.HotFixComplete:
				result = "HotFixRestartToCompleteHotFix";
				break;
			case ERestartTipType.RepairFilesComplete:
				result = "HotFixRestartToRepairFiles";
				break;
			case ERestartTipType.HotFixCompleteWin:
				result = "HotFixRestartToCompleteHotFixWin";
				break;
			case ERestartTipType.RepairFilesCompleteWin:
				result = "HotFixRestartToRepairFilesWin";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x0003EEC0 File Offset: 0x0003D0C0
		public static ERestartTipType FromString(string name)
		{
			ERestartTipType result;
			if (!ERestartTipTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERestartTipType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x0003EEEC File Offset: 0x0003D0EC
		public static bool TryFromString(string name, out ERestartTipType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERestartTipType.HotFixComplete;
				return false;
			}
			if (name == "HotFixRestartToCompleteHotFix")
			{
				value = ERestartTipType.HotFixComplete;
				return true;
			}
			if (name == "HotFixRestartToRepairFiles")
			{
				value = ERestartTipType.RepairFilesComplete;
				return true;
			}
			if (name == "HotFixRestartToCompleteHotFixWin")
			{
				value = ERestartTipType.HotFixCompleteWin;
				return true;
			}
			if (!(name == "HotFixRestartToRepairFilesWin"))
			{
				value = ERestartTipType.HotFixComplete;
				return false;
			}
			value = ERestartTipType.RepairFilesCompleteWin;
			return true;
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0003EF54 File Offset: 0x0003D154
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"HotFixRestartToCompleteHotFix",
				"HotFixRestartToRepairFiles",
				"HotFixRestartToCompleteHotFixWin",
				"HotFixRestartToRepairFilesWin"
			};
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x0003EF7C File Offset: 0x0003D17C
		public static ERestartTipType[] GetValues()
		{
			return new ERestartTipType[]
			{
				ERestartTipType.HotFixComplete,
				ERestartTipType.RepairFilesComplete,
				ERestartTipType.HotFixCompleteWin,
				ERestartTipType.RepairFilesCompleteWin
			};
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x0003EF8F File Offset: 0x0003D18F
		public static string[] GetNames()
		{
			return new string[]
			{
				"HotFixComplete",
				"RepairFilesComplete",
				"HotFixCompleteWin",
				"RepairFilesCompleteWin"
			};
		}
	}
}
