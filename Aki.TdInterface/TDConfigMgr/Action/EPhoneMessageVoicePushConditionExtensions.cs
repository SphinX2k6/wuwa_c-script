using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200265A RID: 9818
	public static class EPhoneMessageVoicePushConditionExtensions
	{
		// Token: 0x0600D3EF RID: 54255 RVA: 0x001EC97C File Offset: 0x001EAB7C
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

		// Token: 0x0600D3F0 RID: 54256 RVA: 0x001EC9B4 File Offset: 0x001EABB4
		public static EPhoneMessageVoicePushCondition FromString(string name)
		{
			EPhoneMessageVoicePushCondition result;
			if (!EPhoneMessageVoicePushConditionExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPhoneMessageVoicePushCondition 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D3F1 RID: 54257 RVA: 0x001EC9DD File Offset: 0x001EABDD
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

		// Token: 0x0600D3F2 RID: 54258 RVA: 0x001ECA16 File Offset: 0x001EAC16
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PlayVoice",
				"FinishVoice"
			};
		}

		// Token: 0x0600D3F3 RID: 54259 RVA: 0x001ECA2E File Offset: 0x001EAC2E
		public static EPhoneMessageVoicePushCondition[] GetValues()
		{
			return new EPhoneMessageVoicePushCondition[]
			{
				EPhoneMessageVoicePushCondition.PlayVoice,
				EPhoneMessageVoicePushCondition.FinishVoice
			};
		}

		// Token: 0x0600D3F4 RID: 54260 RVA: 0x001ECA3A File Offset: 0x001EAC3A
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
