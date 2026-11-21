using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F56 RID: 16214
	public class TFishStateUnion
	{
		// Token: 0x17006DBC RID: 28092
		// (get) Token: 0x060160DB RID: 90331 RVA: 0x0032A8D6 File Offset: 0x00328AD6
		// (set) Token: 0x060160DC RID: 90332 RVA: 0x0032A8DE File Offset: 0x00328ADE
		public TFishState Type { get; set; }

		// Token: 0x17006DBD RID: 28093
		// (get) Token: 0x060160DD RID: 90333 RVA: 0x0032A8E7 File Offset: 0x00328AE7
		// (set) Token: 0x060160DE RID: 90334 RVA: 0x0032A8EF File Offset: 0x00328AEF
		public object Value { get; set; }

		// Token: 0x060160DF RID: 90335 RVA: 0x0032A8F8 File Offset: 0x00328AF8
		public TFishStateUnion()
		{
			this.Type = TFishState.NONE;
			this.Value = null;
		}

		// Token: 0x060160E0 RID: 90336 RVA: 0x0032A90E File Offset: 0x00328B0E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060160E1 RID: 90337 RVA: 0x0032A920 File Offset: 0x00328B20
		public IFishDestroyStateT AsIFishDestroyState()
		{
			return this.As<IFishDestroyStateT>();
		}

		// Token: 0x060160E2 RID: 90338 RVA: 0x0032A928 File Offset: 0x00328B28
		public static TFishStateUnion FromIFishDestroyState(IFishDestroyStateT _ifishdestroystate)
		{
			return new TFishStateUnion
			{
				Type = TFishState.IFishDestroyState,
				Value = _ifishdestroystate
			};
		}

		// Token: 0x060160E3 RID: 90339 RVA: 0x0032A93D File Offset: 0x00328B3D
		public IFishFollowStateT AsIFishFollowState()
		{
			return this.As<IFishFollowStateT>();
		}

		// Token: 0x060160E4 RID: 90340 RVA: 0x0032A945 File Offset: 0x00328B45
		public static TFishStateUnion FromIFishFollowState(IFishFollowStateT _ifishfollowstate)
		{
			return new TFishStateUnion
			{
				Type = TFishState.IFishFollowState,
				Value = _ifishfollowstate
			};
		}

		// Token: 0x060160E5 RID: 90341 RVA: 0x0032A95A File Offset: 0x00328B5A
		public IFishIdleStateT AsIFishIdleState()
		{
			return this.As<IFishIdleStateT>();
		}

		// Token: 0x060160E6 RID: 90342 RVA: 0x0032A962 File Offset: 0x00328B62
		public static TFishStateUnion FromIFishIdleState(IFishIdleStateT _ifishidlestate)
		{
			return new TFishStateUnion
			{
				Type = TFishState.IFishIdleState,
				Value = _ifishidlestate
			};
		}

		// Token: 0x060160E7 RID: 90343 RVA: 0x0032A977 File Offset: 0x00328B77
		public IFishSplinePatrolStateT AsIFishSplinePatrolState()
		{
			return this.As<IFishSplinePatrolStateT>();
		}

		// Token: 0x060160E8 RID: 90344 RVA: 0x0032A97F File Offset: 0x00328B7F
		public static TFishStateUnion FromIFishSplinePatrolState(IFishSplinePatrolStateT _ifishsplinepatrolstate)
		{
			return new TFishStateUnion
			{
				Type = TFishState.IFishSplinePatrolState,
				Value = _ifishsplinepatrolstate
			};
		}

		// Token: 0x060160E9 RID: 90345 RVA: 0x0032A994 File Offset: 0x00328B94
		public static int Pack(FlatBufferBuilder builder, TFishStateUnion _o)
		{
			switch (_o.Type)
			{
			case TFishState.IFishDestroyState:
				return IFishDestroyState.Pack(builder, _o.AsIFishDestroyState()).Value;
			case TFishState.IFishFollowState:
				return IFishFollowState.Pack(builder, _o.AsIFishFollowState()).Value;
			case TFishState.IFishIdleState:
				return IFishIdleState.Pack(builder, _o.AsIFishIdleState()).Value;
			case TFishState.IFishSplinePatrolState:
				return IFishSplinePatrolState.Pack(builder, _o.AsIFishSplinePatrolState()).Value;
			default:
				return 0;
			}
		}
	}
}
