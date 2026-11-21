using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200255A RID: 9562
	public static class ECommonBtPlaceholderTargetTypeExtensions
	{
		// Token: 0x0600CF6F RID: 53103 RVA: 0x001E11C4 File Offset: 0x001DF3C4
		public static string ToEnumString(this ECommonBtPlaceholderTargetType value)
		{
			string result;
			if (value != ECommonBtPlaceholderTargetType.Action)
			{
				if (value != ECommonBtPlaceholderTargetType.Condition)
				{
					result = value.ToString();
				}
				else
				{
					result = "Condition";
				}
			}
			else
			{
				result = "Action";
			}
			return result;
		}

		// Token: 0x0600CF70 RID: 53104 RVA: 0x001E11FC File Offset: 0x001DF3FC
		public static ECommonBtPlaceholderTargetType FromString(string name)
		{
			ECommonBtPlaceholderTargetType result;
			if (!ECommonBtPlaceholderTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECommonBtPlaceholderTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CF71 RID: 53105 RVA: 0x001E1225 File Offset: 0x001DF425
		public static bool TryFromString(string name, out ECommonBtPlaceholderTargetType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECommonBtPlaceholderTargetType.Action;
				return false;
			}
			if (name == "Action")
			{
				value = ECommonBtPlaceholderTargetType.Action;
				return true;
			}
			if (!(name == "Condition"))
			{
				value = ECommonBtPlaceholderTargetType.Action;
				return false;
			}
			value = ECommonBtPlaceholderTargetType.Condition;
			return true;
		}

		// Token: 0x0600CF72 RID: 53106 RVA: 0x001E125E File Offset: 0x001DF45E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Action",
				"Condition"
			};
		}

		// Token: 0x0600CF73 RID: 53107 RVA: 0x001E1276 File Offset: 0x001DF476
		public static ECommonBtPlaceholderTargetType[] GetValues()
		{
			return new ECommonBtPlaceholderTargetType[]
			{
				ECommonBtPlaceholderTargetType.Action,
				ECommonBtPlaceholderTargetType.Condition
			};
		}

		// Token: 0x0600CF74 RID: 53108 RVA: 0x001E1282 File Offset: 0x001DF482
		public static string[] GetNames()
		{
			return new string[]
			{
				"Action",
				"Condition"
			};
		}
	}
}
