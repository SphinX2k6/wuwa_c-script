using System;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000EC RID: 236
	public static class ERestartTipTypeExtensions
	{
		// Token: 0x060007DC RID: 2012 RVA: 0x0003CACC File Offset: 0x0003ACCC
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

		// Token: 0x060007DD RID: 2013 RVA: 0x0003CB20 File Offset: 0x0003AD20
		public static ERestartTipType FromString(string name)
		{
			ERestartTipType result;
			if (!ERestartTipTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERestartTipType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0003CB4C File Offset: 0x0003AD4C
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

		// Token: 0x060007DF RID: 2015 RVA: 0x0003CBB4 File Offset: 0x0003ADB4
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

		// Token: 0x060007E0 RID: 2016 RVA: 0x0003CBDC File Offset: 0x0003ADDC
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

		// Token: 0x060007E1 RID: 2017 RVA: 0x0003CBEF File Offset: 0x0003ADEF
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
