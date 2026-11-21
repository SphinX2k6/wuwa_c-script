using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002596 RID: 9622
	public static class EEntityVarMatchTypeExtensions
	{
		// Token: 0x0600D07D RID: 53373 RVA: 0x001E32A8 File Offset: 0x001E14A8
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

		// Token: 0x0600D07E RID: 53374 RVA: 0x001E32E0 File Offset: 0x001E14E0
		public static EEntityVarMatchType FromString(string name)
		{
			EEntityVarMatchType result;
			if (!EEntityVarMatchTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityVarMatchType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D07F RID: 53375 RVA: 0x001E3309 File Offset: 0x001E1509
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

		// Token: 0x0600D080 RID: 53376 RVA: 0x001E3342 File Offset: 0x001E1542
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EntityId",
				"EntityState"
			};
		}

		// Token: 0x0600D081 RID: 53377 RVA: 0x001E335A File Offset: 0x001E155A
		public static EEntityVarMatchType[] GetValues()
		{
			return new EEntityVarMatchType[]
			{
				EEntityVarMatchType.EntityId,
				EEntityVarMatchType.EntityState
			};
		}

		// Token: 0x0600D082 RID: 53378 RVA: 0x001E3366 File Offset: 0x001E1566
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
