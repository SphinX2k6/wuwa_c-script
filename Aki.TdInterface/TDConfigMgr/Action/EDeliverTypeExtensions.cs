using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022FD RID: 8957
	public static class EDeliverTypeExtensions
	{
		// Token: 0x0600C3F1 RID: 50161 RVA: 0x001C9D50 File Offset: 0x001C7F50
		public static string ToEnumString(this EDeliverType value)
		{
			string result;
			if (value == EDeliverType.ItemIdCellIndependent)
			{
				result = "ItemIdCellIndependent";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C3F2 RID: 50162 RVA: 0x001C9D78 File Offset: 0x001C7F78
		public static EDeliverType FromString(string name)
		{
			EDeliverType result;
			if (!EDeliverTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDeliverType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C3F3 RID: 50163 RVA: 0x001C9DA1 File Offset: 0x001C7FA1
		public static bool TryFromString(string name, out EDeliverType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDeliverType.ItemIdCellIndependent;
				return false;
			}
			if (name == "ItemIdCellIndependent")
			{
				value = EDeliverType.ItemIdCellIndependent;
				return true;
			}
			value = EDeliverType.ItemIdCellIndependent;
			return false;
		}

		// Token: 0x0600C3F4 RID: 50164 RVA: 0x001C9DC6 File Offset: 0x001C7FC6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ItemIdCellIndependent"
			};
		}

		// Token: 0x0600C3F5 RID: 50165 RVA: 0x001C9DD6 File Offset: 0x001C7FD6
		public static EDeliverType[] GetValues()
		{
			return new EDeliverType[1];
		}

		// Token: 0x0600C3F6 RID: 50166 RVA: 0x001C9DDE File Offset: 0x001C7FDE
		public static string[] GetNames()
		{
			return new string[]
			{
				"ItemIdCellIndependent"
			};
		}
	}
}
