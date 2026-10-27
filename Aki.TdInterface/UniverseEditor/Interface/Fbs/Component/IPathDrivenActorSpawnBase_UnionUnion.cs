using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F9 RID: 22265
	public class IPathDrivenActorSpawnBase_UnionUnion
	{
		// Token: 0x1700A5B5 RID: 42421
		// (get) Token: 0x06025348 RID: 152392 RVA: 0x005225FD File Offset: 0x005207FD
		// (set) Token: 0x06025349 RID: 152393 RVA: 0x00522605 File Offset: 0x00520805
		public IPathDrivenActorSpawnBase_Union Type { get; set; }

		// Token: 0x1700A5B6 RID: 42422
		// (get) Token: 0x0602534A RID: 152394 RVA: 0x0052260E File Offset: 0x0052080E
		// (set) Token: 0x0602534B RID: 152395 RVA: 0x00522616 File Offset: 0x00520816
		public object Value { get; set; }

		// Token: 0x0602534C RID: 152396 RVA: 0x0052261F File Offset: 0x0052081F
		public IPathDrivenActorSpawnBase_UnionUnion()
		{
			this.Type = IPathDrivenActorSpawnBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602534D RID: 152397 RVA: 0x00522635 File Offset: 0x00520835
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602534E RID: 152398 RVA: 0x00522647 File Offset: 0x00520847
		public IPathDrivenActorSpawnBaseT AsIPathDrivenActorSpawnBase()
		{
			return this.As<IPathDrivenActorSpawnBaseT>();
		}

		// Token: 0x0602534F RID: 152399 RVA: 0x0052264F File Offset: 0x0052084F
		public static IPathDrivenActorSpawnBase_UnionUnion FromIPathDrivenActorSpawnBase(IPathDrivenActorSpawnBaseT _ipathdrivenactorspawnbase)
		{
			return new IPathDrivenActorSpawnBase_UnionUnion
			{
				Type = IPathDrivenActorSpawnBase_Union.IPathDrivenActorSpawnBase,
				Value = _ipathdrivenactorspawnbase
			};
		}

		// Token: 0x06025350 RID: 152400 RVA: 0x00522664 File Offset: 0x00520864
		public IIntervalSplineSpawnT AsIIntervalSplineSpawn()
		{
			return this.As<IIntervalSplineSpawnT>();
		}

		// Token: 0x06025351 RID: 152401 RVA: 0x0052266C File Offset: 0x0052086C
		public static IPathDrivenActorSpawnBase_UnionUnion FromIIntervalSplineSpawn(IIntervalSplineSpawnT _iintervalsplinespawn)
		{
			return new IPathDrivenActorSpawnBase_UnionUnion
			{
				Type = IPathDrivenActorSpawnBase_Union.IIntervalSplineSpawn,
				Value = _iintervalsplinespawn
			};
		}

		// Token: 0x06025352 RID: 152402 RVA: 0x00522684 File Offset: 0x00520884
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
