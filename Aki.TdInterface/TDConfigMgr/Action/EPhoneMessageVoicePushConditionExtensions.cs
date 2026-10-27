using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C5 RID: 9157
	public static class EPhoneMessageVoicePushConditionExtensions
	{
		// Token: 0x0600C775 RID: 51061 RVA: 0x001D32E4 File Offset: 0x001D14E4
		public static string ToEnumString(this EPhoneMessageVoicePushCondition value)
		{
			string result;
			if (value != EPhoneMessageVoicePushCondition.PlayVoice)
			{
				if (value != EPhoneMessageVoicePushCondition.FinishVoice)
				{
					result = value.ToString();
				}
				else
				{
					result = "FinishVoice";
				}
			}
			else
			{
				result = "PlayVoice";
			}
			return result;
		}

		// Token: 0x0600C776 RID: 51062 RVA: 0x001D331C File Offset: 0x001D151C
		public static EPhoneMessageVoicePushCondition FromString(string name)
		{
			EPhoneMessageVoicePushCondition result;
			if (!EPhoneMessageVoicePushConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhoneMessageVoicePushCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C777 RID: 51063 RVA: 0x001D3345 File Offset: 0x001D1545
		public static bool TryFromString(string name, out EPhoneMessageVoicePushCondition value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPhoneMessageVoicePushCondition.PlayVoice;
				return false;
			}
			if (name == "PlayVoice")
			{
				value = EPhoneMessageVoicePushCondition.PlayVoice;
				return true;
			}
			if (!(name == "FinishVoice"))
			{
				value = EPhoneMessageVoicePushCondition.PlayVoice;
				return false;
			}
			value = EPhoneMessageVoicePushCondition.FinishVoice;
			return true;
		}

		// Token: 0x0600C778 RID: 51064 RVA: 0x001D337E File Offset: 0x001D157E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PlayVoice",
				"FinishVoice"
			};
		}

		// Token: 0x0600C779 RID: 51065 RVA: 0x001D3396 File Offset: 0x001D1596
		public static EPhoneMessageVoicePushCondition[] GetValues()
		{
			return new EPhoneMessageVoicePushCondition[]
			{
				EPhoneMessageVoicePushCondition.PlayVoice,
				EPhoneMessageVoicePushCondition.FinishVoice
			};
		}

		// Token: 0x0600C77A RID: 51066 RVA: 0x001D33A2 File Offset: 0x001D15A2
		public static string[] GetNames()
		{
			return new string[]
			{
				"PlayVoice",
				"FinishVoice"
			};
		}
	}
}
