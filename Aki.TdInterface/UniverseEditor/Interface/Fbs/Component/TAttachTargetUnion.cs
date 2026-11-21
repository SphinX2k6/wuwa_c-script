using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006202 RID: 25090
	public class TAttachTargetUnion
	{
		// Token: 0x1700BB0F RID: 47887
		// (get) Token: 0x0602AAEF RID: 174831 RVA: 0x005D1E18 File Offset: 0x005D0018
		// (set) Token: 0x0602AAF0 RID: 174832 RVA: 0x005D1E20 File Offset: 0x005D0020
		public TAttachTarget Type { get; set; }

		// Token: 0x1700BB10 RID: 47888
		// (get) Token: 0x0602AAF1 RID: 174833 RVA: 0x005D1E29 File Offset: 0x005D0029
		// (set) Token: 0x0602AAF2 RID: 174834 RVA: 0x005D1E31 File Offset: 0x005D0031
		public object Value { get; set; }

		// Token: 0x0602AAF3 RID: 174835 RVA: 0x005D1E3A File Offset: 0x005D003A
		public TAttachTargetUnion()
		{
			this.Type = TAttachTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0602AAF4 RID: 174836 RVA: 0x005D1E50 File Offset: 0x005D0050
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AAF5 RID: 174837 RVA: 0x005D1E62 File Offset: 0x005D0062
		public IActorAttachTargetT AsIActorAttachTarget()
		{
			return this.As<IActorAttachTargetT>();
		}

		// Token: 0x0602AAF6 RID: 174838 RVA: 0x005D1E6A File Offset: 0x005D006A
		public static TAttachTargetUnion FromIActorAttachTarget(IActorAttachTargetT _iactorattachtarget)
		{
			return new TAttachTargetUnion
			{
				Type = TAttachTarget.IActorAttachTarget,
				Value = _iactorattachtarget
			};
		}

		// Token: 0x0602AAF7 RID: 174839 RVA: 0x005D1E7F File Offset: 0x005D007F
		public IDynamicAttachTargetT AsIDynamicAttachTarget()
		{
			return this.As<IDynamicAttachTargetT>();
		}

		// Token: 0x0602AAF8 RID: 174840 RVA: 0x005D1E87 File Offset: 0x005D0087
		public static TAttachTargetUnion FromIDynamicAttachTarget(IDynamicAttachTargetT _idynamicattachtarget)
		{
			return new TAttachTargetUnion
			{
				Type = TAttachTarget.IDynamicAttachTarget,
				Value = _idynamicattachtarget
			};
		}

		// Token: 0x0602AAF9 RID: 174841 RVA: 0x005D1E9C File Offset: 0x005D009C
		public IEntityAttachTargetT AsIEntityAttachTarget()
		{
			return this.As<IEntityAttachTargetT>();
		}

		// Token: 0x0602AAFA RID: 174842 RVA: 0x005D1EA4 File Offset: 0x005D00A4
		public static TAttachTargetUnion FromIEntityAttachTarget(IEntityAttachTargetT _ientityattachtarget)
		{
			return new TAttachTargetUnion
			{
				Type = TAttachTarget.IEntityAttachTarget,
				Value = _ientityattachtarget
			};
		}

		// Token: 0x0602AAFB RID: 174843 RVA: 0x005D1EB9 File Offset: 0x005D00B9
		public IPlayerAttachTargetT AsIPlayerAttachTarget()
		{
			return this.As<IPlayerAttachTargetT>();
		}

		// Token: 0x0602AAFC RID: 174844 RVA: 0x005D1EC1 File Offset: 0x005D00C1
		public static TAttachTargetUnion FromIPlayerAttachTarget(IPlayerAttachTargetT _iplayerattachtarget)
		{
			return new TAttachTargetUnion
			{
				Type = TAttachTarget.IPlayerAttachTarget,
				Value = _iplayerattachtarget
			};
		}

		// Token: 0x0602AAFD RID: 174845 RVA: 0x005D1ED6 File Offset: 0x005D00D6
		public IPointAttachTargetT AsIPointAttachTarget()
		{
			return this.As<IPointAttachTargetT>();
		}

		// Token: 0x0602AAFE RID: 174846 RVA: 0x005D1EDE File Offset: 0x005D00DE
		public static TAttachTargetUnion FromIPointAttachTarget(IPointAttachTargetT _ipointattachtarget)
		{
			return new TAttachTargetUnion
			{
				Type = TAttachTarget.IPointAttachTarget,
				Value = _ipointattachtarget
			};
		}

		// Token: 0x0602AAFF RID: 174847 RVA: 0x005D1EF4 File Offset: 0x005D00F4
		public static int Pack(FlatBufferBuilder builder, TAttachTargetUnion _o)
		{
			switch (_o.Type)
			{
			case TAttachTarget.IActorAttachTarget:
				return IActorAttachTarget.Pack(builder, _o.AsIActorAttachTarget()).Value;
			case TAttachTarget.IDynamicAttachTarget:
				return IDynamicAttachTarget.Pack(builder, _o.AsIDynamicAttachTarget()).Value;
			case TAttachTarget.IEntityAttachTarget:
				return IEntityAttachTarget.Pack(builder, _o.AsIEntityAttachTarget()).Value;
			case TAttachTarget.IPlayerAttachTarget:
				return IPlayerAttachTarget.Pack(builder, _o.AsIPlayerAttachTarget()).Value;
			case TAttachTarget.IPointAttachTarget:
				return IPointAttachTarget.Pack(builder, _o.AsIPointAttachTarget()).Value;
			default:
				return 0;
			}
		}
	}
}
