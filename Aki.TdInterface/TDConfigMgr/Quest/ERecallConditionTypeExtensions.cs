using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013B6 RID: 5046
	public static class ERecallConditionTypeExtensions
	{
		// Token: 0x0600710D RID: 28941 RVA: 0x0010DBB8 File Offset: 0x0010BDB8
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

		// Token: 0x0600710E RID: 28942 RVA: 0x0010DC00 File Offset: 0x0010BE00
		public static ERecallConditionType FromString(string name)
		{
			ERecallConditionType result;
			if (!ERecallConditionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERecallConditionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600710F RID: 28943 RVA: 0x0010DC2C File Offset: 0x0010BE2C
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

		// Token: 0x06007110 RID: 28944 RVA: 0x0010DC82 File Offset: 0x0010BE82
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ByEntityType",
				"ByTemplate",
				"ByGroup"
			};
		}

		// Token: 0x06007111 RID: 28945 RVA: 0x0010DCA2 File Offset: 0x0010BEA2
		public static ERecallConditionType[] GetValues()
		{
			return new ERecallConditionType[]
			{
				ERecallConditionType.ByEntityType,
				ERecallConditionType.ByTemplate,
				ERecallConditionType.ByGroup
			};
		}

		// Token: 0x06007112 RID: 28946 RVA: 0x0010DCB2 File Offset: 0x0010BEB2
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
