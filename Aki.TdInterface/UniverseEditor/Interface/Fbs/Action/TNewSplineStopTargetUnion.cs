using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007738 RID: 30520
	public class TNewSplineStopTargetUnion
	{
		// Token: 0x1700E669 RID: 58985
		// (get) Token: 0x06037750 RID: 227152 RVA: 0x0078205E File Offset: 0x0078025E
		// (set) Token: 0x06037751 RID: 227153 RVA: 0x00782066 File Offset: 0x00780266
		public TNewSplineStopTarget Type { get; set; }

		// Token: 0x1700E66A RID: 58986
		// (get) Token: 0x06037752 RID: 227154 RVA: 0x0078206F File Offset: 0x0078026F
		// (set) Token: 0x06037753 RID: 227155 RVA: 0x00782077 File Offset: 0x00780277
		public object Value { get; set; }

		// Token: 0x06037754 RID: 227156 RVA: 0x00782080 File Offset: 0x00780280
		public TNewSplineStopTargetUnion()
		{
			this.Type = TNewSplineStopTarget.NONE;
			this.Value = null;
		}

		// Token: 0x06037755 RID: 227157 RVA: 0x00782096 File Offset: 0x00780296
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037756 RID: 227158 RVA: 0x007820A8 File Offset: 0x007802A8
		public INpcNewSplineStopTargetT AsINpcNewSplineStopTarget()
		{
			return this.As<INpcNewSplineStopTargetT>();
		}

		// Token: 0x06037757 RID: 227159 RVA: 0x007820B0 File Offset: 0x007802B0
		public static TNewSplineStopTargetUnion FromINpcNewSplineStopTarget(INpcNewSplineStopTargetT _inpcnewsplinestoptarget)
		{
			return new TNewSplineStopTargetUnion
			{
				Type = TNewSplineStopTarget.INpcNewSplineStopTarget,
				Value = _inpcnewsplinestoptarget
			};
		}

		// Token: 0x06037758 RID: 227160 RVA: 0x007820C5 File Offset: 0x007802C5
		public IPlayerNewSplineStopTargetT AsIPlayerNewSplineStopTarget()
		{
			return this.As<IPlayerNewSplineStopTargetT>();
		}

		// Token: 0x06037759 RID: 227161 RVA: 0x007820CD File Offset: 0x007802CD
		public static TNewSplineStopTargetUnion FromIPlayerNewSplineStopTarget(IPlayerNewSplineStopTargetT _iplayernewsplinestoptarget)
		{
			return new TNewSplineStopTargetUnion
			{
				Type = TNewSplineStopTarget.IPlayerNewSplineStopTarget,
				Value = _iplayernewsplinestoptarget
			};
		}

		// Token: 0x0603775A RID: 227162 RVA: 0x007820E2 File Offset: 0x007802E2
		public ISceneNewItemSplineStopTargetT AsISceneNewItemSplineStopTarget()
		{
			return this.As<ISceneNewItemSplineStopTargetT>();
		}

		// Token: 0x0603775B RID: 227163 RVA: 0x007820EA File Offset: 0x007802EA
		public static TNewSplineStopTargetUnion FromISceneNewItemSplineStopTarget(ISceneNewItemSplineStopTargetT _iscenenewitemsplinestoptarget)
		{
			return new TNewSplineStopTargetUnion
			{
				Type = TNewSplineStopTarget.ISceneNewItemSplineStopTarget,
				Value = _iscenenewitemsplinestoptarget
			};
		}

		// Token: 0x0603775C RID: 227164 RVA: 0x007820FF File Offset: 0x007802FF
		public IVehicleNewSplineStopTargetT AsIVehicleNewSplineStopTarget()
		{
			return this.As<IVehicleNewSplineStopTargetT>();
		}

		// Token: 0x0603775D RID: 227165 RVA: 0x00782107 File Offset: 0x00780307
		public static TNewSplineStopTargetUnion FromIVehicleNewSplineStopTarget(IVehicleNewSplineStopTargetT _ivehiclenewsplinestoptarget)
		{
			return new TNewSplineStopTargetUnion
			{
				Type = TNewSplineStopTarget.IVehicleNewSplineStopTarget,
				Value = _ivehiclenewsplinestoptarget
			};
		}

		// Token: 0x0603775E RID: 227166 RVA: 0x0078211C File Offset: 0x0078031C
		public static int Pack(FlatBufferBuilder builder, TNewSplineStopTargetUnion _o)
		{
			switch (_o.Type)
			{
			case TNewSplineStopTarget.INpcNewSplineStopTarget:
				return INpcNewSplineStopTarget.Pack(builder, _o.AsINpcNewSplineStopTarget()).Value;
			case TNewSplineStopTarget.IPlayerNewSplineStopTarget:
				return IPlayerNewSplineStopTarget.Pack(builder, _o.AsIPlayerNewSplineStopTarget()).Value;
			case TNewSplineStopTarget.ISceneNewItemSplineStopTarget:
				return ISceneNewItemSplineStopTarget.Pack(builder, _o.AsISceneNewItemSplineStopTarget()).Value;
			case TNewSplineStopTarget.IVehicleNewSplineStopTarget:
				return IVehicleNewSplineStopTarget.Pack(builder, _o.AsIVehicleNewSplineStopTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
