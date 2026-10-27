using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001276 RID: 4726
	public static class ERecallConditionTypeExtensions
	{
		// Token: 0x06006ABA RID: 27322 RVA: 0x000FFF8C File Offset: 0x000FE18C
		public static string ToEnumString(this ERecallConditionType value)
		{
			string result;
			switch (value)
			{
			case ERecallConditionType.ByEntityType:
				result = "ByEntityType";
				break;
			case ERecallConditionType.ByTemplate:
				result = "ByTemplate";
				break;
			case ERecallConditionType.ByGroup:
				result = "ByGroup";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006ABB RID: 27323 RVA: 0x000FFFD4 File Offset: 0x000FE1D4
		public static ERecallConditionType FromString(string name)
		{
			ERecallConditionType result;
			if (!ERecallConditionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERecallConditionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006ABC RID: 27324 RVA: 0x00100000 File Offset: 0x000FE200
		public static bool TryFromString(string name, out ERecallConditionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERecallConditionType.ByEntityType;
				return false;
			}
			if (name == "ByEntityType")
			{
				value = ERecallConditionType.ByEntityType;
				return true;
			}
			if (name == "ByTemplate")
			{
				value = ERecallConditionType.ByTemplate;
				return true;
			}
			if (!(name == "ByGroup"))
			{
				value = ERecallConditionType.ByEntityType;
				return false;
			}
			value = ERecallConditionType.ByGroup;
			return true;
		}

		// Token: 0x06006ABD RID: 27325 RVA: 0x00100056 File Offset: 0x000FE256
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ByEntityType",
				"ByTemplate",
				"ByGroup"
			};
		}

		// Token: 0x06006ABE RID: 27326 RVA: 0x00100076 File Offset: 0x000FE276
		public static ERecallConditionType[] GetValues()
		{
			return new ERecallConditionType[]
			{
				ERecallConditionType.ByEntityType,
				ERecallConditionType.ByTemplate,
				ERecallConditionType.ByGroup
			};
		}

		// Token: 0x06006ABF RID: 27327 RVA: 0x00100086 File Offset: 0x000FE286
		public static string[] GetNames()
		{
			return new string[]
			{
				"ByEntityType",
				"ByTemplate",
				"ByGroup"
			};
		}
	}
}
