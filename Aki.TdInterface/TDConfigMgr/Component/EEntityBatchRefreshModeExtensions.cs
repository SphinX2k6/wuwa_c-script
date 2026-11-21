using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009DF RID: 2527
	public static class EEntityBatchRefreshModeExtensions
	{
		// Token: 0x0600387E RID: 14462 RVA: 0x000924D0 File Offset: 0x000906D0
		public static string ToEnumString(this EEntityBatchRefreshMode value)
		{
			string result;
			switch (value)
			{
			case EEntityBatchRefreshMode.SequenceBatch:
				result = "SequenceBatch";
				break;
			case EEntityBatchRefreshMode.RandomBatch:
				result = "RandomBatch";
				break;
			case EEntityBatchRefreshMode.RandomBatchPool:
				result = "RandomBatchPool";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600387F RID: 14463 RVA: 0x00092518 File Offset: 0x00090718
		public static EEntityBatchRefreshMode FromString(string name)
		{
			EEntityBatchRefreshMode result;
			if (!EEntityBatchRefreshModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityBatchRefreshMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003880 RID: 14464 RVA: 0x00092544 File Offset: 0x00090744
		public static bool TryFromString(string name, out EEntityBatchRefreshMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEntityBatchRefreshMode.SequenceBatch;
				return false;
			}
			if (name == "SequenceBatch")
			{
				value = EEntityBatchRefreshMode.SequenceBatch;
				return true;
			}
			if (name == "RandomBatch")
			{
				value = EEntityBatchRefreshMode.RandomBatch;
				return true;
			}
			if (!(name == "RandomBatchPool"))
			{
				value = EEntityBatchRefreshMode.SequenceBatch;
				return false;
			}
			value = EEntityBatchRefreshMode.RandomBatchPool;
			return true;
		}

		// Token: 0x06003881 RID: 14465 RVA: 0x0009259A File Offset: 0x0009079A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SequenceBatch",
				"RandomBatch",
				"RandomBatchPool"
			};
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x000925BA File Offset: 0x000907BA
		public static EEntityBatchRefreshMode[] GetValues()
		{
			return new EEntityBatchRefreshMode[]
			{
				EEntityBatchRefreshMode.SequenceBatch,
				EEntityBatchRefreshMode.RandomBatch,
				EEntityBatchRefreshMode.RandomBatchPool
			};
		}

		// Token: 0x06003883 RID: 14467 RVA: 0x000925CA File Offset: 0x000907CA
		public static string[] GetNames()
		{
			return new string[]
			{
				"SequenceBatch",
				"RandomBatch",
				"RandomBatchPool"
			};
		}
	}
}
