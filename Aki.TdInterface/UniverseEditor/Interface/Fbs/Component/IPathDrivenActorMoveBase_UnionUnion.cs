using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F3 RID: 22259
	public class IPathDrivenActorMoveBase_UnionUnion
	{
		// Token: 0x1700A5B0 RID: 42416
		// (get) Token: 0x0602532A RID: 152362 RVA: 0x00522389 File Offset: 0x00520589
		// (set) Token: 0x0602532B RID: 152363 RVA: 0x00522391 File Offset: 0x00520591
		public IPathDrivenActorMoveBase_Union Type { get; set; }

		// Token: 0x1700A5B1 RID: 42417
		// (get) Token: 0x0602532C RID: 152364 RVA: 0x0052239A File Offset: 0x0052059A
		// (set) Token: 0x0602532D RID: 152365 RVA: 0x005223A2 File Offset: 0x005205A2
		public object Value { get; set; }

		// Token: 0x0602532E RID: 152366 RVA: 0x005223AB File Offset: 0x005205AB
		public IPathDrivenActorMoveBase_UnionUnion()
		{
			this.Type = IPathDrivenActorMoveBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602532F RID: 152367 RVA: 0x005223C1 File Offset: 0x005205C1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025330 RID: 152368 RVA: 0x005223D3 File Offset: 0x005205D3
		public IPathDrivenActorMoveBaseT AsIPathDrivenActorMoveBase()
		{
			return this.As<IPathDrivenActorMoveBaseT>();
		}

		// Token: 0x06025331 RID: 152369 RVA: 0x005223DB File Offset: 0x005205DB
		public static IPathDrivenActorMoveBase_UnionUnion FromIPathDrivenActorMoveBase(IPathDrivenActorMoveBaseT _ipathdrivenactormovebase)
		{
			return new IPathDrivenActorMoveBase_UnionUnion
			{
				Type = IPathDrivenActorMoveBase_Union.IPathDrivenActorMoveBase,
				Value = _ipathdrivenactormovebase
			};
		}

		// Token: 0x06025332 RID: 152370 RVA: 0x005223F0 File Offset: 0x005205F0
		public IPathDrivenActorSplineMoveT AsIPathDrivenActorSplineMove()
		{
			return this.As<IPathDrivenActorSplineMoveT>();
		}

		// Token: 0x06025333 RID: 152371 RVA: 0x005223F8 File Offset: 0x005205F8
		public static IPathDrivenActorMoveBase_UnionUnion FromIPathDrivenActorSplineMove(IPathDrivenActorSplineMoveT _ipathdrivenactorsplinemove)
		{
			return new IPathDrivenActorMoveBase_UnionUnion
			{
				Type = IPathDrivenActorMoveBase_Union.IPathDrivenActorSplineMove,
				Value = _ipathdrivenactorsplinemove
			};
		}

		// Token: 0x06025334 RID: 152372 RVA: 0x00522410 File Offset: 0x00520610
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
