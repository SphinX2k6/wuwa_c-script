using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001248 RID: 4680
	public static class EHandInItemTypeExtensions
	{
		// Token: 0x060069EB RID: 27115 RVA: 0x000FDB8C File Offset: 0x000FBD8C
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

		// Token: 0x060069EC RID: 27116 RVA: 0x000FDBC4 File Offset: 0x000FBDC4
		public static EHandInItemType FromString(string name)
		{
			EHandInItemType result;
			if (!EHandInItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EHandInItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x000FDBED File Offset: 0x000FBDED
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

		// Token: 0x060069EE RID: 27118 RVA: 0x000FDC26 File Offset: 0x000FBE26
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ItemIds",
				"ItemType"
			};
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x000FDC3E File Offset: 0x000FBE3E
		public static EHandInItemType[] GetValues()
		{
			return new EHandInItemType[]
			{
				EHandInItemType.ItemIds,
				EHandInItemType.ItemType
			};
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x000FDC4A File Offset: 0x000FBE4A
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
