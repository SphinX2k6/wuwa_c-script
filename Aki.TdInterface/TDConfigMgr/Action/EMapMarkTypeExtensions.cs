using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200237F RID: 9087
	public static class EMapMarkTypeExtensions
	{
		// Token: 0x0600C63A RID: 50746 RVA: 0x001D09A4 File Offset: 0x001CEBA4
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

		// Token: 0x0600C63B RID: 50747 RVA: 0x001D09DC File Offset: 0x001CEBDC
		public static EMapMarkType FromString(string name)
		{
			EMapMarkType result;
			if (!EMapMarkTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMapMarkType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C63C RID: 50748 RVA: 0x001D0A05 File Offset: 0x001CEC05
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

		// Token: 0x0600C63D RID: 50749 RVA: 0x001D0A3E File Offset: 0x001CEC3E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Custom",
				"Quest"
			};
		}

		// Token: 0x0600C63E RID: 50750 RVA: 0x001D0A56 File Offset: 0x001CEC56
		public static EMapMarkType[] GetValues()
		{
			return new EMapMarkType[]
			{
				EMapMarkType.Custom,
				EMapMarkType.Quest
			};
		}

		// Token: 0x0600C63F RID: 50751 RVA: 0x001D0A62 File Offset: 0x001CEC62
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
