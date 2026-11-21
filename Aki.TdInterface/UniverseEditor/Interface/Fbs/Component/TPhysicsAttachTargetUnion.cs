using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020062B6 RID: 25270
	public class TPhysicsAttachTargetUnion
	{
		// Token: 0x1700BB90 RID: 48016
		// (get) Token: 0x0602AF6F RID: 175983 RVA: 0x005DC6DA File Offset: 0x005DA8DA
		// (set) Token: 0x0602AF70 RID: 175984 RVA: 0x005DC6E2 File Offset: 0x005DA8E2
		public TPhysicsAttachTarget Type { get; set; }

		// Token: 0x1700BB91 RID: 48017
		// (get) Token: 0x0602AF71 RID: 175985 RVA: 0x005DC6EB File Offset: 0x005DA8EB
		// (set) Token: 0x0602AF72 RID: 175986 RVA: 0x005DC6F3 File Offset: 0x005DA8F3
		public object Value { get; set; }

		// Token: 0x0602AF73 RID: 175987 RVA: 0x005DC6FC File Offset: 0x005DA8FC
		public TPhysicsAttachTargetUnion()
		{
			this.Type = TPhysicsAttachTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0602AF74 RID: 175988 RVA: 0x005DC712 File Offset: 0x005DA912
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AF75 RID: 175989 RVA: 0x005DC724 File Offset: 0x005DA924
		public IActorAttachTargetT AsIActorAttachTarget()
		{
			return this.As<IActorAttachTargetT>();
		}

		// Token: 0x0602AF76 RID: 175990 RVA: 0x005DC72C File Offset: 0x005DA92C
		public static TPhysicsAttachTargetUnion FromIActorAttachTarget(IActorAttachTargetT _iactorattachtarget)
		{
			return new TPhysicsAttachTargetUnion
			{
				Type = TPhysicsAttachTarget.IActorAttachTarget,
				Value = _iactorattachtarget
			};
		}

		// Token: 0x0602AF77 RID: 175991 RVA: 0x005DC741 File Offset: 0x005DA941
		public IEntityAttachTargetT AsIEntityAttachTarget()
		{
			return this.As<IEntityAttachTargetT>();
		}

		// Token: 0x0602AF78 RID: 175992 RVA: 0x005DC749 File Offset: 0x005DA949
		public static TPhysicsAttachTargetUnion FromIEntityAttachTarget(IEntityAttachTargetT _ientityattachtarget)
		{
			return new TPhysicsAttachTargetUnion
			{
				Type = TPhysicsAttachTarget.IEntityAttachTarget,
				Value = _ientityattachtarget
			};
		}

		// Token: 0x0602AF79 RID: 175993 RVA: 0x005DC75E File Offset: 0x005DA95E
		public IPointAttachTargetT AsIPointAttachTarget()
		{
			return this.As<IPointAttachTargetT>();
		}

		// Token: 0x0602AF7A RID: 175994 RVA: 0x005DC766 File Offset: 0x005DA966
		public static TPhysicsAttachTargetUnion FromIPointAttachTarget(IPointAttachTargetT _ipointattachtarget)
		{
			return new TPhysicsAttachTargetUnion
			{
				Type = TPhysicsAttachTarget.IPointAttachTarget,
				Value = _ipointattachtarget
			};
		}

		// Token: 0x0602AF7B RID: 175995 RVA: 0x005DC77B File Offset: 0x005DA97B
		public IDynamicAttachTargetT AsIDynamicAttachTarget()
		{
			return this.As<IDynamicAttachTargetT>();
		}

		// Token: 0x0602AF7C RID: 175996 RVA: 0x005DC783 File Offset: 0x005DA983
		public static TPhysicsAttachTargetUnion FromIDynamicAttachTarget(IDynamicAttachTargetT _idynamicattachtarget)
		{
			return new TPhysicsAttachTargetUnion
			{
				Type = TPhysicsAttachTarget.IDynamicAttachTarget,
				Value = _idynamicattachtarget
			};
		}

		// Token: 0x0602AF7D RID: 175997 RVA: 0x005DC798 File Offset: 0x005DA998
		public IPlayerAttachTargetT AsIPlayerAttachTarget()
		{
			return this.As<IPlayerAttachTargetT>();
		}

		// Token: 0x0602AF7E RID: 175998 RVA: 0x005DC7A0 File Offset: 0x005DA9A0
		public static TPhysicsAttachTargetUnion FromIPlayerAttachTarget(IPlayerAttachTargetT _iplayerattachtarget)
		{
			return new TPhysicsAttachTargetUnion
			{
				Type = TPhysicsAttachTarget.IPlayerAttachTarget,
				Value = _iplayerattachtarget
			};
		}

		// Token: 0x0602AF7F RID: 175999 RVA: 0x005DC7B8 File Offset: 0x005DA9B8
		public static int Pack(FlatBufferBuilder builder, TPhysicsAttachTargetUnion _o)
		{
			switch (_o.Type)
			{
			case TPhysicsAttachTarget.IActorAttachTarget:
				return IActorAttachTarget.Pack(builder, _o.AsIActorAttachTarget()).Value;
			case TPhysicsAttachTarget.IEntityAttachTarget:
				return IEntityAttachTarget.Pack(builder, _o.AsIEntityAttachTarget()).Value;
			case TPhysicsAttachTarget.IPointAttachTarget:
				return IPointAttachTarget.Pack(builder, _o.AsIPointAttachTarget()).Value;
			case TPhysicsAttachTarget.IDynamicAttachTarget:
				return IDynamicAttachTarget.Pack(builder, _o.AsIDynamicAttachTarget()).Value;
			case TPhysicsAttachTarget.IPlayerAttachTarget:
				return IPlayerAttachTarget.Pack(builder, _o.AsIPlayerAttachTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
