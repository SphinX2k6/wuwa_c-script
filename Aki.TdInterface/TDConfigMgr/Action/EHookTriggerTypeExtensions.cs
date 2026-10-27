using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002359 RID: 9049
	public static class EHookTriggerTypeExtensions
	{
		// Token: 0x0600C58F RID: 50575 RVA: 0x001CD550 File Offset: 0x001CB750
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

		// Token: 0x0600C590 RID: 50576 RVA: 0x001CD578 File Offset: 0x001CB778
		public static EHookTriggerType FromString(string name)
		{
			EHookTriggerType result;
			if (!EHookTriggerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHookTriggerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C591 RID: 50577 RVA: 0x001CD5A1 File Offset: 0x001CB7A1
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

		// Token: 0x0600C592 RID: 50578 RVA: 0x001CD5C6 File Offset: 0x001CB7C6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Motor"
			};
		}

		// Token: 0x0600C593 RID: 50579 RVA: 0x001CD5D6 File Offset: 0x001CB7D6
		public static EHookTriggerType[] GetValues()
		{
			return new EHookTriggerType[1];
		}

		// Token: 0x0600C594 RID: 50580 RVA: 0x001CD5DE File Offset: 0x001CB7DE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Motor"
			};
		}
	}
}
