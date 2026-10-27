using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F9 RID: 8953
	public static class EDelayRemoveTypeExtensions
	{
		// Token: 0x0600C3DF RID: 50143 RVA: 0x001C9B98 File Offset: 0x001C7D98
		public static string ToEnumString(this EDelayRemoveType value)
		{
			string result;
			if (value == EDelayRemoveType.DelayRemoveAfterSkillFinish)
			{
				result = "DelayRemoveAfterSkillFinish";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C3E0 RID: 50144 RVA: 0x001C9BC0 File Offset: 0x001C7DC0
		public static EDelayRemoveType FromString(string name)
		{
			EDelayRemoveType result;
			if (!EDelayRemoveTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDelayRemoveType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C3E1 RID: 50145 RVA: 0x001C9BE9 File Offset: 0x001C7DE9
		public static bool TryFromString(string name, out EDelayRemoveType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDelayRemoveType.DelayRemoveAfterSkillFinish;
				return false;
			}
			if (name == "DelayRemoveAfterSkillFinish")
			{
				value = EDelayRemoveType.DelayRemoveAfterSkillFinish;
				return true;
			}
			value = EDelayRemoveType.DelayRemoveAfterSkillFinish;
			return false;
		}

		// Token: 0x0600C3E2 RID: 50146 RVA: 0x001C9C0E File Offset: 0x001C7E0E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DelayRemoveAfterSkillFinish"
			};
		}

		// Token: 0x0600C3E3 RID: 50147 RVA: 0x001C9C1E File Offset: 0x001C7E1E
		public static EDelayRemoveType[] GetValues()
		{
			return new EDelayRemoveType[1];
		}

		// Token: 0x0600C3E4 RID: 50148 RVA: 0x001C9C26 File Offset: 0x001C7E26
		public static string[] GetNames()
		{
			return new string[]
			{
				"DelayRemoveAfterSkillFinish"
			};
		}
	}
}
