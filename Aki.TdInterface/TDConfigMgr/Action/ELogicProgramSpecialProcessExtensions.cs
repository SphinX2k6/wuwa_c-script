using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002375 RID: 9077
	public static class ELogicProgramSpecialProcessExtensions
	{
		// Token: 0x0600C60D RID: 50701 RVA: 0x001D03F8 File Offset: 0x001CE5F8
		public static string ToEnumString(this ELogicProgramSpecialProcess value)
		{
			string result;
			if (value == ELogicProgramSpecialProcess.ChangeTeamOptimization)
			{
				result = "ChangeTeamOptimization";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C60E RID: 50702 RVA: 0x001D0420 File Offset: 0x001CE620
		public static ELogicProgramSpecialProcess FromString(string name)
		{
			ELogicProgramSpecialProcess result;
			if (!ELogicProgramSpecialProcessExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELogicProgramSpecialProcess 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C60F RID: 50703 RVA: 0x001D0449 File Offset: 0x001CE649
		public static bool TryFromString(string name, out ELogicProgramSpecialProcess value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELogicProgramSpecialProcess.ChangeTeamOptimization;
				return false;
			}
			if (name == "ChangeTeamOptimization")
			{
				value = ELogicProgramSpecialProcess.ChangeTeamOptimization;
				return true;
			}
			value = ELogicProgramSpecialProcess.ChangeTeamOptimization;
			return false;
		}

		// Token: 0x0600C610 RID: 50704 RVA: 0x001D046E File Offset: 0x001CE66E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChangeTeamOptimization"
			};
		}

		// Token: 0x0600C611 RID: 50705 RVA: 0x001D047E File Offset: 0x001CE67E
		public static ELogicProgramSpecialProcess[] GetValues()
		{
			return new ELogicProgramSpecialProcess[1];
		}

		// Token: 0x0600C612 RID: 50706 RVA: 0x001D0486 File Offset: 0x001CE686
		public static string[] GetNames()
		{
			return new string[]
			{
				"ChangeTeamOptimization"
			};
		}
	}
}
