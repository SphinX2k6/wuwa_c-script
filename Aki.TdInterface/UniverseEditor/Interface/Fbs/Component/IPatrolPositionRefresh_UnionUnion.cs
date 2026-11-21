using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005D12 RID: 23826
	public class IPatrolPositionRefresh_UnionUnion
	{
		// Token: 0x1700AF03 RID: 44803
		// (get) Token: 0x06027918 RID: 162072 RVA: 0x00569AA4 File Offset: 0x00567CA4
		// (set) Token: 0x06027919 RID: 162073 RVA: 0x00569AAC File Offset: 0x00567CAC
		public IPatrolPositionRefresh_Union Type { get; set; }

		// Token: 0x1700AF04 RID: 44804
		// (get) Token: 0x0602791A RID: 162074 RVA: 0x00569AB5 File Offset: 0x00567CB5
		// (set) Token: 0x0602791B RID: 162075 RVA: 0x00569ABD File Offset: 0x00567CBD
		public object Value { get; set; }

		// Token: 0x0602791C RID: 162076 RVA: 0x00569AC6 File Offset: 0x00567CC6
		public IPatrolPositionRefresh_UnionUnion()
		{
			this.Type = IPatrolPositionRefresh_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602791D RID: 162077 RVA: 0x00569ADC File Offset: 0x00567CDC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602791E RID: 162078 RVA: 0x00569AEE File Offset: 0x00567CEE
		public IPatrolPositionRefreshT AsIPatrolPositionRefresh()
		{
			return this.As<IPatrolPositionRefreshT>();
		}

		// Token: 0x0602791F RID: 162079 RVA: 0x00569AF6 File Offset: 0x00567CF6
		public static IPatrolPositionRefresh_UnionUnion FromIPatrolPositionRefresh(IPatrolPositionRefreshT _ipatrolpositionrefresh)
		{
			return new IPatrolPositionRefresh_UnionUnion
			{
				Type = IPatrolPositionRefresh_Union.IPatrolPositionRefresh,
				Value = _ipatrolpositionrefresh
			};
		}

		// Token: 0x06027920 RID: 162080 RVA: 0x00569B0B File Offset: 0x00567D0B
		public IPatrolPositionRefreshAtNearestSplinePointToPlayerT AsIPatrolPositionRefreshAtNearestSplinePointToPlayer()
		{
			return this.As<IPatrolPositionRefreshAtNearestSplinePointToPlayerT>();
		}

		// Token: 0x06027921 RID: 162081 RVA: 0x00569B13 File Offset: 0x00567D13
		public static IPatrolPositionRefresh_UnionUnion FromIPatrolPositionRefreshAtNearestSplinePointToPlayer(IPatrolPositionRefreshAtNearestSplinePointToPlayerT _ipatrolpositionrefreshatnearestsplinepointtoplayer)
		{
			return new IPatrolPositionRefresh_UnionUnion
			{
				Type = IPatrolPositionRefresh_Union.IPatrolPositionRefreshAtNearestSplinePointToPlayer,
				Value = _ipatrolpositionrefreshatnearestsplinepointtoplayer
			};
		}

		// Token: 0x06027922 RID: 162082 RVA: 0x00569B28 File Offset: 0x00567D28
		public static int Pack(FlatBufferBuilder builder, IPatrolPositionRefresh_UnionUnion _o)
		{
			IPatrolPositionRefresh_Union type = _o.Type;
			if (type == IPatrolPositionRefresh_Union.IPatrolPositionRefresh)
			{
				return IPatrolPositionRefresh.Pack(builder, _o.AsIPatrolPositionRefresh()).Value;
			}
			if (type != IPatrolPositionRefresh_Union.IPatrolPositionRefreshAtNearestSplinePointToPlayer)
			{
				return 0;
			}
			return IPatrolPositionRefreshAtNearestSplinePointToPlayer.Pack(builder, _o.AsIPatrolPositionRefreshAtNearestSplinePointToPlayer()).Value;
		}
	}
}
