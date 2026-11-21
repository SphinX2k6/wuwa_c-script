using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E99 RID: 16025
	public class IFishState_UnionUnion
	{
		// Token: 0x17006C5E RID: 27742
		// (get) Token: 0x06015A48 RID: 88648 RVA: 0x0031E3C9 File Offset: 0x0031C5C9
		// (set) Token: 0x06015A49 RID: 88649 RVA: 0x0031E3D1 File Offset: 0x0031C5D1
		public IFishState_Union Type { get; set; }

		// Token: 0x17006C5F RID: 27743
		// (get) Token: 0x06015A4A RID: 88650 RVA: 0x0031E3DA File Offset: 0x0031C5DA
		// (set) Token: 0x06015A4B RID: 88651 RVA: 0x0031E3E2 File Offset: 0x0031C5E2
		public object Value { get; set; }

		// Token: 0x06015A4C RID: 88652 RVA: 0x0031E3EB File Offset: 0x0031C5EB
		public IFishState_UnionUnion()
		{
			this.Type = IFishState_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06015A4D RID: 88653 RVA: 0x0031E401 File Offset: 0x0031C601
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06015A4E RID: 88654 RVA: 0x0031E413 File Offset: 0x0031C613
		public IFishStateT AsIFishState()
		{
			return this.As<IFishStateT>();
		}

		// Token: 0x06015A4F RID: 88655 RVA: 0x0031E41B File Offset: 0x0031C61B
		public static IFishState_UnionUnion FromIFishState(IFishStateT _ifishstate)
		{
			return new IFishState_UnionUnion
			{
				Type = IFishState_Union.IFishState,
				Value = _ifishstate
			};
		}

		// Token: 0x06015A50 RID: 88656 RVA: 0x0031E430 File Offset: 0x0031C630
		public IFishIdleStateT AsIFishIdleState()
		{
			return this.As<IFishIdleStateT>();
		}

		// Token: 0x06015A51 RID: 88657 RVA: 0x0031E438 File Offset: 0x0031C638
		public static IFishState_UnionUnion FromIFishIdleState(IFishIdleStateT _ifishidlestate)
		{
			return new IFishState_UnionUnion
			{
				Type = IFishState_Union.IFishIdleState,
				Value = _ifishidlestate
			};
		}

		// Token: 0x06015A52 RID: 88658 RVA: 0x0031E44D File Offset: 0x0031C64D
		public IFishFollowStateT AsIFishFollowState()
		{
			return this.As<IFishFollowStateT>();
		}

		// Token: 0x06015A53 RID: 88659 RVA: 0x0031E455 File Offset: 0x0031C655
		public static IFishState_UnionUnion FromIFishFollowState(IFishFollowStateT _ifishfollowstate)
		{
			return new IFishState_UnionUnion
			{
				Type = IFishState_Union.IFishFollowState,
				Value = _ifishfollowstate
			};
		}

		// Token: 0x06015A54 RID: 88660 RVA: 0x0031E46A File Offset: 0x0031C66A
		public IFishSplinePatrolStateT AsIFishSplinePatrolState()
		{
			return this.As<IFishSplinePatrolStateT>();
		}

		// Token: 0x06015A55 RID: 88661 RVA: 0x0031E472 File Offset: 0x0031C672
		public static IFishState_UnionUnion FromIFishSplinePatrolState(IFishSplinePatrolStateT _ifishsplinepatrolstate)
		{
			return new IFishState_UnionUnion
			{
				Type = IFishState_Union.IFishSplinePatrolState,
				Value = _ifishsplinepatrolstate
			};
		}

		// Token: 0x06015A56 RID: 88662 RVA: 0x0031E487 File Offset: 0x0031C687
		public IFishDestroyStateT AsIFishDestroyState()
		{
			return this.As<IFishDestroyStateT>();
		}

		// Token: 0x06015A57 RID: 88663 RVA: 0x0031E48F File Offset: 0x0031C68F
		public static IFishState_UnionUnion FromIFishDestroyState(IFishDestroyStateT _ifishdestroystate)
		{
			return new IFishState_UnionUnion
			{
				Type = IFishState_Union.IFishDestroyState,
				Value = _ifishdestroystate
			};
		}

		// Token: 0x06015A58 RID: 88664 RVA: 0x0031E4A4 File Offset: 0x0031C6A4
		public static int Pack(FlatBufferBuilder builder, IFishState_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFishState_Union.IFishState:
				return IFishState.Pack(builder, _o.AsIFishState()).Value;
			case IFishState_Union.IFishIdleState:
				return IFishIdleState.Pack(builder, _o.AsIFishIdleState()).Value;
			case IFishState_Union.IFishFollowState:
				return IFishFollowState.Pack(builder, _o.AsIFishFollowState()).Value;
			case IFishState_Union.IFishSplinePatrolState:
				return IFishSplinePatrolState.Pack(builder, _o.AsIFishSplinePatrolState()).Value;
			case IFishState_Union.IFishDestroyState:
				return IFishDestroyState.Pack(builder, _o.AsIFishDestroyState()).Value;
			default:
				return 0;
			}
		}
	}
}
