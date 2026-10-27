using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002325 RID: 8997
	public static class EEntityVarMatchTypeExtensions
	{
		// Token: 0x0600C4A5 RID: 50341 RVA: 0x001CB2CC File Offset: 0x001C94CC
		public static string ToEnumString(this EEntityVarMatchType value)
		{
			string result;
			if (value != EEntityVarMatchType.EntityId)
			{
				if (value != EEntityVarMatchType.EntityState)
				{
					result = value.ToString();
				}
				else
				{
					result = "EntityState";
				}
			}
			else
			{
				result = "EntityId";
			}
			return result;
		}

		// Token: 0x0600C4A6 RID: 50342 RVA: 0x001CB304 File Offset: 0x001C9504
		public static EEntityVarMatchType FromString(string name)
		{
			EEntityVarMatchType result;
			if (!EEntityVarMatchTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityVarMatchType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C4A7 RID: 50343 RVA: 0x001CB32D File Offset: 0x001C952D
		public static bool TryFromString(string name, out EEntityVarMatchType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEntityVarMatchType.EntityId;
				return false;
			}
			if (name == "EntityId")
			{
				value = EEntityVarMatchType.EntityId;
				return true;
			}
			if (!(name == "EntityState"))
			{
				value = EEntityVarMatchType.EntityId;
				return false;
			}
			value = EEntityVarMatchType.EntityState;
			return true;
		}

		// Token: 0x0600C4A8 RID: 50344 RVA: 0x001CB366 File Offset: 0x001C9566
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EntityId",
				"EntityState"
			};
		}

		// Token: 0x0600C4A9 RID: 50345 RVA: 0x001CB37E File Offset: 0x001C957E
		public static EEntityVarMatchType[] GetValues()
		{
			return new EEntityVarMatchType[]
			{
				EEntityVarMatchType.EntityId,
				EEntityVarMatchType.EntityState
			};
		}

		// Token: 0x0600C4AA RID: 50346 RVA: 0x001CB38A File Offset: 0x001C958A
		public static string[] GetNames()
		{
			return new string[]
			{
				"EntityId",
				"EntityState"
			};
		}
	}
}
