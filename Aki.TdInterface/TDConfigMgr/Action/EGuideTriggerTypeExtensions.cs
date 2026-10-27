using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002351 RID: 9041
	public static class EGuideTriggerTypeExtensions
	{
		// Token: 0x0600C56B RID: 50539 RVA: 0x001CD018 File Offset: 0x001CB218
		public static string ToEnumString(this EGuideTriggerType value)
		{
			string result;
			if (value != EGuideTriggerType.BeginnerGuide)
			{
				if (value != EGuideTriggerType.AttackGuide)
				{
					result = value.ToString();
				}
				else
				{
					result = "AttackGuide";
				}
			}
			else
			{
				result = "BeginnerGuide";
			}
			return result;
		}

		// Token: 0x0600C56C RID: 50540 RVA: 0x001CD050 File Offset: 0x001CB250
		public static EGuideTriggerType FromString(string name)
		{
			EGuideTriggerType result;
			if (!EGuideTriggerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGuideTriggerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C56D RID: 50541 RVA: 0x001CD079 File Offset: 0x001CB279
		public static bool TryFromString(string name, out EGuideTriggerType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGuideTriggerType.BeginnerGuide;
				return false;
			}
			if (name == "BeginnerGuide")
			{
				value = EGuideTriggerType.BeginnerGuide;
				return true;
			}
			if (!(name == "AttackGuide"))
			{
				value = EGuideTriggerType.BeginnerGuide;
				return false;
			}
			value = EGuideTriggerType.AttackGuide;
			return true;
		}

		// Token: 0x0600C56E RID: 50542 RVA: 0x001CD0B2 File Offset: 0x001CB2B2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BeginnerGuide",
				"AttackGuide"
			};
		}

		// Token: 0x0600C56F RID: 50543 RVA: 0x001CD0CA File Offset: 0x001CB2CA
		public static EGuideTriggerType[] GetValues()
		{
			return new EGuideTriggerType[]
			{
				EGuideTriggerType.BeginnerGuide,
				EGuideTriggerType.AttackGuide
			};
		}

		// Token: 0x0600C570 RID: 50544 RVA: 0x001CD0D6 File Offset: 0x001CB2D6
		public static string[] GetNames()
		{
			return new string[]
			{
				"BeginnerGuide",
				"AttackGuide"
			};
		}
	}
}
