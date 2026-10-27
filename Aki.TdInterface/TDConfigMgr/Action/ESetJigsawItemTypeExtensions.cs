using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002409 RID: 9225
	public static class ESetJigsawItemTypeExtensions
	{
		// Token: 0x0600C8A7 RID: 51367 RVA: 0x001D5CBC File Offset: 0x001D3EBC
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

		// Token: 0x0600C8A8 RID: 51368 RVA: 0x001D5CE4 File Offset: 0x001D3EE4
		public static ESetJigsawItemType FromString(string name)
		{
			ESetJigsawItemType result;
			if (!ESetJigsawItemTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetJigsawItemType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C8A9 RID: 51369 RVA: 0x001D5D0D File Offset: 0x001D3F0D
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

		// Token: 0x0600C8AA RID: 51370 RVA: 0x001D5D32 File Offset: 0x001D3F32
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"MoveJigsawItem"
			};
		}

		// Token: 0x0600C8AB RID: 51371 RVA: 0x001D5D42 File Offset: 0x001D3F42
		public static ESetJigsawItemType[] GetValues()
		{
			return new ESetJigsawItemType[1];
		}

		// Token: 0x0600C8AC RID: 51372 RVA: 0x001D5D4A File Offset: 0x001D3F4A
		public static string[] GetNames()
		{
			return new string[]
			{
				"MoveJigsawItem"
			};
		}
	}
}
