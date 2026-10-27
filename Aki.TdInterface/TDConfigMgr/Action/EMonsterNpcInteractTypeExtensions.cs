using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002387 RID: 9095
	public static class EMonsterNpcInteractTypeExtensions
	{
		// Token: 0x0600C65E RID: 50782 RVA: 0x001D0E8C File Offset: 0x001CF08C
		public static string ToEnumString(this EMonsterNpcInteractType value)
		{
			string result;
			if (value == EMonsterNpcInteractType.TriggerHook)
			{
				result = "TriggerHook";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C65F RID: 50783 RVA: 0x001D0EB4 File Offset: 0x001CF0B4
		public static EMonsterNpcInteractType FromString(string name)
		{
			EMonsterNpcInteractType result;
			if (!EMonsterNpcInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMonsterNpcInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C660 RID: 50784 RVA: 0x001D0EDD File Offset: 0x001CF0DD
		public static bool TryFromString(string name, out EMonsterNpcInteractType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMonsterNpcInteractType.TriggerHook;
				return false;
			}
			if (name == "TriggerHook")
			{
				value = EMonsterNpcInteractType.TriggerHook;
				return true;
			}
			value = EMonsterNpcInteractType.TriggerHook;
			return false;
		}

		// Token: 0x0600C661 RID: 50785 RVA: 0x001D0F02 File Offset: 0x001CF102
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TriggerHook"
			};
		}

		// Token: 0x0600C662 RID: 50786 RVA: 0x001D0F12 File Offset: 0x001CF112
		public static EMonsterNpcInteractType[] GetValues()
		{
			return new EMonsterNpcInteractType[1];
		}

		// Token: 0x0600C663 RID: 50787 RVA: 0x001D0F1A File Offset: 0x001CF11A
		public static string[] GetNames()
		{
			return new string[]
			{
				"TriggerHook"
			};
		}
	}
}
