using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022EB RID: 8939
	public static class ECommonBtPlaceholderTargetTypeExtensions
	{
		// Token: 0x0600C3A0 RID: 50080 RVA: 0x001C9378 File Offset: 0x001C7578
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

		// Token: 0x0600C3A1 RID: 50081 RVA: 0x001C93B0 File Offset: 0x001C75B0
		public static ECommonBtPlaceholderTargetType FromString(string name)
		{
			ECommonBtPlaceholderTargetType result;
			if (!ECommonBtPlaceholderTargetTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECommonBtPlaceholderTargetType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C3A2 RID: 50082 RVA: 0x001C93D9 File Offset: 0x001C75D9
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

		// Token: 0x0600C3A3 RID: 50083 RVA: 0x001C9412 File Offset: 0x001C7612
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Action",
				"Condition"
			};
		}

		// Token: 0x0600C3A4 RID: 50084 RVA: 0x001C942A File Offset: 0x001C762A
		public static ECommonBtPlaceholderTargetType[] GetValues()
		{
			return new ECommonBtPlaceholderTargetType[]
			{
				ECommonBtPlaceholderTargetType.Action,
				ECommonBtPlaceholderTargetType.Condition
			};
		}

		// Token: 0x0600C3A5 RID: 50085 RVA: 0x001C9436 File Offset: 0x001C7636
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
