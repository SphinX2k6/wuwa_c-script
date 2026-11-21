using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025FE RID: 9726
	public static class ELogicProgramSpecialProcessExtensions
	{
		// Token: 0x0600D251 RID: 53841 RVA: 0x001E93CC File Offset: 0x001E75CC
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

		// Token: 0x0600D252 RID: 53842 RVA: 0x001E93F4 File Offset: 0x001E75F4
		public static ELogicProgramSpecialProcess FromString(string name)
		{
			ELogicProgramSpecialProcess result;
			if (!ELogicProgramSpecialProcessExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELogicProgramSpecialProcess 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D253 RID: 53843 RVA: 0x001E941D File Offset: 0x001E761D
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

		// Token: 0x0600D254 RID: 53844 RVA: 0x001E9442 File Offset: 0x001E7642
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChangeTeamOptimization"
			};
		}

		// Token: 0x0600D255 RID: 53845 RVA: 0x001E9452 File Offset: 0x001E7652
		public static ELogicProgramSpecialProcess[] GetValues()
		{
			return new ELogicProgramSpecialProcess[1];
		}

		// Token: 0x0600D256 RID: 53846 RVA: 0x001E945A File Offset: 0x001E765A
		public static string[] GetNames()
		{
			return new string[]
			{
				"ChangeTeamOptimization"
			};
		}
	}
}
