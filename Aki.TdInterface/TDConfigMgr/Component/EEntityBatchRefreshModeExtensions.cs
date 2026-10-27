using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000932 RID: 2354
	public static class EEntityBatchRefreshModeExtensions
	{
		// Token: 0x06003512 RID: 13586 RVA: 0x0008A950 File Offset: 0x00088B50
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

		// Token: 0x06003513 RID: 13587 RVA: 0x0008A998 File Offset: 0x00088B98
		public static EEntityBatchRefreshMode FromString(string name)
		{
			EEntityBatchRefreshMode result;
			if (!EEntityBatchRefreshModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEntityBatchRefreshMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x0008A9C4 File Offset: 0x00088BC4
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

		// Token: 0x06003515 RID: 13589 RVA: 0x0008AA1A File Offset: 0x00088C1A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SequenceBatch",
				"RandomBatch",
				"RandomBatchPool"
			};
		}

		// Token: 0x06003516 RID: 13590 RVA: 0x0008AA3A File Offset: 0x00088C3A
		public static EEntityBatchRefreshMode[] GetValues()
		{
			return new EEntityBatchRefreshMode[]
			{
				EEntityBatchRefreshMode.SequenceBatch,
				EEntityBatchRefreshMode.RandomBatch,
				EEntityBatchRefreshMode.RandomBatchPool
			};
		}

		// Token: 0x06003517 RID: 13591 RVA: 0x0008AA4A File Offset: 0x00088C4A
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
