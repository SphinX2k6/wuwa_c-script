using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001388 RID: 5000
	public static class EHandInItemTypeExtensions
	{
		// Token: 0x0600703E RID: 28734 RVA: 0x0010B7B8 File Offset: 0x001099B8
		public static string ToEnumString(this EHandInItemType value)
		{
			string result;
			if (value != EHandInItemType.ItemIds)
			{
				if (value != EHandInItemType.ItemType)
				{
					result = value.ToString();
				}
				else
				{
					result = "ItemType";
				}
			}
			else
			{
				result = "ItemIds";
			}
			return result;
		}

		// Token: 0x0600703F RID: 28735 RVA: 0x0010B7F0 File Offset: 0x001099F0
		public static EHandInItemType FromString(string name)
		{
			EHandInItemType result;
			if (!EHandInItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHandInItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007040 RID: 28736 RVA: 0x0010B819 File Offset: 0x00109A19
		public static bool TryFromString(string name, out EHandInItemType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EHandInItemType.ItemIds;
				return false;
			}
			if (name == "ItemIds")
			{
				value = EHandInItemType.ItemIds;
				return true;
			}
			if (!(name == "ItemType"))
			{
				value = EHandInItemType.ItemIds;
				return false;
			}
			value = EHandInItemType.ItemType;
			return true;
		}

		// Token: 0x06007041 RID: 28737 RVA: 0x0010B852 File Offset: 0x00109A52
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ItemIds",
				"ItemType"
			};
		}

		// Token: 0x06007042 RID: 28738 RVA: 0x0010B86A File Offset: 0x00109A6A
		public static EHandInItemType[] GetValues()
		{
			return new EHandInItemType[]
			{
				EHandInItemType.ItemIds,
				EHandInItemType.ItemType
			};
		}

		// Token: 0x06007043 RID: 28739 RVA: 0x0010B876 File Offset: 0x00109A76
		public static string[] GetNames()
		{
			return new string[]
			{
				"ItemIds",
				"ItemType"
			};
		}
	}
}
