using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002393 RID: 9107
	public static class EMotorParkourPhaseExtensions
	{
		// Token: 0x0600C694 RID: 50836 RVA: 0x001D1570 File Offset: 0x001CF770
		public static string ToEnumString(this EMotorParkourPhase value)
		{
			string result;
			switch (value)
			{
			case EMotorParkourPhase.Start:
				result = "Start";
				break;
			case EMotorParkourPhase.Finish:
				result = "Finish";
				break;
			case EMotorParkourPhase.Failed:
				result = "Failed";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C695 RID: 50837 RVA: 0x001D15B8 File Offset: 0x001CF7B8
		public static EMotorParkourPhase FromString(string name)
		{
			EMotorParkourPhase result;
			if (!EMotorParkourPhaseExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorParkourPhase 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C696 RID: 50838 RVA: 0x001D15E4 File Offset: 0x001CF7E4
		public static bool TryFromString(string name, out EMotorParkourPhase value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMotorParkourPhase.Start;
				return false;
			}
			if (name == "Start")
			{
				value = EMotorParkourPhase.Start;
				return true;
			}
			if (name == "Finish")
			{
				value = EMotorParkourPhase.Finish;
				return true;
			}
			if (!(name == "Failed"))
			{
				value = EMotorParkourPhase.Start;
				return false;
			}
			value = EMotorParkourPhase.Failed;
			return true;
		}

		// Token: 0x0600C697 RID: 50839 RVA: 0x001D163A File Offset: 0x001CF83A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Start",
				"Finish",
				"Failed"
			};
		}

		// Token: 0x0600C698 RID: 50840 RVA: 0x001D165A File Offset: 0x001CF85A
		public static EMotorParkourPhase[] GetValues()
		{
			return new EMotorParkourPhase[]
			{
				EMotorParkourPhase.Start,
				EMotorParkourPhase.Finish,
				EMotorParkourPhase.Failed
			};
		}

		// Token: 0x0600C699 RID: 50841 RVA: 0x001D166A File Offset: 0x001CF86A
		public static string[] GetNames()
		{
			return new string[]
			{
				"Start",
				"Finish",
				"Failed"
			};
		}
	}
}
