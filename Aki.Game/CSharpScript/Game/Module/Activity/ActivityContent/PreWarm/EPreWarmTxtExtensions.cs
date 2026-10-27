using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x020062C0 RID: 25280
	public static class EPreWarmTxtExtensions
	{
		// Token: 0x0603F94E RID: 260430 RVA: 0x00F61638 File Offset: 0x00F5F838
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

		// Token: 0x0603F94F RID: 260431 RVA: 0x00F61698 File Offset: 0x00F5F898
		public static EPreWarmTxt FromString(string name)
		{
			EPreWarmTxt result;
			if (!EPreWarmTxtExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPreWarmTxt 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603F950 RID: 260432 RVA: 0x00F616C4 File Offset: 0x00F5F8C4
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

		// Token: 0x0603F951 RID: 260433 RVA: 0x00F6173E File Offset: 0x00F5F93E
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

		// Token: 0x0603F952 RID: 260434 RVA: 0x00F6176E File Offset: 0x00F5F96E
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

		// Token: 0x0603F953 RID: 260435 RVA: 0x00F61781 File Offset: 0x00F5F981
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
