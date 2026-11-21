using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002688 RID: 9864
	public static class EResetPresentationTypeExtensions
	{
		// Token: 0x0600D4BE RID: 54462 RVA: 0x001EE718 File Offset: 0x001EC918
		public static string ToEnumString(this EResetPresentationType value)
		{
			string result;
			if (value == EResetPresentationType.Failure)
			{
				result = "Failure";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D4BF RID: 54463 RVA: 0x001EE740 File Offset: 0x001EC940
		public static EResetPresentationType FromString(string name)
		{
			EResetPresentationType result;
			if (!EResetPresentationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResetPresentationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D4C0 RID: 54464 RVA: 0x001EE769 File Offset: 0x001EC969
		public static bool TryFromString(string name, out EResetPresentationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EResetPresentationType.Failure;
				return false;
			}
			if (name == "Failure")
			{
				value = EResetPresentationType.Failure;
				return true;
			}
			value = EResetPresentationType.Failure;
			return false;
		}

		// Token: 0x0600D4C1 RID: 54465 RVA: 0x001EE78E File Offset: 0x001EC98E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Failure"
			};
		}

		// Token: 0x0600D4C2 RID: 54466 RVA: 0x001EE79E File Offset: 0x001EC99E
		public static EResetPresentationType[] GetValues()
		{
			return new EResetPresentationType[1];
		}

		// Token: 0x0600D4C3 RID: 54467 RVA: 0x001EE7A6 File Offset: 0x001EC9A6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Failure"
			};
		}
	}
}
