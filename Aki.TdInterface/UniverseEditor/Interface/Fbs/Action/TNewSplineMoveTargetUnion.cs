using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007735 RID: 30517
	public class TNewSplineMoveTargetUnion
	{
		// Token: 0x1700E667 RID: 58983
		// (get) Token: 0x06037740 RID: 227136 RVA: 0x00781ED2 File Offset: 0x007800D2
		// (set) Token: 0x06037741 RID: 227137 RVA: 0x00781EDA File Offset: 0x007800DA
		public TNewSplineMoveTarget Type { get; set; }

		// Token: 0x1700E668 RID: 58984
		// (get) Token: 0x06037742 RID: 227138 RVA: 0x00781EE3 File Offset: 0x007800E3
		// (set) Token: 0x06037743 RID: 227139 RVA: 0x00781EEB File Offset: 0x007800EB
		public object Value { get; set; }

		// Token: 0x06037744 RID: 227140 RVA: 0x00781EF4 File Offset: 0x007800F4
		public TNewSplineMoveTargetUnion()
		{
			this.Type = TNewSplineMoveTarget.NONE;
			this.Value = null;
		}

		// Token: 0x06037745 RID: 227141 RVA: 0x00781F0A File Offset: 0x0078010A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037746 RID: 227142 RVA: 0x00781F1C File Offset: 0x0078011C
		public INpcNewSplineMoveTargetT AsINpcNewSplineMoveTarget()
		{
			return this.As<INpcNewSplineMoveTargetT>();
		}

		// Token: 0x06037747 RID: 227143 RVA: 0x00781F24 File Offset: 0x00780124
		public static TNewSplineMoveTargetUnion FromINpcNewSplineMoveTarget(INpcNewSplineMoveTargetT _inpcnewsplinemovetarget)
		{
			return new TNewSplineMoveTargetUnion
			{
				Type = TNewSplineMoveTarget.INpcNewSplineMoveTarget,
				Value = _inpcnewsplinemovetarget
			};
		}

		// Token: 0x06037748 RID: 227144 RVA: 0x00781F39 File Offset: 0x00780139
		public IPlayerNewSplineMoveTargetT AsIPlayerNewSplineMoveTarget()
		{
			return this.As<IPlayerNewSplineMoveTargetT>();
		}

		// Token: 0x06037749 RID: 227145 RVA: 0x00781F41 File Offset: 0x00780141
		public static TNewSplineMoveTargetUnion FromIPlayerNewSplineMoveTarget(IPlayerNewSplineMoveTargetT _iplayernewsplinemovetarget)
		{
			return new TNewSplineMoveTargetUnion
			{
				Type = TNewSplineMoveTarget.IPlayerNewSplineMoveTarget,
				Value = _iplayernewsplinemovetarget
			};
		}

		// Token: 0x0603774A RID: 227146 RVA: 0x00781F56 File Offset: 0x00780156
		public ISceneItemNewSplineMoveTargetT AsISceneItemNewSplineMoveTarget()
		{
			return this.As<ISceneItemNewSplineMoveTargetT>();
		}

		// Token: 0x0603774B RID: 227147 RVA: 0x00781F5E File Offset: 0x0078015E
		public static TNewSplineMoveTargetUnion FromISceneItemNewSplineMoveTarget(ISceneItemNewSplineMoveTargetT _isceneitemnewsplinemovetarget)
		{
			return new TNewSplineMoveTargetUnion
			{
				Type = TNewSplineMoveTarget.ISceneItemNewSplineMoveTarget,
				Value = _isceneitemnewsplinemovetarget
			};
		}

		// Token: 0x0603774C RID: 227148 RVA: 0x00781F73 File Offset: 0x00780173
		public IVehicleNewSplineMoveTargetT AsIVehicleNewSplineMoveTarget()
		{
			return this.As<IVehicleNewSplineMoveTargetT>();
		}

		// Token: 0x0603774D RID: 227149 RVA: 0x00781F7B File Offset: 0x0078017B
		public static TNewSplineMoveTargetUnion FromIVehicleNewSplineMoveTarget(IVehicleNewSplineMoveTargetT _ivehiclenewsplinemovetarget)
		{
			return new TNewSplineMoveTargetUnion
			{
				Type = TNewSplineMoveTarget.IVehicleNewSplineMoveTarget,
				Value = _ivehiclenewsplinemovetarget
			};
		}

		// Token: 0x0603774E RID: 227150 RVA: 0x00781F90 File Offset: 0x00780190
		public static int Pack(FlatBufferBuilder builder, TNewSplineMoveTargetUnion _o)
		{
			switch (_o.Type)
			{
			case TNewSplineMoveTarget.INpcNewSplineMoveTarget:
				return INpcNewSplineMoveTarget.Pack(builder, _o.AsINpcNewSplineMoveTarget()).Value;
			case TNewSplineMoveTarget.IPlayerNewSplineMoveTarget:
				return IPlayerNewSplineMoveTarget.Pack(builder, _o.AsIPlayerNewSplineMoveTarget()).Value;
			case TNewSplineMoveTarget.ISceneItemNewSplineMoveTarget:
				return ISceneItemNewSplineMoveTarget.Pack(builder, _o.AsISceneItemNewSplineMoveTarget()).Value;
			case TNewSplineMoveTarget.IVehicleNewSplineMoveTarget:
				return IVehicleNewSplineMoveTarget.Pack(builder, _o.AsIVehicleNewSplineMoveTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
