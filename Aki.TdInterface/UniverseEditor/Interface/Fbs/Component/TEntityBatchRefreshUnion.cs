using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C0D RID: 23565
	public class TEntityBatchRefreshUnion
	{
		// Token: 0x1700B1E6 RID: 45542
		// (get) Token: 0x060286BB RID: 165563 RVA: 0x00590526 File Offset: 0x0058E726
		// (set) Token: 0x060286BC RID: 165564 RVA: 0x0059052E File Offset: 0x0058E72E
		public TEntityBatchRefresh Type { get; set; }

		// Token: 0x1700B1E7 RID: 45543
		// (get) Token: 0x060286BD RID: 165565 RVA: 0x00590537 File Offset: 0x0058E737
		// (set) Token: 0x060286BE RID: 165566 RVA: 0x0059053F File Offset: 0x0058E73F
		public object Value { get; set; }

		// Token: 0x060286BF RID: 165567 RVA: 0x00590548 File Offset: 0x0058E748
		public TEntityBatchRefreshUnion()
		{
			this.Type = TEntityBatchRefresh.NONE;
			this.Value = null;
		}

		// Token: 0x060286C0 RID: 165568 RVA: 0x0059055E File Offset: 0x0058E75E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060286C1 RID: 165569 RVA: 0x00590570 File Offset: 0x0058E770
		public IRandomBatchPoolRefreshT AsIRandomBatchPoolRefresh()
		{
			return this.As<IRandomBatchPoolRefreshT>();
		}

		// Token: 0x060286C2 RID: 165570 RVA: 0x00590578 File Offset: 0x0058E778
		public static TEntityBatchRefreshUnion FromIRandomBatchPoolRefresh(IRandomBatchPoolRefreshT _irandombatchpoolrefresh)
		{
			return new TEntityBatchRefreshUnion
			{
				Type = TEntityBatchRefresh.IRandomBatchPoolRefresh,
				Value = _irandombatchpoolrefresh
			};
		}

		// Token: 0x060286C3 RID: 165571 RVA: 0x0059058D File Offset: 0x0058E78D
		public IRandomBatchRefreshT AsIRandomBatchRefresh()
		{
			return this.As<IRandomBatchRefreshT>();
		}

		// Token: 0x060286C4 RID: 165572 RVA: 0x00590595 File Offset: 0x0058E795
		public static TEntityBatchRefreshUnion FromIRandomBatchRefresh(IRandomBatchRefreshT _irandombatchrefresh)
		{
			return new TEntityBatchRefreshUnion
			{
				Type = TEntityBatchRefresh.IRandomBatchRefresh,
				Value = _irandombatchrefresh
			};
		}

		// Token: 0x060286C5 RID: 165573 RVA: 0x005905AA File Offset: 0x0058E7AA
		public ISequenceBatchRefreshT AsISequenceBatchRefresh()
		{
			return this.As<ISequenceBatchRefreshT>();
		}

		// Token: 0x060286C6 RID: 165574 RVA: 0x005905B2 File Offset: 0x0058E7B2
		public static TEntityBatchRefreshUnion FromISequenceBatchRefresh(ISequenceBatchRefreshT _isequencebatchrefresh)
		{
			return new TEntityBatchRefreshUnion
			{
				Type = TEntityBatchRefresh.ISequenceBatchRefresh,
				Value = _isequencebatchrefresh
			};
		}

		// Token: 0x060286C7 RID: 165575 RVA: 0x005905C8 File Offset: 0x0058E7C8
		public static int Pack(FlatBufferBuilder builder, TEntityBatchRefreshUnion _o)
		{
			switch (_o.Type)
			{
			case TEntityBatchRefresh.IRandomBatchPoolRefresh:
				return IRandomBatchPoolRefresh.Pack(builder, _o.AsIRandomBatchPoolRefresh()).Value;
			case TEntityBatchRefresh.IRandomBatchRefresh:
				return IRandomBatchRefresh.Pack(builder, _o.AsIRandomBatchRefresh()).Value;
			case TEntityBatchRefresh.ISequenceBatchRefresh:
				return ISequenceBatchRefresh.Pack(builder, _o.AsISequenceBatchRefresh()).Value;
			default:
				return 0;
			}
		}
	}
}
