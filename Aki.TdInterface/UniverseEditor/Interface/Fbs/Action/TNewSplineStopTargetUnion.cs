using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F61 RID: 32609
	public class TNewSplineStopTargetUnion
	{
		// Token: 0x1700F2B9 RID: 62137
		// (get) Token: 0x0603AC8B RID: 240779 RVA: 0x007E6FEE File Offset: 0x007E51EE
		// (set) Token: 0x0603AC8C RID: 240780 RVA: 0x007E6FF6 File Offset: 0x007E51F6
		public TNewSplineStopTarget Type { get; set; }

		// Token: 0x1700F2BA RID: 62138
		// (get) Token: 0x0603AC8D RID: 240781 RVA: 0x007E6FFF File Offset: 0x007E51FF
		// (set) Token: 0x0603AC8E RID: 240782 RVA: 0x007E7007 File Offset: 0x007E5207
		public object Value { get; set; }

		// Token: 0x0603AC8F RID: 240783 RVA: 0x007E7010 File Offset: 0x007E5210
		public TNewSplineStopTargetUnion()
		{
			this.Type = TNewSplineStopTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0603AC90 RID: 240784 RVA: 0x007E7026 File Offset: 0x007E5226
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AC91 RID: 240785 RVA: 0x007E7038 File Offset: 0x007E5238
		public INpcNewSplineStopTargetT AsINpcNewSplineStopTarget()
		{
			return this.As<INpcNewSplineStopTargetT>();
		}

		// Token: 0x0603AC92 RID: 240786 RVA: 0x007E7040 File Offset: 0x007E5240
		public static TNewSplineStopTargetUnion FromINpcNewSplineStopTarget(INpcNewSplineStopTargetT _inpcnewsplinestoptarget)
		{
			return new TNewSplineStopTargetUnion
			{
				Type = TNewSplineStopTarget.INpcNewSplineStopTarget,
				Value = _inpcnewsplinestoptarget
			};
		}

		// Token: 0x0603AC93 RID: 240787 RVA: 0x007E7055 File Offset: 0x007E5255
		public IPlayerNewSplineStopTargetT AsIPlayerNewSplineStopTarget()
		{
			return this.As<IPlayerNewSplineStopTargetT>();
		}

		// Token: 0x0603AC94 RID: 240788 RVA: 0x007E705D File Offset: 0x007E525D
		public static TNewSplineStopTargetUnion FromIPlayerNewSplineStopTarget(IPlayerNewSplineStopTargetT _iplayernewsplinestoptarget)
		{
			return new TNewSplineStopTargetUnion
			{
				Type = TNewSplineStopTarget.IPlayerNewSplineStopTarget,
				Value = _iplayernewsplinestoptarget
			};
		}

		// Token: 0x0603AC95 RID: 240789 RVA: 0x007E7072 File Offset: 0x007E5272
		public ISceneNewItemSplineStopTargetT AsISceneNewItemSplineStopTarget()
		{
			return this.As<ISceneNewItemSplineStopTargetT>();
		}

		// Token: 0x0603AC96 RID: 240790 RVA: 0x007E707A File Offset: 0x007E527A
		public static TNewSplineStopTargetUnion FromISceneNewItemSplineStopTarget(ISceneNewItemSplineStopTargetT _iscenenewitemsplinestoptarget)
		{
			return new TNewSplineStopTargetUnion
			{
				Type = TNewSplineStopTarget.ISceneNewItemSplineStopTarget,
				Value = _iscenenewitemsplinestoptarget
			};
		}

		// Token: 0x0603AC97 RID: 240791 RVA: 0x007E708F File Offset: 0x007E528F
		public IVehicleNewSplineStopTargetT AsIVehicleNewSplineStopTarget()
		{
			return this.As<IVehicleNewSplineStopTargetT>();
		}

		// Token: 0x0603AC98 RID: 240792 RVA: 0x007E7097 File Offset: 0x007E5297
		public static TNewSplineStopTargetUnion FromIVehicleNewSplineStopTarget(IVehicleNewSplineStopTargetT _ivehiclenewsplinestoptarget)
		{
			return new TNewSplineStopTargetUnion
			{
				Type = TNewSplineStopTarget.IVehicleNewSplineStopTarget,
				Value = _ivehiclenewsplinestoptarget
			};
		}

		// Token: 0x0603AC99 RID: 240793 RVA: 0x007E70AC File Offset: 0x007E52AC
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
