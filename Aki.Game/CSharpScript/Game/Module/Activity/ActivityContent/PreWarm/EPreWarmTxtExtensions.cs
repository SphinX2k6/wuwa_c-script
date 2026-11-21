using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x0200523E RID: 21054
	public static class EPreWarmTxtExtensions
	{
		// Token: 0x0603460F RID: 214543 RVA: 0x00EA8594 File Offset: 0x00EA6794
		public static string ToEnumString(this EPreWarmTxt value)
		{
			string result;
			switch (value)
			{
			case EPreWarmTxt.RewardTxtUnFinish:
				result = "RestoreFrequency_Reward_0";
				break;
			case EPreWarmTxt.RewardTxtFinished:
				result = "RestoreFrequency_Reward_1";
				break;
			case EPreWarmTxt.BtnLockTimeTxt:
				result = "RestoreFrequency_Unlock_0";
				break;
			case EPreWarmTxt.BtnLockQuestTxt:
				result = "RestoreFrequency_Unlock_1";
				break;
			case EPreWarmTxt.TitleUnlock:
				result = "RestoreFrequency_Title_0";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06034610 RID: 214544 RVA: 0x00EA85F4 File Offset: 0x00EA67F4
		public static EPreWarmTxt FromString(string name)
		{
			EPreWarmTxt result;
			if (!EPreWarmTxtExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPreWarmTxt 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06034611 RID: 214545 RVA: 0x00EA8620 File Offset: 0x00EA6820
		public static bool TryFromString(string name, out EPreWarmTxt value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPreWarmTxt.RewardTxtUnFinish;
				return false;
			}
			if (name == "RestoreFrequency_Reward_0")
			{
				value = EPreWarmTxt.RewardTxtUnFinish;
				return true;
			}
			if (name == "RestoreFrequency_Reward_1")
			{
				value = EPreWarmTxt.RewardTxtFinished;
				return true;
			}
			if (name == "RestoreFrequency_Unlock_0")
			{
				value = EPreWarmTxt.BtnLockTimeTxt;
				return true;
			}
			if (name == "RestoreFrequency_Unlock_1")
			{
				value = EPreWarmTxt.BtnLockQuestTxt;
				return true;
			}
			if (!(name == "RestoreFrequency_Title_0"))
			{
				value = EPreWarmTxt.RewardTxtUnFinish;
				return false;
			}
			value = EPreWarmTxt.TitleUnlock;
			return true;
		}

		// Token: 0x06034612 RID: 214546 RVA: 0x00EA869A File Offset: 0x00EA689A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RestoreFrequency_Reward_0",
				"RestoreFrequency_Reward_1",
				"RestoreFrequency_Unlock_0",
				"RestoreFrequency_Unlock_1",
				"RestoreFrequency_Title_0"
			};
		}

		// Token: 0x06034613 RID: 214547 RVA: 0x00EA86CA File Offset: 0x00EA68CA
		public static EPreWarmTxt[] GetValues()
		{
			return new EPreWarmTxt[]
			{
				EPreWarmTxt.RewardTxtUnFinish,
				EPreWarmTxt.RewardTxtFinished,
				EPreWarmTxt.BtnLockTimeTxt,
				EPreWarmTxt.BtnLockQuestTxt,
				EPreWarmTxt.TitleUnlock
			};
		}

		// Token: 0x06034614 RID: 214548 RVA: 0x00EA86DD File Offset: 0x00EA68DD
		public static string[] GetNames()
		{
			return new string[]
			{
				"RewardTxtUnFinish",
				"RewardTxtFinished",
				"BtnLockTimeTxt",
				"BtnLockQuestTxt",
				"TitleUnlock"
			};
		}
	}
}
