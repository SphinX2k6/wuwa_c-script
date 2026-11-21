using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200261C RID: 9756
	public static class EMotorParkourPhaseExtensions
	{
		// Token: 0x0600D2D8 RID: 53976 RVA: 0x001EA544 File Offset: 0x001E8744
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

		// Token: 0x0600D2D9 RID: 53977 RVA: 0x001EA58C File Offset: 0x001E878C
		public static EMotorParkourPhase FromString(string name)
		{
			EMotorParkourPhase result;
			if (!EMotorParkourPhaseExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorParkourPhase 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D2DA RID: 53978 RVA: 0x001EA5B8 File Offset: 0x001E87B8
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

		// Token: 0x0600D2DB RID: 53979 RVA: 0x001EA60E File Offset: 0x001E880E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Start",
				"Finish",
				"Failed"
			};
		}

		// Token: 0x0600D2DC RID: 53980 RVA: 0x001EA62E File Offset: 0x001E882E
		public static EMotorParkourPhase[] GetValues()
		{
			return new EMotorParkourPhase[]
			{
				EMotorParkourPhase.Start,
				EMotorParkourPhase.Finish,
				EMotorParkourPhase.Failed
			};
		}

		// Token: 0x0600D2DD RID: 53981 RVA: 0x001EA63E File Offset: 0x001E883E
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
