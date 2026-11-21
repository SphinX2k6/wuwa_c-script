using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CE2 RID: 23778
	public class IPathDrivenActorMoveBase_UnionUnion
	{
		// Token: 0x1700AEB3 RID: 44723
		// (get) Token: 0x06027791 RID: 161681 RVA: 0x00566DD5 File Offset: 0x00564FD5
		// (set) Token: 0x06027792 RID: 161682 RVA: 0x00566DDD File Offset: 0x00564FDD
		public IPathDrivenActorMoveBase_Union Type { get; set; }

		// Token: 0x1700AEB4 RID: 44724
		// (get) Token: 0x06027793 RID: 161683 RVA: 0x00566DE6 File Offset: 0x00564FE6
		// (set) Token: 0x06027794 RID: 161684 RVA: 0x00566DEE File Offset: 0x00564FEE
		public object Value { get; set; }

		// Token: 0x06027795 RID: 161685 RVA: 0x00566DF7 File Offset: 0x00564FF7
		public IPathDrivenActorMoveBase_UnionUnion()
		{
			this.Type = IPathDrivenActorMoveBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06027796 RID: 161686 RVA: 0x00566E0D File Offset: 0x0056500D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06027797 RID: 161687 RVA: 0x00566E1F File Offset: 0x0056501F
		public IPathDrivenActorMoveBaseT AsIPathDrivenActorMoveBase()
		{
			return this.As<IPathDrivenActorMoveBaseT>();
		}

		// Token: 0x06027798 RID: 161688 RVA: 0x00566E27 File Offset: 0x00565027
		public static IPathDrivenActorMoveBase_UnionUnion FromIPathDrivenActorMoveBase(IPathDrivenActorMoveBaseT _ipathdrivenactormovebase)
		{
			return new IPathDrivenActorMoveBase_UnionUnion
			{
				Type = IPathDrivenActorMoveBase_Union.IPathDrivenActorMoveBase,
				Value = _ipathdrivenactormovebase
			};
		}

		// Token: 0x06027799 RID: 161689 RVA: 0x00566E3C File Offset: 0x0056503C
		public IPathDrivenActorSplineMoveT AsIPathDrivenActorSplineMove()
		{
			return this.As<IPathDrivenActorSplineMoveT>();
		}

		// Token: 0x0602779A RID: 161690 RVA: 0x00566E44 File Offset: 0x00565044
		public static IPathDrivenActorMoveBase_UnionUnion FromIPathDrivenActorSplineMove(IPathDrivenActorSplineMoveT _ipathdrivenactorsplinemove)
		{
			return new IPathDrivenActorMoveBase_UnionUnion
			{
				Type = IPathDrivenActorMoveBase_Union.IPathDrivenActorSplineMove,
				Value = _ipathdrivenactorsplinemove
			};
		}

		// Token: 0x0602779B RID: 161691 RVA: 0x00566E5C File Offset: 0x0056505C
		public static int Pack(FlatBufferBuilder builder, IPathDrivenActorMoveBase_UnionUnion _o)
		{
			IPathDrivenActorMoveBase_Union type = _o.Type;
			if (type == IPathDrivenActorMoveBase_Union.IPathDrivenActorMoveBase)
			{
				return IPathDrivenActorMoveBase.Pack(builder, _o.AsIPathDrivenActorMoveBase()).Value;
			}
			if (type != IPathDrivenActorMoveBase_Union.IPathDrivenActorSplineMove)
			{
				return 0;
			}
			return IPathDrivenActorSplineMove.Pack(builder, _o.AsIPathDrivenActorSplineMove()).Value;
		}
	}
}
