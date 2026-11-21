using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E71 RID: 24177
	public struct IResurrectionComponent : IFlatbufferObject
	{
		// Token: 0x1700B25E RID: 45662
		// (get) Token: 0x0602871C RID: 165660 RVA: 0x00587B40 File Offset: 0x00585D40
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602871D RID: 165661 RVA: 0x00587B4D File Offset: 0x00585D4D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602871E RID: 165662 RVA: 0x00587B54 File Offset: 0x00585D54
		public static IResurrectionComponent GetRootAsIResurrectionComponent(ByteBuffer _bb)
		{
			return IResurrectionComponent.GetRootAsIResurrectionComponent(_bb, default(IResurrectionComponent));
		}

		// Token: 0x0602871F RID: 165663 RVA: 0x00587B70 File Offset: 0x00585D70
		public static IResurrectionComponent GetRootAsIResurrectionComponent(ByteBuffer _bb, IResurrectionComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06028720 RID: 165664 RVA: 0x00587B8D File Offset: 0x00585D8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06028721 RID: 165665 RVA: 0x00587B9C File Offset: 0x00585D9C
		public IResurrectionComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B25F RID: 45663
		// (get) Token: 0x06028722 RID: 165666 RVA: 0x00587BAC File Offset: 0x00585DAC
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B260 RID: 45664
		// (get) Token: 0x06028723 RID: 165667 RVA: 0x00587BEC File Offset: 0x00585DEC
		public IPosA? TeleportPos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B261 RID: 45665
		// (get) Token: 0x06028724 RID: 165668 RVA: 0x00587C4C File Offset: 0x00585E4C
		public TTriggerShape TriggerShapeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTriggerShape.NONE;
				}
				return (TTriggerShape)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028725 RID: 165669 RVA: 0x00587C88 File Offset: 0x00585E88
		public TTable? TriggerShape<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06028726 RID: 165670 RVA: 0x00587CD0 File Offset: 0x00585ED0
		public IActorCollisionTriggerShape TriggerShapeAsIActorCollisionTriggerShape()
		{
			return this.TriggerShape<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x06028727 RID: 165671 RVA: 0x00587CEC File Offset: 0x00585EEC
		public IActorRefVolume TriggerShapeAsIActorRefVolume()
		{
			return this.TriggerShape<IActorRefVolume>().Value;
		}

		// Token: 0x06028728 RID: 165672 RVA: 0x00587D08 File Offset: 0x00585F08
		public IBoxTriggerShape TriggerShapeAsIBoxTriggerShape()
		{
			return this.TriggerShape<IBoxTriggerShape>().Value;
		}

		// Token: 0x06028729 RID: 165673 RVA: 0x00587D24 File Offset: 0x00585F24
		public ICombinationTriggerShape TriggerShapeAsICombinationTriggerShape()
		{
			return this.TriggerShape<ICombinationTriggerShape>().Value;
		}

		// Token: 0x0602872A RID: 165674 RVA: 0x00587D40 File Offset: 0x00585F40
		public IConeTriggerShape TriggerShapeAsIConeTriggerShape()
		{
			return this.TriggerShape<IConeTriggerShape>().Value;
		}

		// Token: 0x0602872B RID: 165675 RVA: 0x00587D5C File Offset: 0x00585F5C
		public ICylinderTriggerShape TriggerShapeAsICylinderTriggerShape()
		{
			return this.TriggerShape<ICylinderTriggerShape>().Value;
		}

		// Token: 0x0602872C RID: 165676 RVA: 0x00587D78 File Offset: 0x00585F78
		public IHollowCylinderTriggerShape TriggerShapeAsIHollowCylinderTriggerShape()
		{
			return this.TriggerShape<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x0602872D RID: 165677 RVA: 0x00587D94 File Offset: 0x00585F94
		public IHollowSphereTriggerShape TriggerShapeAsIHollowSphereTriggerShape()
		{
			return this.TriggerShape<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x0602872E RID: 165678 RVA: 0x00587DB0 File Offset: 0x00585FB0
		public ISphereTriggerShape TriggerShapeAsISphereTriggerShape()
		{
			return this.TriggerShape<ISphereTriggerShape>().Value;
		}

		// Token: 0x0602872F RID: 165679 RVA: 0x00587DCC File Offset: 0x00585FCC
		public ISpotlightTriggerShape TriggerShapeAsISpotlightTriggerShape()
		{
			return this.TriggerShape<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x06028730 RID: 165680 RVA: 0x00587DE8 File Offset: 0x00585FE8
		public IVolumeTriggerShape TriggerShapeAsIVolumeTriggerShape()
		{
			return this.TriggerShape<IVolumeTriggerShape>().Value;
		}

		// Token: 0x1700B262 RID: 45666
		// (get) Token: 0x06028731 RID: 165681 RVA: 0x00587E04 File Offset: 0x00586004
		public EReviveType ReviveId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return EReviveType.None;
				}
				return (EReviveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B263 RID: 45667
		// (get) Token: 0x06028732 RID: 165682 RVA: 0x00587E44 File Offset: 0x00586044
		public IGravityFlipTeleportConfig? GravityConfig
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IGravityFlipTeleportConfig?(default(IGravityFlipTeleportConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B264 RID: 45668
		// (get) Token: 0x06028733 RID: 165683 RVA: 0x00587EA4 File Offset: 0x005860A4
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06028734 RID: 165684 RVA: 0x00587EE4 File Offset: 0x005860E4
		public static Offset<IResurrectionComponent> CreateIResurrectionComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IPosA> TeleportPosOffset = default(Offset<IPosA>), TTriggerShape TriggerShape_type = TTriggerShape.NONE, int TriggerShapeOffset = 0, EReviveType ReviveId = EReviveType.None, Offset<IGravityFlipTeleportConfig> GravityConfigOffset = default(Offset<IGravityFlipTeleportConfig>), byte NullMask = 0)
		{
			builder.StartTable(7);
			IResurrectionComponent.AddGravityConfig(builder, GravityConfigOffset);
			IResurrectionComponent.AddTriggerShape(builder, TriggerShapeOffset);
			IResurrectionComponent.AddTeleportPos(builder, TeleportPosOffset);
			IResurrectionComponent.AddNullMask(builder, NullMask);
			IResurrectionComponent.AddReviveId(builder, ReviveId);
			IResurrectionComponent.AddTriggerShapeType(builder, TriggerShape_type);
			IResurrectionComponent.AddDisabled(builder, Disabled);
			return IResurrectionComponent.EndIResurrectionComponent(builder);
		}

		// Token: 0x06028735 RID: 165685 RVA: 0x00587F33 File Offset: 0x00586133
		public static void StartIResurrectionComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06028736 RID: 165686 RVA: 0x00587F3C File Offset: 0x0058613C
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06028737 RID: 165687 RVA: 0x00587F47 File Offset: 0x00586147
		public static void AddTeleportPos(FlatBufferBuilder builder, Offset<IPosA> teleportPosOffset)
		{
			builder.AddOffset(1, teleportPosOffset.Value, 0);
		}

		// Token: 0x06028738 RID: 165688 RVA: 0x00587F57 File Offset: 0x00586157
		public static void AddTriggerShapeType(FlatBufferBuilder builder, TTriggerShape triggerShapeType)
		{
			builder.AddByte(2, (byte)triggerShapeType, 0);
		}

		// Token: 0x06028739 RID: 165689 RVA: 0x00587F62 File Offset: 0x00586162
		public static void AddTriggerShape(FlatBufferBuilder builder, int triggerShapeOffset)
		{
			builder.AddOffset(3, triggerShapeOffset, 0);
		}

		// Token: 0x0602873A RID: 165690 RVA: 0x00587F6D File Offset: 0x0058616D
		public static void AddReviveId(FlatBufferBuilder builder, EReviveType reviveId)
		{
			builder.AddByte(4, (byte)reviveId, 0);
		}

		// Token: 0x0602873B RID: 165691 RVA: 0x00587F78 File Offset: 0x00586178
		public static void AddGravityConfig(FlatBufferBuilder builder, Offset<IGravityFlipTeleportConfig> gravityConfigOffset)
		{
			builder.AddOffset(5, gravityConfigOffset.Value, 0);
		}

		// Token: 0x0602873C RID: 165692 RVA: 0x00587F88 File Offset: 0x00586188
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x0602873D RID: 165693 RVA: 0x00587F93 File Offset: 0x00586193
		public static Offset<IResurrectionComponent> EndIResurrectionComponent(FlatBufferBuilder builder)
		{
			return new Offset<IResurrectionComponent>(builder.EndTable());
		}

		// Token: 0x0602873E RID: 165694 RVA: 0x00587FA0 File Offset: 0x005861A0
		public IResurrectionComponentT UnPack()
		{
			IResurrectionComponentT resurrectionComponentT = new IResurrectionComponentT();
			this.UnPackTo(resurrectionComponentT);
			return resurrectionComponentT;
		}

		// Token: 0x0602873F RID: 165695 RVA: 0x00587FBC File Offset: 0x005861BC
		public void UnPackTo(IResurrectionComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.TeleportPos = ((this.TeleportPos != null) ? this.TeleportPos.Value.UnPack() : null);
			_o.TriggerShape = new TTriggerShapeUnion();
			_o.TriggerShape.Type = this.TriggerShapeType;
			switch (this.TriggerShapeType)
			{
			case TTriggerShape.IActorCollisionTriggerShape:
				_o.TriggerShape.Value = ((this.TriggerShape<IActorCollisionTriggerShape>() != null) ? this.TriggerShape<IActorCollisionTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IActorRefVolume:
				_o.TriggerShape.Value = ((this.TriggerShape<IActorRefVolume>() != null) ? this.TriggerShape<IActorRefVolume>().Value.UnPack() : null);
				break;
			case TTriggerShape.IBoxTriggerShape:
				_o.TriggerShape.Value = ((this.TriggerShape<IBoxTriggerShape>() != null) ? this.TriggerShape<IBoxTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ICombinationTriggerShape:
				_o.TriggerShape.Value = ((this.TriggerShape<ICombinationTriggerShape>() != null) ? this.TriggerShape<ICombinationTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IConeTriggerShape:
				_o.TriggerShape.Value = ((this.TriggerShape<IConeTriggerShape>() != null) ? this.TriggerShape<IConeTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ICylinderTriggerShape:
				_o.TriggerShape.Value = ((this.TriggerShape<ICylinderTriggerShape>() != null) ? this.TriggerShape<ICylinderTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IHollowCylinderTriggerShape:
				_o.TriggerShape.Value = ((this.TriggerShape<IHollowCylinderTriggerShape>() != null) ? this.TriggerShape<IHollowCylinderTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IHollowSphereTriggerShape:
				_o.TriggerShape.Value = ((this.TriggerShape<IHollowSphereTriggerShape>() != null) ? this.TriggerShape<IHollowSphereTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ISphereTriggerShape:
				_o.TriggerShape.Value = ((this.TriggerShape<ISphereTriggerShape>() != null) ? this.TriggerShape<ISphereTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.ISpotlightTriggerShape:
				_o.TriggerShape.Value = ((this.TriggerShape<ISpotlightTriggerShape>() != null) ? this.TriggerShape<ISpotlightTriggerShape>().Value.UnPack() : null);
				break;
			case TTriggerShape.IVolumeTriggerShape:
				_o.TriggerShape.Value = ((this.TriggerShape<IVolumeTriggerShape>() != null) ? this.TriggerShape<IVolumeTriggerShape>().Value.UnPack() : null);
				break;
			}
			_o.ReviveId = this.ReviveId;
			_o.GravityConfig = ((this.GravityConfig != null) ? this.GravityConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06028740 RID: 165696 RVA: 0x00588334 File Offset: 0x00586534
		public static Offset<IResurrectionComponent> Pack(FlatBufferBuilder builder, IResurrectionComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IResurrectionComponent>);
			}
			Offset<IPosA> teleportPosOffset = (_o.TeleportPos == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.TeleportPos);
			TTriggerShape triggerShape_type = (_o.TriggerShape == null) ? TTriggerShape.NONE : _o.TriggerShape.Type;
			int triggerShapeOffset = (_o.TriggerShape == null) ? 0 : TTriggerShapeUnion.Pack(builder, _o.TriggerShape);
			Offset<IGravityFlipTeleportConfig> gravityConfigOffset = (_o.GravityConfig == null) ? default(Offset<IGravityFlipTeleportConfig>) : IGravityFlipTeleportConfig.Pack(builder, _o.GravityConfig);
			return IResurrectionComponent.CreateIResurrectionComponent(builder, _o.Disabled, teleportPosOffset, triggerShape_type, triggerShapeOffset, _o.ReviveId, gravityConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FA90 RID: 64144
		private Table __p;
	}
}
