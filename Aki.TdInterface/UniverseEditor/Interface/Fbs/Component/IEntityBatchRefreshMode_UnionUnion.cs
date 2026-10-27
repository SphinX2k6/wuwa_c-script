using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005160 RID: 20832
	public class IEntityBatchRefreshMode_UnionUnion
	{
		// Token: 0x170097F8 RID: 38904
		// (get) Token: 0x06021A2C RID: 137772 RVA: 0x004AB19C File Offset: 0x004A939C
		// (set) Token: 0x06021A2D RID: 137773 RVA: 0x004AB1A4 File Offset: 0x004A93A4
		public IEntityBatchRefreshMode_Union Type { get; set; }

		// Token: 0x170097F9 RID: 38905
		// (get) Token: 0x06021A2E RID: 137774 RVA: 0x004AB1AD File Offset: 0x004A93AD
		// (set) Token: 0x06021A2F RID: 137775 RVA: 0x004AB1B5 File Offset: 0x004A93B5
		public object Value { get; set; }

		// Token: 0x06021A30 RID: 137776 RVA: 0x004AB1BE File Offset: 0x004A93BE
		public IEntityBatchRefreshMode_UnionUnion()
		{
			this.Type = IEntityBatchRefreshMode_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06021A31 RID: 137777 RVA: 0x004AB1D4 File Offset: 0x004A93D4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06021A32 RID: 137778 RVA: 0x004AB1E6 File Offset: 0x004A93E6
		public IEntityBatchRefreshModeT AsIEntityBatchRefreshMode()
		{
			return this.As<IEntityBatchRefreshModeT>();
		}

		// Token: 0x06021A33 RID: 137779 RVA: 0x004AB1EE File Offset: 0x004A93EE
		public static IEntityBatchRefreshMode_UnionUnion FromIEntityBatchRefreshMode(IEntityBatchRefreshModeT _ientitybatchrefreshmode)
		{
			return new IEntityBatchRefreshMode_UnionUnion
			{
				Type = IEntityBatchRefreshMode_Union.IEntityBatchRefreshMode,
				Value = _ientitybatchrefreshmode
			};
		}

		// Token: 0x06021A34 RID: 137780 RVA: 0x004AB203 File Offset: 0x004A9403
		public ISequenceBatchRefreshT AsISequenceBatchRefresh()
		{
			return this.As<ISequenceBatchRefreshT>();
		}

		// Token: 0x06021A35 RID: 137781 RVA: 0x004AB20B File Offset: 0x004A940B
		public static IEntityBatchRefreshMode_UnionUnion FromISequenceBatchRefresh(ISequenceBatchRefreshT _isequencebatchrefresh)
		{
			return new IEntityBatchRefreshMode_UnionUnion
			{
				Type = IEntityBatchRefreshMode_Union.ISequenceBatchRefresh,
				Value = _isequencebatchrefresh
			};
		}

		// Token: 0x06021A36 RID: 137782 RVA: 0x004AB220 File Offset: 0x004A9420
		public IRandomBatchRefreshT AsIRandomBatchRefresh()
		{
			return this.As<IRandomBatchRefreshT>();
		}

		// Token: 0x06021A37 RID: 137783 RVA: 0x004AB228 File Offset: 0x004A9428
		public static IEntityBatchRefreshMode_UnionUnion FromIRandomBatchRefresh(IRandomBatchRefreshT _irandombatchrefresh)
		{
			return new IEntityBatchRefreshMode_UnionUnion
			{
				Type = IEntityBatchRefreshMode_Union.IRandomBatchRefresh,
				Value = _irandombatchrefresh
			};
		}

		// Token: 0x06021A38 RID: 137784 RVA: 0x004AB23D File Offset: 0x004A943D
		public IRandomBatchPoolRefreshT AsIRandomBatchPoolRefresh()
		{
			return this.As<IRandomBatchPoolRefreshT>();
		}

		// Token: 0x06021A39 RID: 137785 RVA: 0x004AB245 File Offset: 0x004A9445
		public static IEntityBatchRefreshMode_UnionUnion FromIRandomBatchPoolRefresh(IRandomBatchPoolRefreshT _irandombatchpoolrefresh)
		{
			return new IEntityBatchRefreshMode_UnionUnion
			{
				Type = IEntityBatchRefreshMode_Union.IRandomBatchPoolRefresh,
				Value = _irandombatchpoolrefresh
			};
		}

		// Token: 0x06021A3A RID: 137786 RVA: 0x004AB25C File Offset: 0x004A945C
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
