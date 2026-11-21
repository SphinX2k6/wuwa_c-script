using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200622C RID: 25132
	public class TEntityBatchRefreshUnion
	{
		// Token: 0x1700BB34 RID: 47924
		// (get) Token: 0x0602ACAB RID: 175275 RVA: 0x005D846E File Offset: 0x005D666E
		// (set) Token: 0x0602ACAC RID: 175276 RVA: 0x005D8476 File Offset: 0x005D6676
		public TEntityBatchRefresh Type { get; set; }

		// Token: 0x1700BB35 RID: 47925
		// (get) Token: 0x0602ACAD RID: 175277 RVA: 0x005D847F File Offset: 0x005D667F
		// (set) Token: 0x0602ACAE RID: 175278 RVA: 0x005D8487 File Offset: 0x005D6687
		public object Value { get; set; }

		// Token: 0x0602ACAF RID: 175279 RVA: 0x005D8490 File Offset: 0x005D6690
		public TEntityBatchRefreshUnion()
		{
			this.Type = TEntityBatchRefresh.NONE;
			this.Value = null;
		}

		// Token: 0x0602ACB0 RID: 175280 RVA: 0x005D84A6 File Offset: 0x005D66A6
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602ACB1 RID: 175281 RVA: 0x005D84B8 File Offset: 0x005D66B8
		public IRandomBatchPoolRefreshT AsIRandomBatchPoolRefresh()
		{
			return this.As<IRandomBatchPoolRefreshT>();
		}

		// Token: 0x0602ACB2 RID: 175282 RVA: 0x005D84C0 File Offset: 0x005D66C0
		public static TEntityBatchRefreshUnion FromIRandomBatchPoolRefresh(IRandomBatchPoolRefreshT _irandombatchpoolrefresh)
		{
			return new TEntityBatchRefreshUnion
			{
				Type = TEntityBatchRefresh.IRandomBatchPoolRefresh,
				Value = _irandombatchpoolrefresh
			};
		}

		// Token: 0x0602ACB3 RID: 175283 RVA: 0x005D84D5 File Offset: 0x005D66D5
		public IRandomBatchRefreshT AsIRandomBatchRefresh()
		{
			return this.As<IRandomBatchRefreshT>();
		}

		// Token: 0x0602ACB4 RID: 175284 RVA: 0x005D84DD File Offset: 0x005D66DD
		public static TEntityBatchRefreshUnion FromIRandomBatchRefresh(IRandomBatchRefreshT _irandombatchrefresh)
		{
			return new TEntityBatchRefreshUnion
			{
				Type = TEntityBatchRefresh.IRandomBatchRefresh,
				Value = _irandombatchrefresh
			};
		}

		// Token: 0x0602ACB5 RID: 175285 RVA: 0x005D84F2 File Offset: 0x005D66F2
		public ISequenceBatchRefreshT AsISequenceBatchRefresh()
		{
			return this.As<ISequenceBatchRefreshT>();
		}

		// Token: 0x0602ACB6 RID: 175286 RVA: 0x005D84FA File Offset: 0x005D66FA
		public static TEntityBatchRefreshUnion FromISequenceBatchRefresh(ISequenceBatchRefreshT _isequencebatchrefresh)
		{
			return new TEntityBatchRefreshUnion
			{
				Type = TEntityBatchRefresh.ISequenceBatchRefresh,
				Value = _isequencebatchrefresh
			};
		}

		// Token: 0x0602ACB7 RID: 175287 RVA: 0x005D8510 File Offset: 0x005D6710
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
