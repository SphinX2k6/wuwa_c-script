using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056C5 RID: 22213
	public class IEntityBatchRefreshMode_UnionUnion
	{
		// Token: 0x17009FE5 RID: 40933
		// (get) Token: 0x06023980 RID: 145792 RVA: 0x004E5128 File Offset: 0x004E3328
		// (set) Token: 0x06023981 RID: 145793 RVA: 0x004E5130 File Offset: 0x004E3330
		public IEntityBatchRefreshMode_Union Type { get; set; }

		// Token: 0x17009FE6 RID: 40934
		// (get) Token: 0x06023982 RID: 145794 RVA: 0x004E5139 File Offset: 0x004E3339
		// (set) Token: 0x06023983 RID: 145795 RVA: 0x004E5141 File Offset: 0x004E3341
		public object Value { get; set; }

		// Token: 0x06023984 RID: 145796 RVA: 0x004E514A File Offset: 0x004E334A
		public IEntityBatchRefreshMode_UnionUnion()
		{
			this.Type = IEntityBatchRefreshMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06023985 RID: 145797 RVA: 0x004E5160 File Offset: 0x004E3360
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06023986 RID: 145798 RVA: 0x004E5172 File Offset: 0x004E3372
		public IEntityBatchRefreshModeT AsIEntityBatchRefreshMode()
		{
			return this.As<IEntityBatchRefreshModeT>();
		}

		// Token: 0x06023987 RID: 145799 RVA: 0x004E517A File Offset: 0x004E337A
		public static IEntityBatchRefreshMode_UnionUnion FromIEntityBatchRefreshMode(IEntityBatchRefreshModeT _ientitybatchrefreshmode)
		{
			return new IEntityBatchRefreshMode_UnionUnion
			{
				Type = IEntityBatchRefreshMode_Union.IEntityBatchRefreshMode,
				Value = _ientitybatchrefreshmode
			};
		}

		// Token: 0x06023988 RID: 145800 RVA: 0x004E518F File Offset: 0x004E338F
		public ISequenceBatchRefreshT AsISequenceBatchRefresh()
		{
			return this.As<ISequenceBatchRefreshT>();
		}

		// Token: 0x06023989 RID: 145801 RVA: 0x004E5197 File Offset: 0x004E3397
		public static IEntityBatchRefreshMode_UnionUnion FromISequenceBatchRefresh(ISequenceBatchRefreshT _isequencebatchrefresh)
		{
			return new IEntityBatchRefreshMode_UnionUnion
			{
				Type = IEntityBatchRefreshMode_Union.ISequenceBatchRefresh,
				Value = _isequencebatchrefresh
			};
		}

		// Token: 0x0602398A RID: 145802 RVA: 0x004E51AC File Offset: 0x004E33AC
		public IRandomBatchRefreshT AsIRandomBatchRefresh()
		{
			return this.As<IRandomBatchRefreshT>();
		}

		// Token: 0x0602398B RID: 145803 RVA: 0x004E51B4 File Offset: 0x004E33B4
		public static IEntityBatchRefreshMode_UnionUnion FromIRandomBatchRefresh(IRandomBatchRefreshT _irandombatchrefresh)
		{
			return new IEntityBatchRefreshMode_UnionUnion
			{
				Type = IEntityBatchRefreshMode_Union.IRandomBatchRefresh,
				Value = _irandombatchrefresh
			};
		}

		// Token: 0x0602398C RID: 145804 RVA: 0x004E51C9 File Offset: 0x004E33C9
		public IRandomBatchPoolRefreshT AsIRandomBatchPoolRefresh()
		{
			return this.As<IRandomBatchPoolRefreshT>();
		}

		// Token: 0x0602398D RID: 145805 RVA: 0x004E51D1 File Offset: 0x004E33D1
		public static IEntityBatchRefreshMode_UnionUnion FromIRandomBatchPoolRefresh(IRandomBatchPoolRefreshT _irandombatchpoolrefresh)
		{
			return new IEntityBatchRefreshMode_UnionUnion
			{
				Type = IEntityBatchRefreshMode_Union.IRandomBatchPoolRefresh,
				Value = _irandombatchpoolrefresh
			};
		}

		// Token: 0x0602398E RID: 145806 RVA: 0x004E51E8 File Offset: 0x004E33E8
		public static int Pack(FlatBufferBuilder builder, IEntityBatchRefreshMode_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IEntityBatchRefreshMode_Union.IEntityBatchRefreshMode:
				return IEntityBatchRefreshMode.Pack(builder, _o.AsIEntityBatchRefreshMode()).Value;
			case IEntityBatchRefreshMode_Union.ISequenceBatchRefresh:
				return ISequenceBatchRefresh.Pack(builder, _o.AsISequenceBatchRefresh()).Value;
			case IEntityBatchRefreshMode_Union.IRandomBatchRefresh:
				return IRandomBatchRefresh.Pack(builder, _o.AsIRandomBatchRefresh()).Value;
			case IEntityBatchRefreshMode_Union.IRandomBatchPoolRefresh:
				return IRandomBatchPoolRefresh.Pack(builder, _o.AsIRandomBatchPoolRefresh()).Value;
			default:
				return 0;
			}
		}
	}
}
