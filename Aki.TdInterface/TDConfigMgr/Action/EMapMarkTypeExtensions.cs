using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002608 RID: 9736
	public static class EMapMarkTypeExtensions
	{
		// Token: 0x0600D27E RID: 53886 RVA: 0x001E9978 File Offset: 0x001E7B78
		public static string ToEnumString(this EMapMarkType value)
		{
			string result;
			if (value != EMapMarkType.Custom)
			{
				if (value != EMapMarkType.Quest)
				{
					result = value.ToString();
				}
				else
				{
					result = "Quest";
				}
			}
			else
			{
				result = "Custom";
			}
			return result;
		}

		// Token: 0x0600D27F RID: 53887 RVA: 0x001E99B0 File Offset: 0x001E7BB0
		public static EMapMarkType FromString(string name)
		{
			EMapMarkType result;
			if (!EMapMarkTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMapMarkType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D280 RID: 53888 RVA: 0x001E99D9 File Offset: 0x001E7BD9
		public static bool TryFromString(string name, out EMapMarkType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMapMarkType.Custom;
				return false;
			}
			if (name == "Custom")
			{
				value = EMapMarkType.Custom;
				return true;
			}
			if (!(name == "Quest"))
			{
				value = EMapMarkType.Custom;
				return false;
			}
			value = EMapMarkType.Quest;
			return true;
		}

		// Token: 0x0600D281 RID: 53889 RVA: 0x001E9A12 File Offset: 0x001E7C12
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Custom",
				"Quest"
			};
		}

		// Token: 0x0600D282 RID: 53890 RVA: 0x001E9A2A File Offset: 0x001E7C2A
		public static EMapMarkType[] GetValues()
		{
			return new EMapMarkType[]
			{
				EMapMarkType.Custom,
				EMapMarkType.Quest
			};
		}

		// Token: 0x0600D283 RID: 53891 RVA: 0x001E9A36 File Offset: 0x001E7C36
		public static string[] GetNames()
		{
			return new string[]
			{
				"Custom",
				"Quest"
			};
		}
	}
}
