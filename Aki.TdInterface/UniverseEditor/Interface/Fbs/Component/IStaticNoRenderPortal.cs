using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C5 RID: 22981
	public struct IStaticNoRenderPortal : IFlatbufferObject
	{
		// Token: 0x1700AC7E RID: 44158
		// (get) Token: 0x06026F33 RID: 159539 RVA: 0x0055BD07 File Offset: 0x00559F07
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026F34 RID: 159540 RVA: 0x0055BD14 File Offset: 0x00559F14
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026F35 RID: 159541 RVA: 0x0055BD1C File Offset: 0x00559F1C
		public static IStaticNoRenderPortal GetRootAsIStaticNoRenderPortal(ByteBuffer _bb)
		{
			return IStaticNoRenderPortal.GetRootAsIStaticNoRenderPortal(_bb, default(IStaticNoRenderPortal));
		}

		// Token: 0x06026F36 RID: 159542 RVA: 0x0055BD38 File Offset: 0x00559F38
		public static IStaticNoRenderPortal GetRootAsIStaticNoRenderPortal(ByteBuffer _bb, IStaticNoRenderPortal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026F37 RID: 159543 RVA: 0x0055BD55 File Offset: 0x00559F55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026F38 RID: 159544 RVA: 0x0055BD64 File Offset: 0x00559F64
		public IStaticNoRenderPortal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC7F RID: 44159
		// (get) Token: 0x06026F39 RID: 159545 RVA: 0x0055BD74 File Offset: 0x00559F74
		public ENoRenderPortalType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENoRenderPortalType.Static;
				}
				return (ENoRenderPortalType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AC80 RID: 44160
		// (get) Token: 0x06026F3A RID: 159546 RVA: 0x0055BDB0 File Offset: 0x00559FB0
		public EPortalModel PortalModel
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPortalModel.A;
				}
				return (EPortalModel)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AC81 RID: 44161
		// (get) Token: 0x06026F3B RID: 159547 RVA: 0x0055BDEC File Offset: 0x00559FEC
		public int LinkPortalEntityId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AC82 RID: 44162
		// (get) Token: 0x06026F3C RID: 159548 RVA: 0x0055BE28 File Offset: 0x0055A028
		public ITeleportSceneEffect? TeleportSceneEffect
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ITeleportSceneEffect?(default(ITeleportSceneEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC83 RID: 44163
		// (get) Token: 0x06026F3D RID: 159549 RVA: 0x0055BE88 File Offset: 0x0055A088
		public TTeleportTransitionOption TeleportLoadingEffectType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TTeleportTransitionOption.NONE;
				}
				return (TTeleportTransitionOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026F3E RID: 159550 RVA: 0x0055BEC8 File Offset: 0x0055A0C8
		public TTable? TeleportLoadingEffect<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026F3F RID: 159551 RVA: 0x0055BF10 File Offset: 0x0055A110
		public ITeleportTransitionInDigitalScreen TeleportLoadingEffectAsITeleportTransitionInDigitalScreen()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x06026F40 RID: 159552 RVA: 0x0055BF2C File Offset: 0x0055A12C
		public ITeleportTransitionInSeamlessType TeleportLoadingEffectAsITeleportTransitionInSeamlessType()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x06026F41 RID: 159553 RVA: 0x0055BF48 File Offset: 0x0055A148
		public ITeleportTransitionWithCenterText TeleportLoadingEffectAsITeleportTransitionWithCenterText()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x06026F42 RID: 159554 RVA: 0x0055BF64 File Offset: 0x0055A164
		public ITeleportTransitionWithCharacterDisplay TeleportLoadingEffectAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x06026F43 RID: 159555 RVA: 0x0055BF80 File Offset: 0x0055A180
		public ITeleportTransitionWithCustomLoading TeleportLoadingEffectAsITeleportTransitionWithCustomLoading()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x06026F44 RID: 159556 RVA: 0x0055BF9C File Offset: 0x0055A19C
		public ITeleportTransitionWithCustomScreen TeleportLoadingEffectAsITeleportTransitionWithCustomScreen()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x06026F45 RID: 159557 RVA: 0x0055BFB8 File Offset: 0x0055A1B8
		public ITeleportTransitionWithEffect TeleportLoadingEffectAsITeleportTransitionWithEffect()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x06026F46 RID: 159558 RVA: 0x0055BFD4 File Offset: 0x0055A1D4
		public ITeleportTransitionWithFadeInScreen TeleportLoadingEffectAsITeleportTransitionWithFadeInScreen()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x06026F47 RID: 159559 RVA: 0x0055BFF0 File Offset: 0x0055A1F0
		public ITeleportTransitionWithMp4 TeleportLoadingEffectAsITeleportTransitionWithMp4()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x06026F48 RID: 159560 RVA: 0x0055C00C File Offset: 0x0055A20C
		public ITeleportTransitionWithPlayFlow TeleportLoadingEffectAsITeleportTransitionWithPlayFlow()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x06026F49 RID: 159561 RVA: 0x0055C028 File Offset: 0x0055A228
		public ITeleportTransitionWithSpecialCustomLoading TeleportLoadingEffectAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x1700AC84 RID: 44164
		// (get) Token: 0x06026F4A RID: 159562 RVA: 0x0055C044 File Offset: 0x0055A244
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC85 RID: 44165
		// (get) Token: 0x06026F4B RID: 159563 RVA: 0x0055C0A4 File Offset: 0x0055A2A4
		public IVectorInfo? TeleportToSelfPos
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC86 RID: 44166
		// (get) Token: 0x06026F4C RID: 159564 RVA: 0x0055C104 File Offset: 0x0055A304
		public IGravityFlipTeleportConfig? GravityConfig
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IGravityFlipTeleportConfig?(default(IGravityFlipTeleportConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC87 RID: 44167
		// (get) Token: 0x06026F4D RID: 159565 RVA: 0x0055C164 File Offset: 0x0055A364
		public bool NoBlindSpot
		{
			get
			{
				int num = this.__p.__offset(22);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AC88 RID: 44168
		// (get) Token: 0x06026F4E RID: 159566 RVA: 0x0055C1A4 File Offset: 0x0055A3A4
		public ETeleportActionType ActionAfterTeleport
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return ETeleportActionType.Dodge;
				}
				return (ETeleportActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026F4F RID: 159567 RVA: 0x0055C1E4 File Offset: 0x0055A3E4
		public int NpcMonsterEntityIds(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700AC89 RID: 44169
		// (get) Token: 0x06026F50 RID: 159568 RVA: 0x0055C224 File Offset: 0x0055A424
		public int NpcMonsterEntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06026F51 RID: 159569 RVA: 0x0055C250 File Offset: 0x0055A450
		public Span<int> GetNpcMonsterEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06026F52 RID: 159570 RVA: 0x0055C260 File Offset: 0x0055A460
		public int[] GetNpcMonsterEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(26);
		}

		// Token: 0x1700AC8A RID: 44170
		// (get) Token: 0x06026F53 RID: 159571 RVA: 0x0055C270 File Offset: 0x0055A470
		public IAfterTeleportConfig? AfterTeleportConfig
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return new IAfterTeleportConfig?(default(IAfterTeleportConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC8B RID: 44171
		// (get) Token: 0x06026F54 RID: 159572 RVA: 0x0055C2D0 File Offset: 0x0055A4D0
		public int TeleportStreamRadius
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AC8C RID: 44172
		// (get) Token: 0x06026F55 RID: 159573 RVA: 0x0055C310 File Offset: 0x0055A510
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026F56 RID: 159574 RVA: 0x0055C350 File Offset: 0x0055A550
		public static Offset<IStaticNoRenderPortal> CreateIStaticNoRenderPortal(FlatBufferBuilder builder, ENoRenderPortalType Type = ENoRenderPortalType.Static, EPortalModel PortalModel = EPortalModel.A, int LinkPortalEntityId = 0, Offset<ITeleportSceneEffect> TeleportSceneEffectOffset = default(Offset<ITeleportSceneEffect>), TTeleportTransitionOption TeleportLoadingEffect_type = TTeleportTransitionOption.NONE, int TeleportLoadingEffectOffset = 0, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<IVectorInfo> TeleportToSelfPosOffset = default(Offset<IVectorInfo>), Offset<IGravityFlipTeleportConfig> GravityConfigOffset = default(Offset<IGravityFlipTeleportConfig>), bool NoBlindSpot = false, ETeleportActionType ActionAfterTeleport = ETeleportActionType.Dodge, VectorOffset NpcMonsterEntityIdsOffset = default(VectorOffset), Offset<IAfterTeleportConfig> AfterTeleportConfigOffset = default(Offset<IAfterTeleportConfig>), int TeleportStreamRadius = 0, byte NullMask = 0)
		{
			builder.StartTable(15);
			IStaticNoRenderPortal.AddTeleportStreamRadius(builder, TeleportStreamRadius);
			IStaticNoRenderPortal.AddAfterTeleportConfig(builder, AfterTeleportConfigOffset);
			IStaticNoRenderPortal.AddNpcMonsterEntityIds(builder, NpcMonsterEntityIdsOffset);
			IStaticNoRenderPortal.AddGravityConfig(builder, GravityConfigOffset);
			IStaticNoRenderPortal.AddTeleportToSelfPos(builder, TeleportToSelfPosOffset);
			IStaticNoRenderPortal.AddCondition(builder, ConditionOffset);
			IStaticNoRenderPortal.AddTeleportLoadingEffect(builder, TeleportLoadingEffectOffset);
			IStaticNoRenderPortal.AddTeleportSceneEffect(builder, TeleportSceneEffectOffset);
			IStaticNoRenderPortal.AddLinkPortalEntityId(builder, LinkPortalEntityId);
			IStaticNoRenderPortal.AddNullMask(builder, NullMask);
			IStaticNoRenderPortal.AddActionAfterTeleport(builder, ActionAfterTeleport);
			IStaticNoRenderPortal.AddNoBlindSpot(builder, NoBlindSpot);
			IStaticNoRenderPortal.AddTeleportLoadingEffectType(builder, TeleportLoadingEffect_type);
			IStaticNoRenderPortal.AddPortalModel(builder, PortalModel);
			IStaticNoRenderPortal.AddType(builder, Type);
			return IStaticNoRenderPortal.EndIStaticNoRenderPortal(builder);
		}

		// Token: 0x06026F57 RID: 159575 RVA: 0x0055C3E0 File Offset: 0x0055A5E0
		public static void StartIStaticNoRenderPortal(FlatBufferBuilder builder)
		{
			builder.StartTable(15);
		}

		// Token: 0x06026F58 RID: 159576 RVA: 0x0055C3EA File Offset: 0x0055A5EA
		public static void AddType(FlatBufferBuilder builder, ENoRenderPortalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026F59 RID: 159577 RVA: 0x0055C3F5 File Offset: 0x0055A5F5
		public static void AddPortalModel(FlatBufferBuilder builder, EPortalModel portalModel)
		{
			builder.AddByte(1, (byte)portalModel, 0);
		}

		// Token: 0x06026F5A RID: 159578 RVA: 0x0055C400 File Offset: 0x0055A600
		public static void AddLinkPortalEntityId(FlatBufferBuilder builder, int linkPortalEntityId)
		{
			builder.AddInt(2, linkPortalEntityId, 0);
		}

		// Token: 0x06026F5B RID: 159579 RVA: 0x0055C40B File Offset: 0x0055A60B
		public static void AddTeleportSceneEffect(FlatBufferBuilder builder, Offset<ITeleportSceneEffect> teleportSceneEffectOffset)
		{
			builder.AddOffset(3, teleportSceneEffectOffset.Value, 0);
		}

		// Token: 0x06026F5C RID: 159580 RVA: 0x0055C41B File Offset: 0x0055A61B
		public static void AddTeleportLoadingEffectType(FlatBufferBuilder builder, TTeleportTransitionOption teleportLoadingEffectType)
		{
			builder.AddByte(4, (byte)teleportLoadingEffectType, 0);
		}

		// Token: 0x06026F5D RID: 159581 RVA: 0x0055C426 File Offset: 0x0055A626
		public static void AddTeleportLoadingEffect(FlatBufferBuilder builder, int teleportLoadingEffectOffset)
		{
			builder.AddOffset(5, teleportLoadingEffectOffset, 0);
		}

		// Token: 0x06026F5E RID: 159582 RVA: 0x0055C431 File Offset: 0x0055A631
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(6, conditionOffset.Value, 0);
		}

		// Token: 0x06026F5F RID: 159583 RVA: 0x0055C441 File Offset: 0x0055A641
		public static void AddTeleportToSelfPos(FlatBufferBuilder builder, Offset<IVectorInfo> teleportToSelfPosOffset)
		{
			builder.AddOffset(7, teleportToSelfPosOffset.Value, 0);
		}

		// Token: 0x06026F60 RID: 159584 RVA: 0x0055C451 File Offset: 0x0055A651
		public static void AddGravityConfig(FlatBufferBuilder builder, Offset<IGravityFlipTeleportConfig> gravityConfigOffset)
		{
			builder.AddOffset(8, gravityConfigOffset.Value, 0);
		}

		// Token: 0x06026F61 RID: 159585 RVA: 0x0055C461 File Offset: 0x0055A661
		public static void AddNoBlindSpot(FlatBufferBuilder builder, bool noBlindSpot)
		{
			builder.AddBool(9, noBlindSpot, false);
		}

		// Token: 0x06026F62 RID: 159586 RVA: 0x0055C46D File Offset: 0x0055A66D
		public static void AddActionAfterTeleport(FlatBufferBuilder builder, ETeleportActionType actionAfterTeleport)
		{
			builder.AddByte(10, (byte)actionAfterTeleport, 0);
		}

		// Token: 0x06026F63 RID: 159587 RVA: 0x0055C479 File Offset: 0x0055A679
		public static void AddNpcMonsterEntityIds(FlatBufferBuilder builder, VectorOffset npcMonsterEntityIdsOffset)
		{
			builder.AddOffset(11, npcMonsterEntityIdsOffset.Value, 0);
		}

		// Token: 0x06026F64 RID: 159588 RVA: 0x0055C48C File Offset: 0x0055A68C
		public static VectorOffset CreateNpcMonsterEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06026F65 RID: 159589 RVA: 0x0055C4C3 File Offset: 0x0055A6C3
		public static VectorOffset CreateNpcMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026F66 RID: 159590 RVA: 0x0055C4DD File Offset: 0x0055A6DD
		public static VectorOffset CreateNpcMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06026F67 RID: 159591 RVA: 0x0055C4FB File Offset: 0x0055A6FB
		public static VectorOffset CreateNpcMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026F68 RID: 159592 RVA: 0x0055C514 File Offset: 0x0055A714
		public static void StartNpcMonsterEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026F69 RID: 159593 RVA: 0x0055C51F File Offset: 0x0055A71F
		public static void AddAfterTeleportConfig(FlatBufferBuilder builder, Offset<IAfterTeleportConfig> afterTeleportConfigOffset)
		{
			builder.AddOffset(12, afterTeleportConfigOffset.Value, 0);
		}

		// Token: 0x06026F6A RID: 159594 RVA: 0x0055C530 File Offset: 0x0055A730
		public static void AddTeleportStreamRadius(FlatBufferBuilder builder, int teleportStreamRadius)
		{
			builder.AddInt(13, teleportStreamRadius, 0);
		}

		// Token: 0x06026F6B RID: 159595 RVA: 0x0055C53C File Offset: 0x0055A73C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(14, nullMask, 0);
		}

		// Token: 0x06026F6C RID: 159596 RVA: 0x0055C548 File Offset: 0x0055A748
		public static Offset<IStaticNoRenderPortal> EndIStaticNoRenderPortal(FlatBufferBuilder builder)
		{
			return new Offset<IStaticNoRenderPortal>(builder.EndTable());
		}

		// Token: 0x06026F6D RID: 159597 RVA: 0x0055C558 File Offset: 0x0055A758
		public IStaticNoRenderPortalT UnPack()
		{
			IStaticNoRenderPortalT staticNoRenderPortalT = new IStaticNoRenderPortalT();
			this.UnPackTo(staticNoRenderPortalT);
			return staticNoRenderPortalT;
		}

		// Token: 0x06026F6E RID: 159598 RVA: 0x0055C574 File Offset: 0x0055A774
		public void UnPackTo(IStaticNoRenderPortalT _o)
		{
			_o.Type = this.Type;
			_o.PortalModel = this.PortalModel;
			_o.LinkPortalEntityId = this.LinkPortalEntityId;
			_o.TeleportSceneEffect = ((this.TeleportSceneEffect != null) ? this.TeleportSceneEffect.Value.UnPack() : null);
			_o.TeleportLoadingEffect = new TTeleportTransitionOptionUnion();
			_o.TeleportLoadingEffect.Type = this.TeleportLoadingEffectType;
			switch (this.TeleportLoadingEffectType)
			{
			case TTeleportTransitionOption.ITeleportTransitionInDigitalScreen:
				_o.TeleportLoadingEffect.Value = ((this.TeleportLoadingEffect<ITeleportTransitionInDigitalScreen>() != null) ? this.TeleportLoadingEffect<ITeleportTransitionInDigitalScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionInSeamlessType:
				_o.TeleportLoadingEffect.Value = ((this.TeleportLoadingEffect<ITeleportTransitionInSeamlessType>() != null) ? this.TeleportLoadingEffect<ITeleportTransitionInSeamlessType>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCenterText:
				_o.TeleportLoadingEffect.Value = ((this.TeleportLoadingEffect<ITeleportTransitionWithCenterText>() != null) ? this.TeleportLoadingEffect<ITeleportTransitionWithCenterText>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCharacterDisplay:
				_o.TeleportLoadingEffect.Value = ((this.TeleportLoadingEffect<ITeleportTransitionWithCharacterDisplay>() != null) ? this.TeleportLoadingEffect<ITeleportTransitionWithCharacterDisplay>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomLoading:
				_o.TeleportLoadingEffect.Value = ((this.TeleportLoadingEffect<ITeleportTransitionWithCustomLoading>() != null) ? this.TeleportLoadingEffect<ITeleportTransitionWithCustomLoading>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomScreen:
				_o.TeleportLoadingEffect.Value = ((this.TeleportLoadingEffect<ITeleportTransitionWithCustomScreen>() != null) ? this.TeleportLoadingEffect<ITeleportTransitionWithCustomScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithEffect:
				_o.TeleportLoadingEffect.Value = ((this.TeleportLoadingEffect<ITeleportTransitionWithEffect>() != null) ? this.TeleportLoadingEffect<ITeleportTransitionWithEffect>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithFadeInScreen:
				_o.TeleportLoadingEffect.Value = ((this.TeleportLoadingEffect<ITeleportTransitionWithFadeInScreen>() != null) ? this.TeleportLoadingEffect<ITeleportTransitionWithFadeInScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithMp4:
				_o.TeleportLoadingEffect.Value = ((this.TeleportLoadingEffect<ITeleportTransitionWithMp4>() != null) ? this.TeleportLoadingEffect<ITeleportTransitionWithMp4>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithPlayFlow:
				_o.TeleportLoadingEffect.Value = ((this.TeleportLoadingEffect<ITeleportTransitionWithPlayFlow>() != null) ? this.TeleportLoadingEffect<ITeleportTransitionWithPlayFlow>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithSpecialCustomLoading:
				_o.TeleportLoadingEffect.Value = ((this.TeleportLoadingEffect<ITeleportTransitionWithSpecialCustomLoading>() != null) ? this.TeleportLoadingEffect<ITeleportTransitionWithSpecialCustomLoading>().Value.UnPack() : null);
				break;
			}
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.TeleportToSelfPos = ((this.TeleportToSelfPos != null) ? this.TeleportToSelfPos.Value.UnPack() : null);
			_o.GravityConfig = ((this.GravityConfig != null) ? this.GravityConfig.Value.UnPack() : null);
			_o.NoBlindSpot = this.NoBlindSpot;
			_o.ActionAfterTeleport = this.ActionAfterTeleport;
			_o.NpcMonsterEntityIds = new List<int>();
			for (int i = 0; i < this.NpcMonsterEntityIdsLength; i++)
			{
				_o.NpcMonsterEntityIds.Add(this.NpcMonsterEntityIds(i));
			}
			_o.AfterTeleportConfig = ((this.AfterTeleportConfig != null) ? this.AfterTeleportConfig.Value.UnPack() : null);
			_o.TeleportStreamRadius = this.TeleportStreamRadius;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026F6F RID: 159599 RVA: 0x0055C9E4 File Offset: 0x0055ABE4
		public static Offset<IStaticNoRenderPortal> Pack(FlatBufferBuilder builder, IStaticNoRenderPortalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStaticNoRenderPortal>);
			}
			Offset<ITeleportSceneEffect> teleportSceneEffectOffset = (_o.TeleportSceneEffect == null) ? default(Offset<ITeleportSceneEffect>) : ITeleportSceneEffect.Pack(builder, _o.TeleportSceneEffect);
			TTeleportTransitionOption teleportLoadingEffect_type = (_o.TeleportLoadingEffect == null) ? TTeleportTransitionOption.NONE : _o.TeleportLoadingEffect.Type;
			int teleportLoadingEffectOffset = (_o.TeleportLoadingEffect == null) ? 0 : TTeleportTransitionOptionUnion.Pack(builder, _o.TeleportLoadingEffect);
			Offset<IConditionGroup> conditionOffset = (_o.Condition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Condition);
			Offset<IVectorInfo> teleportToSelfPosOffset = (_o.TeleportToSelfPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TeleportToSelfPos);
			Offset<IGravityFlipTeleportConfig> gravityConfigOffset = (_o.GravityConfig == null) ? default(Offset<IGravityFlipTeleportConfig>) : IGravityFlipTeleportConfig.Pack(builder, _o.GravityConfig);
			VectorOffset npcMonsterEntityIdsOffset = default(VectorOffset);
			if (_o.NpcMonsterEntityIds != null)
			{
				int[] data = _o.NpcMonsterEntityIds.ToArray();
				npcMonsterEntityIdsOffset = IStaticNoRenderPortal.CreateNpcMonsterEntityIdsVector(builder, data);
			}
			Offset<IAfterTeleportConfig> afterTeleportConfigOffset = (_o.AfterTeleportConfig == null) ? default(Offset<IAfterTeleportConfig>) : IAfterTeleportConfig.Pack(builder, _o.AfterTeleportConfig);
			return IStaticNoRenderPortal.CreateIStaticNoRenderPortal(builder, _o.Type, _o.PortalModel, _o.LinkPortalEntityId, teleportSceneEffectOffset, teleportLoadingEffect_type, teleportLoadingEffectOffset, conditionOffset, teleportToSelfPosOffset, gravityConfigOffset, _o.NoBlindSpot, _o.ActionAfterTeleport, npcMonsterEntityIdsOffset, afterTeleportConfigOffset, _o.TeleportStreamRadius, _o.NullMask);
		}

		// Token: 0x0400EFE0 RID: 61408
		private Table __p;
	}
}
