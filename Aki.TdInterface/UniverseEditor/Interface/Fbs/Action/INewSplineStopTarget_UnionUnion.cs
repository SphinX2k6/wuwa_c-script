using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BA4 RID: 27556
	public class INewSplineStopTarget_UnionUnion
	{
		// Token: 0x1700CCCD RID: 52429
		// (get) Token: 0x06030655 RID: 198229 RVA: 0x00692C79 File Offset: 0x00690E79
		// (set) Token: 0x06030656 RID: 198230 RVA: 0x00692C81 File Offset: 0x00690E81
		public INewSplineStopTarget_Union Type { get; set; }

		// Token: 0x1700CCCE RID: 52430
		// (get) Token: 0x06030657 RID: 198231 RVA: 0x00692C8A File Offset: 0x00690E8A
		// (set) Token: 0x06030658 RID: 198232 RVA: 0x00692C92 File Offset: 0x00690E92
		public object Value { get; set; }

		// Token: 0x06030659 RID: 198233 RVA: 0x00692C9B File Offset: 0x00690E9B
		public INewSplineStopTarget_UnionUnion()
		{
			this.Type = INewSplineStopTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603065A RID: 198234 RVA: 0x00692CB1 File Offset: 0x00690EB1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603065B RID: 198235 RVA: 0x00692CC3 File Offset: 0x00690EC3
		public INewSplineStopTargetT AsINewSplineStopTarget()
		{
			return this.As<INewSplineStopTargetT>();
		}

		// Token: 0x0603065C RID: 198236 RVA: 0x00692CCB File Offset: 0x00690ECB
		public static INewSplineStopTarget_UnionUnion FromINewSplineStopTarget(INewSplineStopTargetT _inewsplinestoptarget)
		{
			return new INewSplineStopTarget_UnionUnion
			{
				Type = INewSplineStopTarget_Union.INewSplineStopTarget,
				Value = _inewsplinestoptarget
			};
		}

		// Token: 0x0603065D RID: 198237 RVA: 0x00692CE0 File Offset: 0x00690EE0
		public INpcNewSplineStopTargetT AsINpcNewSplineStopTarget()
		{
			return this.As<INpcNewSplineStopTargetT>();
		}

		// Token: 0x0603065E RID: 198238 RVA: 0x00692CE8 File Offset: 0x00690EE8
		public static INewSplineStopTarget_UnionUnion FromINpcNewSplineStopTarget(INpcNewSplineStopTargetT _inpcnewsplinestoptarget)
		{
			return new INewSplineStopTarget_UnionUnion
			{
				Type = INewSplineStopTarget_Union.INpcNewSplineStopTarget,
				Value = _inpcnewsplinestoptarget
			};
		}

		// Token: 0x0603065F RID: 198239 RVA: 0x00692CFD File Offset: 0x00690EFD
		public ISceneNewItemSplineStopTargetT AsISceneNewItemSplineStopTarget()
		{
			return this.As<ISceneNewItemSplineStopTargetT>();
		}

		// Token: 0x06030660 RID: 198240 RVA: 0x00692D05 File Offset: 0x00690F05
		public static INewSplineStopTarget_UnionUnion FromISceneNewItemSplineStopTarget(ISceneNewItemSplineStopTargetT _iscenenewitemsplinestoptarget)
		{
			return new INewSplineStopTarget_UnionUnion
			{
				Type = INewSplineStopTarget_Union.ISceneNewItemSplineStopTarget,
				Value = _iscenenewitemsplinestoptarget
			};
		}

		// Token: 0x06030661 RID: 198241 RVA: 0x00692D1A File Offset: 0x00690F1A
		public IPlayerNewSplineStopTargetT AsIPlayerNewSplineStopTarget()
		{
			return this.As<IPlayerNewSplineStopTargetT>();
		}

		// Token: 0x06030662 RID: 198242 RVA: 0x00692D22 File Offset: 0x00690F22
		public static INewSplineStopTarget_UnionUnion FromIPlayerNewSplineStopTarget(IPlayerNewSplineStopTargetT _iplayernewsplinestoptarget)
		{
			return new INewSplineStopTarget_UnionUnion
			{
				Type = INewSplineStopTarget_Union.IPlayerNewSplineStopTarget,
				Value = _iplayernewsplinestoptarget
			};
		}

		// Token: 0x06030663 RID: 198243 RVA: 0x00692D37 File Offset: 0x00690F37
		public IVehicleNewSplineStopTargetT AsIVehicleNewSplineStopTarget()
		{
			return this.As<IVehicleNewSplineStopTargetT>();
		}

		// Token: 0x06030664 RID: 198244 RVA: 0x00692D3F File Offset: 0x00690F3F
		public static INewSplineStopTarget_UnionUnion FromIVehicleNewSplineStopTarget(IVehicleNewSplineStopTargetT _ivehiclenewsplinestoptarget)
		{
			return new INewSplineStopTarget_UnionUnion
			{
				Type = INewSplineStopTarget_Union.IVehicleNewSplineStopTarget,
				Value = _ivehiclenewsplinestoptarget
			};
		}

		// Token: 0x06030665 RID: 198245 RVA: 0x00692D54 File Offset: 0x00690F54
		public static int Pack(FlatBufferBuilder builder, INewSplineStopTarget_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case INewSplineStopTarget_Union.INewSplineStopTarget:
				return INewSplineStopTarget.Pack(builder, _o.AsINewSplineStopTarget()).Value;
			case INewSplineStopTarget_Union.INpcNewSplineStopTarget:
				return INpcNewSplineStopTarget.Pack(builder, _o.AsINpcNewSplineStopTarget()).Value;
			case INewSplineStopTarget_Union.ISceneNewItemSplineStopTarget:
				return ISceneNewItemSplineStopTarget.Pack(builder, _o.AsISceneNewItemSplineStopTarget()).Value;
			case INewSplineStopTarget_Union.IPlayerNewSplineStopTarget:
				return IPlayerNewSplineStopTarget.Pack(builder, _o.AsIPlayerNewSplineStopTarget()).Value;
			case INewSplineStopTarget_Union.IVehicleNewSplineStopTarget:
				return IVehicleNewSplineStopTarget.Pack(builder, _o.AsIVehicleNewSplineStopTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
