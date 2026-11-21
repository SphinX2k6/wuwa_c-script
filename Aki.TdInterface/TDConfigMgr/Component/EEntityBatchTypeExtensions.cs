using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E1 RID: 2529
	public static class EEntityBatchTypeExtensions
	{
		// Token: 0x06003887 RID: 14471 RVA: 0x00092628 File Offset: 0x00090828
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

		// Token: 0x06003888 RID: 14472 RVA: 0x00092650 File Offset: 0x00090850
		public static EEntityBatchType FromString(string name)
		{
			EEntityBatchType result;
			if (!EEntityBatchTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityBatchType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x00092679 File Offset: 0x00090879
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

		// Token: 0x0600388A RID: 14474 RVA: 0x0009269E File Offset: 0x0009089E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"EntityList"
			};
		}

		// Token: 0x0600388B RID: 14475 RVA: 0x000926AE File Offset: 0x000908AE
		public static EEntityBatchType[] GetValues()
		{
			return new EEntityBatchType[1];
		}

		// Token: 0x0600388C RID: 14476 RVA: 0x000926B6 File Offset: 0x000908B6
		public static string[] GetNames()
		{
			return new string[]
			{
				"EntityList"
			};
		}
	}
}
