using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A8B RID: 2699
	public static class EPatrolPositionRefreshTriggerTypeExtensions
	{
		// Token: 0x06003B84 RID: 15236 RVA: 0x000993C8 File Offset: 0x000975C8
		public static string ToEnumString(this EPatrolPositionRefreshTriggerType value)
		{
			string result;
			if (value != EPatrolPositionRefreshTriggerType.EntityAwake)
			{
				if (value != EPatrolPositionRefreshTriggerType.EntityVisibilityShown)
				{
					result = value.ToString();
				}
				else
				{
					result = "EntityVisibilityShown";
				}
			}
			else
			{
				result = "EntityAwake";
			}
			return result;
		}

		// Token: 0x06003B85 RID: 15237 RVA: 0x00099400 File Offset: 0x00097600
		public static EPatrolPositionRefreshTriggerType FromString(string name)
		{
			EPatrolPositionRefreshTriggerType result;
			if (!EPatrolPositionRefreshTriggerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPatrolPositionRefreshTriggerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003B86 RID: 15238 RVA: 0x00099429 File Offset: 0x00097629
		public static bool TryFromString(string name, out EPatrolPositionRefreshTriggerType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPatrolPositionRefreshTriggerType.EntityAwake;
				return false;
			}
			if (name == "EntityAwake")
			{
				value = EPatrolPositionRefreshTriggerType.EntityAwake;
				return true;
			}
			if (!(name == "EntityVisibilityShown"))
			{
				value = EPatrolPositionRefreshTriggerType.EntityAwake;
				return false;
			}
			value = EPatrolPositionRefreshTriggerType.EntityVisibilityShown;
			return true;
		}

		// Token: 0x06003B87 RID: 15239 RVA: 0x00099462 File Offset: 0x00097662
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EntityAwake",
				"EntityVisibilityShown"
			};
		}

		// Token: 0x06003B88 RID: 15240 RVA: 0x0009947A File Offset: 0x0009767A
		public static EPatrolPositionRefreshTriggerType[] GetValues()
		{
			return new EPatrolPositionRefreshTriggerType[]
			{
				EPatrolPositionRefreshTriggerType.EntityAwake,
				EPatrolPositionRefreshTriggerType.EntityVisibilityShown
			};
		}

		// Token: 0x06003B89 RID: 15241 RVA: 0x00099486 File Offset: 0x00097686
		public static string[] GetNames()
		{
			return new string[]
			{
				"EntityAwake",
				"EntityVisibilityShown"
			};
		}
	}
}
