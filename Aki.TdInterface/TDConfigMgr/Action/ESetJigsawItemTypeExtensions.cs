using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026A8 RID: 9896
	public static class ESetJigsawItemTypeExtensions
	{
		// Token: 0x0600D54E RID: 54606 RVA: 0x001EF8B8 File Offset: 0x001EDAB8
		public static string ToEnumString(this ESetJigsawItemType value)
		{
			string result;
			if (value == ESetJigsawItemType.MoveJigsawItem)
			{
				result = "MoveJigsawItem";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D54F RID: 54607 RVA: 0x001EF8E0 File Offset: 0x001EDAE0
		public static ESetJigsawItemType FromString(string name)
		{
			ESetJigsawItemType result;
			if (!ESetJigsawItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetJigsawItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D550 RID: 54608 RVA: 0x001EF909 File Offset: 0x001EDB09
		public static bool TryFromString(string name, out ESetJigsawItemType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESetJigsawItemType.MoveJigsawItem;
				return false;
			}
			if (name == "MoveJigsawItem")
			{
				value = ESetJigsawItemType.MoveJigsawItem;
				return true;
			}
			value = ESetJigsawItemType.MoveJigsawItem;
			return false;
		}

		// Token: 0x0600D551 RID: 54609 RVA: 0x001EF92E File Offset: 0x001EDB2E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MoveJigsawItem"
			};
		}

		// Token: 0x0600D552 RID: 54610 RVA: 0x001EF93E File Offset: 0x001EDB3E
		public static ESetJigsawItemType[] GetValues()
		{
			return new ESetJigsawItemType[1];
		}

		// Token: 0x0600D553 RID: 54611 RVA: 0x001EF946 File Offset: 0x001EDB46
		public static string[] GetNames()
		{
			return new string[]
			{
				"MoveJigsawItem"
			};
		}
	}
}
