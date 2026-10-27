using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002385 RID: 9093
	public static class EModifyActorMediaTypeExtensions
	{
		// Token: 0x0600C655 RID: 50773 RVA: 0x001D0DB0 File Offset: 0x001CEFB0
		public static string ToEnumString(this EModifyActorMediaType value)
		{
			string result;
			if (value == EModifyActorMediaType.ChangeMediaPlayDA)
			{
				result = "ChangeMediaPlayDA";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C656 RID: 50774 RVA: 0x001D0DD8 File Offset: 0x001CEFD8
		public static EModifyActorMediaType FromString(string name)
		{
			EModifyActorMediaType result;
			if (!EModifyActorMediaTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EModifyActorMediaType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C657 RID: 50775 RVA: 0x001D0E01 File Offset: 0x001CF001
		public static bool TryFromString(string name, out EModifyActorMediaType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EModifyActorMediaType.ChangeMediaPlayDA;
				return false;
			}
			if (name == "ChangeMediaPlayDA")
			{
				value = EModifyActorMediaType.ChangeMediaPlayDA;
				return true;
			}
			value = EModifyActorMediaType.ChangeMediaPlayDA;
			return false;
		}

		// Token: 0x0600C658 RID: 50776 RVA: 0x001D0E26 File Offset: 0x001CF026
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChangeMediaPlayDA"
			};
		}

		// Token: 0x0600C659 RID: 50777 RVA: 0x001D0E36 File Offset: 0x001CF036
		public static EModifyActorMediaType[] GetValues()
		{
			return new EModifyActorMediaType[1];
		}

		// Token: 0x0600C65A RID: 50778 RVA: 0x001D0E3E File Offset: 0x001CF03E
		public static string[] GetNames()
		{
			return new string[]
			{
				"ChangeMediaPlayDA"
			};
		}
	}
}
