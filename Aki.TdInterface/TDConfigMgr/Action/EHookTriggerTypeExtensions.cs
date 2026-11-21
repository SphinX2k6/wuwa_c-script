using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025CE RID: 9678
	public static class EHookTriggerTypeExtensions
	{
		// Token: 0x0600D179 RID: 53625 RVA: 0x001E5830 File Offset: 0x001E3A30
		public static string ToEnumString(this EHookTriggerType value)
		{
			string result;
			if (value == EHookTriggerType.Motor)
			{
				result = "Motor";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D17A RID: 53626 RVA: 0x001E5858 File Offset: 0x001E3A58
		public static EHookTriggerType FromString(string name)
		{
			EHookTriggerType result;
			if (!EHookTriggerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHookTriggerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D17B RID: 53627 RVA: 0x001E5881 File Offset: 0x001E3A81
		public static bool TryFromString(string name, out EHookTriggerType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EHookTriggerType.Motor;
				return false;
			}
			if (name == "Motor")
			{
				value = EHookTriggerType.Motor;
				return true;
			}
			value = EHookTriggerType.Motor;
			return false;
		}

		// Token: 0x0600D17C RID: 53628 RVA: 0x001E58A6 File Offset: 0x001E3AA6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Motor"
			};
		}

		// Token: 0x0600D17D RID: 53629 RVA: 0x001E58B6 File Offset: 0x001E3AB6
		public static EHookTriggerType[] GetValues()
		{
			return new EHookTriggerType[1];
		}

		// Token: 0x0600D17E RID: 53630 RVA: 0x001E58BE File Offset: 0x001E3ABE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Motor"
			};
		}
	}
}
