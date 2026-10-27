using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Shape;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005864 RID: 22628
	public struct IResurrectionComponent : IFlatbufferObject
	{
		// Token: 0x1700A92E RID: 43310
		// (get) Token: 0x060261BA RID: 156090 RVA: 0x00540FF4 File Offset: 0x0053F1F4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060261BB RID: 156091 RVA: 0x00541001 File Offset: 0x0053F201
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060261BC RID: 156092 RVA: 0x00541008 File Offset: 0x0053F208
		public static IResurrectionComponent GetRootAsIResurrectionComponent(ByteBuffer _bb)
		{
			return IResurrectionComponent.GetRootAsIResurrectionComponent(_bb, default(IResurrectionComponent));
		}

		// Token: 0x060261BD RID: 156093 RVA: 0x00541024 File Offset: 0x0053F224
		public static IResurrectionComponent GetRootAsIResurrectionComponent(ByteBuffer _bb, IResurrectionComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060261BE RID: 156094 RVA: 0x00541041 File Offset: 0x0053F241
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060261BF RID: 156095 RVA: 0x00541050 File Offset: 0x0053F250
		public IResurrectionComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A92F RID: 43311
		// (get) Token: 0x060261C0 RID: 156096 RVA: 0x00541060 File Offset: 0x0053F260
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A930 RID: 43312
		// (get) Token: 0x060261C1 RID: 156097 RVA: 0x005410A0 File Offset: 0x0053F2A0
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

		// Token: 0x1700A931 RID: 43313
		// (get) Token: 0x060261C2 RID: 156098 RVA: 0x00541100 File Offset: 0x0053F300
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

		// Token: 0x060261C3 RID: 156099 RVA: 0x0054113C File Offset: 0x0053F33C
		public TTable? TriggerShape<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060261C4 RID: 156100 RVA: 0x00541184 File Offset: 0x0053F384
		public IActorCollisionTriggerShape TriggerShapeAsIActorCollisionTriggerShape()
		{
			return this.TriggerShape<IActorCollisionTriggerShape>().Value;
		}

		// Token: 0x060261C5 RID: 156101 RVA: 0x005411A0 File Offset: 0x0053F3A0
		public IActorRefVolume TriggerShapeAsIActorRefVolume()
		{
			return this.TriggerShape<IActorRefVolume>().Value;
		}

		// Token: 0x060261C6 RID: 156102 RVA: 0x005411BC File Offset: 0x0053F3BC
		public IBoxTriggerShape TriggerShapeAsIBoxTriggerShape()
		{
			return this.TriggerShape<IBoxTriggerShape>().Value;
		}

		// Token: 0x060261C7 RID: 156103 RVA: 0x005411D8 File Offset: 0x0053F3D8
		public ICombinationTriggerShape TriggerShapeAsICombinationTriggerShape()
		{
			return this.TriggerShape<ICombinationTriggerShape>().Value;
		}

		// Token: 0x060261C8 RID: 156104 RVA: 0x005411F4 File Offset: 0x0053F3F4
		public IConeTriggerShape TriggerShapeAsIConeTriggerShape()
		{
			return this.TriggerShape<IConeTriggerShape>().Value;
		}

		// Token: 0x060261C9 RID: 156105 RVA: 0x00541210 File Offset: 0x0053F410
		public ICylinderTriggerShape TriggerShapeAsICylinderTriggerShape()
		{
			return this.TriggerShape<ICylinderTriggerShape>().Value;
		}

		// Token: 0x060261CA RID: 156106 RVA: 0x0054122C File Offset: 0x0053F42C
		public IHollowCylinderTriggerShape TriggerShapeAsIHollowCylinderTriggerShape()
		{
			return this.TriggerShape<IHollowCylinderTriggerShape>().Value;
		}

		// Token: 0x060261CB RID: 156107 RVA: 0x00541248 File Offset: 0x0053F448
		public IHollowSphereTriggerShape TriggerShapeAsIHollowSphereTriggerShape()
		{
			return this.TriggerShape<IHollowSphereTriggerShape>().Value;
		}

		// Token: 0x060261CC RID: 156108 RVA: 0x00541264 File Offset: 0x0053F464
		public ISphereTriggerShape TriggerShapeAsISphereTriggerShape()
		{
			return this.TriggerShape<ISphereTriggerShape>().Value;
		}

		// Token: 0x060261CD RID: 156109 RVA: 0x00541280 File Offset: 0x0053F480
		public ISpotlightTriggerShape TriggerShapeAsISpotlightTriggerShape()
		{
			return this.TriggerShape<ISpotlightTriggerShape>().Value;
		}

		// Token: 0x060261CE RID: 156110 RVA: 0x0054129C File Offset: 0x0053F49C
		public IVolumeTriggerShape TriggerShapeAsIVolumeTriggerShape()
		{
			return this.TriggerShape<IVolumeTriggerShape>().Value;
		}

		// Token: 0x1700A932 RID: 43314
		// (get) Token: 0x060261CF RID: 156111 RVA: 0x005412B8 File Offset: 0x0053F4B8
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

		// Token: 0x1700A933 RID: 43315
		// (get) Token: 0x060261D0 RID: 156112 RVA: 0x005412F8 File Offset: 0x0053F4F8
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

		// Token: 0x1700A934 RID: 43316
		// (get) Token: 0x060261D1 RID: 156113 RVA: 0x00541358 File Offset: 0x0053F558
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

		// Token: 0x060261D2 RID: 156114 RVA: 0x00541398 File Offset: 0x0053F598
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

		// Token: 0x060261D3 RID: 156115 RVA: 0x005413E7 File Offset: 0x0053F5E7
		public static void StartIResurrectionComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060261D4 RID: 156116 RVA: 0x005413F0 File Offset: 0x0053F5F0
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060261D5 RID: 156117 RVA: 0x005413FB File Offset: 0x0053F5FB
		public static void AddTeleportPos(FlatBufferBuilder builder, Offset<IPosA> teleportPosOffset)
		{
			builder.AddOffset(1, teleportPosOffset.Value, 0);
		}

		// Token: 0x060261D6 RID: 156118 RVA: 0x0054140B File Offset: 0x0053F60B
		public static void AddTriggerShapeType(FlatBufferBuilder builder, TTriggerShape triggerShapeType)
		{
			builder.AddByte(2, (byte)triggerShapeType, 0);
		}

		// Token: 0x060261D7 RID: 156119 RVA: 0x00541416 File Offset: 0x0053F616
		public static void AddTriggerShape(FlatBufferBuilder builder, int triggerShapeOffset)
		{
			builder.AddOffset(3, triggerShapeOffset, 0);
		}

		// Token: 0x060261D8 RID: 156120 RVA: 0x00541421 File Offset: 0x0053F621
		public static void AddReviveId(FlatBufferBuilder builder, EReviveType reviveId)
		{
			builder.AddByte(4, (byte)reviveId, 0);
		}

		// Token: 0x060261D9 RID: 156121 RVA: 0x0054142C File Offset: 0x0053F62C
		public static void AddGravityConfig(FlatBufferBuilder builder, Offset<IGravityFlipTeleportConfig> gravityConfigOffset)
		{
			builder.AddOffset(5, gravityConfigOffset.Value, 0);
		}

		// Token: 0x060261DA RID: 156122 RVA: 0x0054143C File Offset: 0x0053F63C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060261DB RID: 156123 RVA: 0x00541447 File Offset: 0x0053F647
		public static Offset<IResurrectionComponent> EndIResurrectionComponent(FlatBufferBuilder builder)
		{
			return new Offset<IResurrectionComponent>(builder.EndTable());
		}

		// Token: 0x060261DC RID: 156124 RVA: 0x00541454 File Offset: 0x0053F654
		public IResurrectionComponentT UnPack()
		{
			IResurrectionComponentT resurrectionComponentT = new IResurrectionComponentT();
			this.UnPackTo(resurrectionComponentT);
			return resurrectionComponentT;
		}

		// Token: 0x060261DD RID: 156125 RVA: 0x00541470 File Offset: 0x0053F670
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

		// Token: 0x060261DE RID: 156126 RVA: 0x005417E8 File Offset: 0x0053F9E8
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

		// Token: 0x0400ED9D RID: 60829
		private Table __p;
	}
}
