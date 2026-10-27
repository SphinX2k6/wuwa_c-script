using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000934 RID: 2356
	public static class EEntityBatchTypeExtensions
	{
		// Token: 0x0600351B RID: 13595 RVA: 0x0008AAA8 File Offset: 0x00088CA8
		public static string ToEnumString(this EEntityBatchType value)
		{
			string result;
			if (value == EEntityBatchType.EntityList)
			{
				result = "EntityList";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x0008AAD0 File Offset: 0x00088CD0
		public static EEntityBatchType FromString(string name)
		{
			EEntityBatchType result;
			if (!EEntityBatchTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityBatchType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x0008AAF9 File Offset: 0x00088CF9
		public static bool TryFromString(string name, out EEntityBatchType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEntityBatchType.EntityList;
				return false;
			}
			if (name == "EntityList")
			{
				value = EEntityBatchType.EntityList;
				return true;
			}
			value = EEntityBatchType.EntityList;
			return false;
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x0008AB1E File Offset: 0x00088D1E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EntityList"
			};
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x0008AB2E File Offset: 0x00088D2E
		public static EEntityBatchType[] GetValues()
		{
			return new EEntityBatchType[1];
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x0008AB36 File Offset: 0x00088D36
		public static string[] GetNames()
		{
			return new string[]
			{
				"EntityList"
			};
		}
	}
}
