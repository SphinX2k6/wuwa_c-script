using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F5E RID: 32606
	public class TNewSplineMoveTargetUnion
	{
		// Token: 0x1700F2B7 RID: 62135
		// (get) Token: 0x0603AC7B RID: 240763 RVA: 0x007E6E62 File Offset: 0x007E5062
		// (set) Token: 0x0603AC7C RID: 240764 RVA: 0x007E6E6A File Offset: 0x007E506A
		public TNewSplineMoveTarget Type { get; set; }

		// Token: 0x1700F2B8 RID: 62136
		// (get) Token: 0x0603AC7D RID: 240765 RVA: 0x007E6E73 File Offset: 0x007E5073
		// (set) Token: 0x0603AC7E RID: 240766 RVA: 0x007E6E7B File Offset: 0x007E507B
		public object Value { get; set; }

		// Token: 0x0603AC7F RID: 240767 RVA: 0x007E6E84 File Offset: 0x007E5084
		public TNewSplineMoveTargetUnion()
		{
			this.Type = TNewSplineMoveTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0603AC80 RID: 240768 RVA: 0x007E6E9A File Offset: 0x007E509A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AC81 RID: 240769 RVA: 0x007E6EAC File Offset: 0x007E50AC
		public INpcNewSplineMoveTargetT AsINpcNewSplineMoveTarget()
		{
			return this.As<INpcNewSplineMoveTargetT>();
		}

		// Token: 0x0603AC82 RID: 240770 RVA: 0x007E6EB4 File Offset: 0x007E50B4
		public static TNewSplineMoveTargetUnion FromINpcNewSplineMoveTarget(INpcNewSplineMoveTargetT _inpcnewsplinemovetarget)
		{
			return new TNewSplineMoveTargetUnion
			{
				Type = TNewSplineMoveTarget.INpcNewSplineMoveTarget,
				Value = _inpcnewsplinemovetarget
			};
		}

		// Token: 0x0603AC83 RID: 240771 RVA: 0x007E6EC9 File Offset: 0x007E50C9
		public IPlayerNewSplineMoveTargetT AsIPlayerNewSplineMoveTarget()
		{
			return this.As<IPlayerNewSplineMoveTargetT>();
		}

		// Token: 0x0603AC84 RID: 240772 RVA: 0x007E6ED1 File Offset: 0x007E50D1
		public static TNewSplineMoveTargetUnion FromIPlayerNewSplineMoveTarget(IPlayerNewSplineMoveTargetT _iplayernewsplinemovetarget)
		{
			return new TNewSplineMoveTargetUnion
			{
				Type = TNewSplineMoveTarget.IPlayerNewSplineMoveTarget,
				Value = _iplayernewsplinemovetarget
			};
		}

		// Token: 0x0603AC85 RID: 240773 RVA: 0x007E6EE6 File Offset: 0x007E50E6
		public ISceneItemNewSplineMoveTargetT AsISceneItemNewSplineMoveTarget()
		{
			return this.As<ISceneItemNewSplineMoveTargetT>();
		}

		// Token: 0x0603AC86 RID: 240774 RVA: 0x007E6EEE File Offset: 0x007E50EE
		public static TNewSplineMoveTargetUnion FromISceneItemNewSplineMoveTarget(ISceneItemNewSplineMoveTargetT _isceneitemnewsplinemovetarget)
		{
			return new TNewSplineMoveTargetUnion
			{
				Type = TNewSplineMoveTarget.ISceneItemNewSplineMoveTarget,
				Value = _isceneitemnewsplinemovetarget
			};
		}

		// Token: 0x0603AC87 RID: 240775 RVA: 0x007E6F03 File Offset: 0x007E5103
		public IVehicleNewSplineMoveTargetT AsIVehicleNewSplineMoveTarget()
		{
			return this.As<IVehicleNewSplineMoveTargetT>();
		}

		// Token: 0x0603AC88 RID: 240776 RVA: 0x007E6F0B File Offset: 0x007E510B
		public static TNewSplineMoveTargetUnion FromIVehicleNewSplineMoveTarget(IVehicleNewSplineMoveTargetT _ivehiclenewsplinemovetarget)
		{
			return new TNewSplineMoveTargetUnion
			{
				Type = TNewSplineMoveTarget.IVehicleNewSplineMoveTarget,
				Value = _ivehiclenewsplinemovetarget
			};
		}

		// Token: 0x0603AC89 RID: 240777 RVA: 0x007E6F20 File Offset: 0x007E5120
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
