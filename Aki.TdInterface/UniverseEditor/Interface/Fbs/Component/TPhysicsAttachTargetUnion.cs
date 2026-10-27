using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C85 RID: 23685
	public class TPhysicsAttachTargetUnion
	{
		// Token: 0x1700B236 RID: 45622
		// (get) Token: 0x06028929 RID: 166185 RVA: 0x00593FA2 File Offset: 0x005921A2
		// (set) Token: 0x0602892A RID: 166186 RVA: 0x00593FAA File Offset: 0x005921AA
		public TPhysicsAttachTarget Type { get; set; }

		// Token: 0x1700B237 RID: 45623
		// (get) Token: 0x0602892B RID: 166187 RVA: 0x00593FB3 File Offset: 0x005921B3
		// (set) Token: 0x0602892C RID: 166188 RVA: 0x00593FBB File Offset: 0x005921BB
		public object Value { get; set; }

		// Token: 0x0602892D RID: 166189 RVA: 0x00593FC4 File Offset: 0x005921C4
		public TPhysicsAttachTargetUnion()
		{
			this.Type = TPhysicsAttachTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0602892E RID: 166190 RVA: 0x00593FDA File Offset: 0x005921DA
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602892F RID: 166191 RVA: 0x00593FEC File Offset: 0x005921EC
		public IActorAttachTargetT AsIActorAttachTarget()
		{
			return this.As<IActorAttachTargetT>();
		}

		// Token: 0x06028930 RID: 166192 RVA: 0x00593FF4 File Offset: 0x005921F4
		public static TPhysicsAttachTargetUnion FromIActorAttachTarget(IActorAttachTargetT _iactorattachtarget)
		{
			return new TPhysicsAttachTargetUnion
			{
				Type = TPhysicsAttachTarget.IActorAttachTarget,
				Value = _iactorattachtarget
			};
		}

		// Token: 0x06028931 RID: 166193 RVA: 0x00594009 File Offset: 0x00592209
		public IEntityAttachTargetT AsIEntityAttachTarget()
		{
			return this.As<IEntityAttachTargetT>();
		}

		// Token: 0x06028932 RID: 166194 RVA: 0x00594011 File Offset: 0x00592211
		public static TPhysicsAttachTargetUnion FromIEntityAttachTarget(IEntityAttachTargetT _ientityattachtarget)
		{
			return new TPhysicsAttachTargetUnion
			{
				Type = TPhysicsAttachTarget.IEntityAttachTarget,
				Value = _ientityattachtarget
			};
		}

		// Token: 0x06028933 RID: 166195 RVA: 0x00594026 File Offset: 0x00592226
		public IPointAttachTargetT AsIPointAttachTarget()
		{
			return this.As<IPointAttachTargetT>();
		}

		// Token: 0x06028934 RID: 166196 RVA: 0x0059402E File Offset: 0x0059222E
		public static TPhysicsAttachTargetUnion FromIPointAttachTarget(IPointAttachTargetT _ipointattachtarget)
		{
			return new TPhysicsAttachTargetUnion
			{
				Type = TPhysicsAttachTarget.IPointAttachTarget,
				Value = _ipointattachtarget
			};
		}

		// Token: 0x06028935 RID: 166197 RVA: 0x00594043 File Offset: 0x00592243
		public IDynamicAttachTargetT AsIDynamicAttachTarget()
		{
			return this.As<IDynamicAttachTargetT>();
		}

		// Token: 0x06028936 RID: 166198 RVA: 0x0059404B File Offset: 0x0059224B
		public static TPhysicsAttachTargetUnion FromIDynamicAttachTarget(IDynamicAttachTargetT _idynamicattachtarget)
		{
			return new TPhysicsAttachTargetUnion
			{
				Type = TPhysicsAttachTarget.IDynamicAttachTarget,
				Value = _idynamicattachtarget
			};
		}

		// Token: 0x06028937 RID: 166199 RVA: 0x00594060 File Offset: 0x00592260
		public IPlayerAttachTargetT AsIPlayerAttachTarget()
		{
			return this.As<IPlayerAttachTargetT>();
		}

		// Token: 0x06028938 RID: 166200 RVA: 0x00594068 File Offset: 0x00592268
		public static TPhysicsAttachTargetUnion FromIPlayerAttachTarget(IPlayerAttachTargetT _iplayerattachtarget)
		{
			return new TPhysicsAttachTargetUnion
			{
				Type = TPhysicsAttachTarget.IPlayerAttachTarget,
				Value = _iplayerattachtarget
			};
		}

		// Token: 0x06028939 RID: 166201 RVA: 0x00594080 File Offset: 0x00592280
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
