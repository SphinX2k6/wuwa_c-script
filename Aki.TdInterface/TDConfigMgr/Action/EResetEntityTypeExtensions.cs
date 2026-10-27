using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023EB RID: 9195
	public static class EResetEntityTypeExtensions
	{
		// Token: 0x0600C820 RID: 51232 RVA: 0x001D4C30 File Offset: 0x001D2E30
		public static string ToEnumString(this EResetEntityType value)
		{
			string result;
			if (value != EResetEntityType.TeleControl)
			{
				if (value != EResetEntityType.JigsawItem)
				{
					result = value.ToString();
				}
				else
				{
					result = "JigsawItem";
				}
			}
			else
			{
				result = "TeleControl";
			}
			return result;
		}

		// Token: 0x0600C821 RID: 51233 RVA: 0x001D4C68 File Offset: 0x001D2E68
		public static EResetEntityType FromString(string name)
		{
			EResetEntityType result;
			if (!EResetEntityTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EResetEntityType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C822 RID: 51234 RVA: 0x001D4C91 File Offset: 0x001D2E91
		public static bool TryFromString(string name, out EResetEntityType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EResetEntityType.TeleControl;
				return false;
			}
			if (name == "TeleControl")
			{
				value = EResetEntityType.TeleControl;
				return true;
			}
			if (!(name == "JigsawItem"))
			{
				value = EResetEntityType.TeleControl;
				return false;
			}
			value = EResetEntityType.JigsawItem;
			return true;
		}

		// Token: 0x0600C823 RID: 51235 RVA: 0x001D4CCA File Offset: 0x001D2ECA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"TeleControl",
				"JigsawItem"
			};
		}

		// Token: 0x0600C824 RID: 51236 RVA: 0x001D4CE2 File Offset: 0x001D2EE2
		public static EResetEntityType[] GetValues()
		{
			return new EResetEntityType[]
			{
				EResetEntityType.TeleControl,
				EResetEntityType.JigsawItem
			};
		}

		// Token: 0x0600C825 RID: 51237 RVA: 0x001D4CEE File Offset: 0x001D2EEE
		public static string[] GetNames()
		{
			return new string[]
			{
				"TeleControl",
				"JigsawItem"
			};
		}
	}
}
