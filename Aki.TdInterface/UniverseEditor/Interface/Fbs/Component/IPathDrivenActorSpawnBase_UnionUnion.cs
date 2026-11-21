using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CE8 RID: 23784
	public class IPathDrivenActorSpawnBase_UnionUnion
	{
		// Token: 0x1700AEB8 RID: 44728
		// (get) Token: 0x060277AF RID: 161711 RVA: 0x00567049 File Offset: 0x00565249
		// (set) Token: 0x060277B0 RID: 161712 RVA: 0x00567051 File Offset: 0x00565251
		public IPathDrivenActorSpawnBase_Union Type { get; set; }

		// Token: 0x1700AEB9 RID: 44729
		// (get) Token: 0x060277B1 RID: 161713 RVA: 0x0056705A File Offset: 0x0056525A
		// (set) Token: 0x060277B2 RID: 161714 RVA: 0x00567062 File Offset: 0x00565262
		public object Value { get; set; }

		// Token: 0x060277B3 RID: 161715 RVA: 0x0056706B File Offset: 0x0056526B
		public IPathDrivenActorSpawnBase_UnionUnion()
		{
			this.Type = IPathDrivenActorSpawnBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060277B4 RID: 161716 RVA: 0x00567081 File Offset: 0x00565281
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060277B5 RID: 161717 RVA: 0x00567093 File Offset: 0x00565293
		public IPathDrivenActorSpawnBaseT AsIPathDrivenActorSpawnBase()
		{
			return this.As<IPathDrivenActorSpawnBaseT>();
		}

		// Token: 0x060277B6 RID: 161718 RVA: 0x0056709B File Offset: 0x0056529B
		public static IPathDrivenActorSpawnBase_UnionUnion FromIPathDrivenActorSpawnBase(IPathDrivenActorSpawnBaseT _ipathdrivenactorspawnbase)
		{
			return new IPathDrivenActorSpawnBase_UnionUnion
			{
				Type = IPathDrivenActorSpawnBase_Union.IPathDrivenActorSpawnBase,
				Value = _ipathdrivenactorspawnbase
			};
		}

		// Token: 0x060277B7 RID: 161719 RVA: 0x005670B0 File Offset: 0x005652B0
		public IIntervalSplineSpawnT AsIIntervalSplineSpawn()
		{
			return this.As<IIntervalSplineSpawnT>();
		}

		// Token: 0x060277B8 RID: 161720 RVA: 0x005670B8 File Offset: 0x005652B8
		public static IPathDrivenActorSpawnBase_UnionUnion FromIIntervalSplineSpawn(IIntervalSplineSpawnT _iintervalsplinespawn)
		{
			return new IPathDrivenActorSpawnBase_UnionUnion
			{
				Type = IPathDrivenActorSpawnBase_Union.IIntervalSplineSpawn,
				Value = _iintervalsplinespawn
			};
		}

		// Token: 0x060277B9 RID: 161721 RVA: 0x005670D0 File Offset: 0x005652D0
		public static int Pack(FlatBufferBuilder builder, IPathDrivenActorSpawnBase_UnionUnion _o)
		{
			IPathDrivenActorSpawnBase_Union type = _o.Type;
			if (type == IPathDrivenActorSpawnBase_Union.IPathDrivenActorSpawnBase)
			{
				return IPathDrivenActorSpawnBase.Pack(builder, _o.AsIPathDrivenActorSpawnBase()).Value;
			}
			if (type != IPathDrivenActorSpawnBase_Union.IIntervalSplineSpawn)
			{
				return 0;
			}
			return IIntervalSplineSpawn.Pack(builder, _o.AsIIntervalSplineSpawn()).Value;
		}
	}
}
