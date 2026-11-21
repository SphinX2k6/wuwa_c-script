using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072F0 RID: 29424
	public class INewSplineStopTarget_UnionUnion
	{
		// Token: 0x1700D7B9 RID: 55225
		// (get) Token: 0x060334CF RID: 210127 RVA: 0x006EB619 File Offset: 0x006E9819
		// (set) Token: 0x060334D0 RID: 210128 RVA: 0x006EB621 File Offset: 0x006E9821
		public INewSplineStopTarget_Union Type { get; set; }

		// Token: 0x1700D7BA RID: 55226
		// (get) Token: 0x060334D1 RID: 210129 RVA: 0x006EB62A File Offset: 0x006E982A
		// (set) Token: 0x060334D2 RID: 210130 RVA: 0x006EB632 File Offset: 0x006E9832
		public object Value { get; set; }

		// Token: 0x060334D3 RID: 210131 RVA: 0x006EB63B File Offset: 0x006E983B
		public INewSplineStopTarget_UnionUnion()
		{
			this.Type = INewSplineStopTarget_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060334D4 RID: 210132 RVA: 0x006EB651 File Offset: 0x006E9851
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060334D5 RID: 210133 RVA: 0x006EB663 File Offset: 0x006E9863
		public INewSplineStopTargetT AsINewSplineStopTarget()
		{
			return this.As<INewSplineStopTargetT>();
		}

		// Token: 0x060334D6 RID: 210134 RVA: 0x006EB66B File Offset: 0x006E986B
		public static INewSplineStopTarget_UnionUnion FromINewSplineStopTarget(INewSplineStopTargetT _inewsplinestoptarget)
		{
			return new INewSplineStopTarget_UnionUnion
			{
				Type = INewSplineStopTarget_Union.INewSplineStopTarget,
				Value = _inewsplinestoptarget
			};
		}

		// Token: 0x060334D7 RID: 210135 RVA: 0x006EB680 File Offset: 0x006E9880
		public INpcNewSplineStopTargetT AsINpcNewSplineStopTarget()
		{
			return this.As<INpcNewSplineStopTargetT>();
		}

		// Token: 0x060334D8 RID: 210136 RVA: 0x006EB688 File Offset: 0x006E9888
		public static INewSplineStopTarget_UnionUnion FromINpcNewSplineStopTarget(INpcNewSplineStopTargetT _inpcnewsplinestoptarget)
		{
			return new INewSplineStopTarget_UnionUnion
			{
				Type = INewSplineStopTarget_Union.INpcNewSplineStopTarget,
				Value = _inpcnewsplinestoptarget
			};
		}

		// Token: 0x060334D9 RID: 210137 RVA: 0x006EB69D File Offset: 0x006E989D
		public ISceneNewItemSplineStopTargetT AsISceneNewItemSplineStopTarget()
		{
			return this.As<ISceneNewItemSplineStopTargetT>();
		}

		// Token: 0x060334DA RID: 210138 RVA: 0x006EB6A5 File Offset: 0x006E98A5
		public static INewSplineStopTarget_UnionUnion FromISceneNewItemSplineStopTarget(ISceneNewItemSplineStopTargetT _iscenenewitemsplinestoptarget)
		{
			return new INewSplineStopTarget_UnionUnion
			{
				Type = INewSplineStopTarget_Union.ISceneNewItemSplineStopTarget,
				Value = _iscenenewitemsplinestoptarget
			};
		}

		// Token: 0x060334DB RID: 210139 RVA: 0x006EB6BA File Offset: 0x006E98BA
		public IPlayerNewSplineStopTargetT AsIPlayerNewSplineStopTarget()
		{
			return this.As<IPlayerNewSplineStopTargetT>();
		}

		// Token: 0x060334DC RID: 210140 RVA: 0x006EB6C2 File Offset: 0x006E98C2
		public static INewSplineStopTarget_UnionUnion FromIPlayerNewSplineStopTarget(IPlayerNewSplineStopTargetT _iplayernewsplinestoptarget)
		{
			return new INewSplineStopTarget_UnionUnion
			{
				Type = INewSplineStopTarget_Union.IPlayerNewSplineStopTarget,
				Value = _iplayernewsplinestoptarget
			};
		}

		// Token: 0x060334DD RID: 210141 RVA: 0x006EB6D7 File Offset: 0x006E98D7
		public IVehicleNewSplineStopTargetT AsIVehicleNewSplineStopTarget()
		{
			return this.As<IVehicleNewSplineStopTargetT>();
		}

		// Token: 0x060334DE RID: 210142 RVA: 0x006EB6DF File Offset: 0x006E98DF
		public static INewSplineStopTarget_UnionUnion FromIVehicleNewSplineStopTarget(IVehicleNewSplineStopTargetT _ivehiclenewsplinestoptarget)
		{
			return new INewSplineStopTarget_UnionUnion
			{
				Type = INewSplineStopTarget_Union.IVehicleNewSplineStopTarget,
				Value = _ivehiclenewsplinestoptarget
			};
		}

		// Token: 0x060334DF RID: 210143 RVA: 0x006EB6F4 File Offset: 0x006E98F4
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
