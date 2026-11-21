using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026FE RID: 9982
	public static class ETalkOptionPreConditionTypeExtensions
	{
		// Token: 0x0600D6D1 RID: 54993 RVA: 0x001F5D94 File Offset: 0x001F3F94
		public static string ToEnumString(this ETalkOptionPreConditionType value)
		{
			string result;
			switch (value)
			{
			case ETalkOptionPreConditionType.PreOption:
				result = "PreOption";
				break;
			case ETalkOptionPreConditionType.Condition:
				result = "Condition";
				break;
			case ETalkOptionPreConditionType.FirstSelect:
				result = "FirstAppear";
				break;
			case ETalkOptionPreConditionType.SystemCondition:
				result = "SystemCondition";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D6D2 RID: 54994 RVA: 0x001F5DE8 File Offset: 0x001F3FE8
		public static ETalkOptionPreConditionType FromString(string name)
		{
			ETalkOptionPreConditionType result;
			if (!ETalkOptionPreConditionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkOptionPreConditionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D6D3 RID: 54995 RVA: 0x001F5E14 File Offset: 0x001F4014
		public static bool TryFromString(string name, out ETalkOptionPreConditionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETalkOptionPreConditionType.PreOption;
				return false;
			}
			if (name == "PreOption")
			{
				value = ETalkOptionPreConditionType.PreOption;
				return true;
			}
			if (name == "Condition")
			{
				value = ETalkOptionPreConditionType.Condition;
				return true;
			}
			if (name == "FirstAppear")
			{
				value = ETalkOptionPreConditionType.FirstSelect;
				return true;
			}
			if (!(name == "SystemCondition"))
			{
				value = ETalkOptionPreConditionType.PreOption;
				return false;
			}
			value = ETalkOptionPreConditionType.SystemCondition;
			return true;
		}

		// Token: 0x0600D6D4 RID: 54996 RVA: 0x001F5E7C File Offset: 0x001F407C
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"PreOption",
				"Condition",
				"FirstAppear",
				"SystemCondition"
			};
		}

		// Token: 0x0600D6D5 RID: 54997 RVA: 0x001F5EA4 File Offset: 0x001F40A4
		public static ETalkOptionPreConditionType[] GetValues()
		{
			return new ETalkOptionPreConditionType[]
			{
				ETalkOptionPreConditionType.PreOption,
				ETalkOptionPreConditionType.Condition,
				ETalkOptionPreConditionType.FirstSelect,
				ETalkOptionPreConditionType.SystemCondition
			};
		}

		// Token: 0x0600D6D6 RID: 54998 RVA: 0x001F5EB7 File Offset: 0x001F40B7
		public static string[] GetNames()
		{
			return new string[]
			{
				"PreOption",
				"Condition",
				"FirstSelect",
				"SystemCondition"
			};
		}
	}
}
