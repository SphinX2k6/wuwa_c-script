using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002610 RID: 9744
	public static class EMonsterNpcInteractTypeExtensions
	{
		// Token: 0x0600D2A2 RID: 53922 RVA: 0x001E9E60 File Offset: 0x001E8060
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

		// Token: 0x0600D2A3 RID: 53923 RVA: 0x001E9E88 File Offset: 0x001E8088
		public static EMonsterNpcInteractType FromString(string name)
		{
			EMonsterNpcInteractType result;
			if (!EMonsterNpcInteractTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMonsterNpcInteractType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D2A4 RID: 53924 RVA: 0x001E9EB1 File Offset: 0x001E80B1
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

		// Token: 0x0600D2A5 RID: 53925 RVA: 0x001E9ED6 File Offset: 0x001E80D6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TriggerHook"
			};
		}

		// Token: 0x0600D2A6 RID: 53926 RVA: 0x001E9EE6 File Offset: 0x001E80E6
		public static EMonsterNpcInteractType[] GetValues()
		{
			return new EMonsterNpcInteractType[1];
		}

		// Token: 0x0600D2A7 RID: 53927 RVA: 0x001E9EEE File Offset: 0x001E80EE
		public static string[] GetNames()
		{
			return new string[]
			{
				"TriggerHook"
			};
		}
	}
}
