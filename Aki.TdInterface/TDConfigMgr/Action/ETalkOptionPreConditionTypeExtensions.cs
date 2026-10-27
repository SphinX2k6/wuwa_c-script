using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200245D RID: 9309
	public static class ETalkOptionPreConditionTypeExtensions
	{
		// Token: 0x0600CA21 RID: 51745 RVA: 0x001DBCE0 File Offset: 0x001D9EE0
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

		// Token: 0x0600CA22 RID: 51746 RVA: 0x001DBD34 File Offset: 0x001D9F34
		public static ETalkOptionPreConditionType FromString(string name)
		{
			ETalkOptionPreConditionType result;
			if (!ETalkOptionPreConditionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETalkOptionPreConditionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA23 RID: 51747 RVA: 0x001DBD60 File Offset: 0x001D9F60
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

		// Token: 0x0600CA24 RID: 51748 RVA: 0x001DBDC8 File Offset: 0x001D9FC8
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

		// Token: 0x0600CA25 RID: 51749 RVA: 0x001DBDF0 File Offset: 0x001D9FF0
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

		// Token: 0x0600CA26 RID: 51750 RVA: 0x001DBE03 File Offset: 0x001DA003
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
