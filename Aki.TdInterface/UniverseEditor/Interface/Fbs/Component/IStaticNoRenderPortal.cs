using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005FD2 RID: 24530
	public struct IStaticNoRenderPortal : IFlatbufferObject
	{
		// Token: 0x1700B5B4 RID: 46516
		// (get) Token: 0x060294A7 RID: 169127 RVA: 0x005A2BBF File Offset: 0x005A0DBF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060294A8 RID: 169128 RVA: 0x005A2BCC File Offset: 0x005A0DCC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060294A9 RID: 169129 RVA: 0x005A2BD4 File Offset: 0x005A0DD4
		public static IStaticNoRenderPortal GetRootAsIStaticNoRenderPortal(ByteBuffer _bb)
		{
			return IStaticNoRenderPortal.GetRootAsIStaticNoRenderPortal(_bb, default(IStaticNoRenderPortal));
		}

		// Token: 0x060294AA RID: 169130 RVA: 0x005A2BF0 File Offset: 0x005A0DF0
		public static IStaticNoRenderPortal GetRootAsIStaticNoRenderPortal(ByteBuffer _bb, IStaticNoRenderPortal obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060294AB RID: 169131 RVA: 0x005A2C0D File Offset: 0x005A0E0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060294AC RID: 169132 RVA: 0x005A2C1C File Offset: 0x005A0E1C
		public IStaticNoRenderPortal __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5B5 RID: 46517
		// (get) Token: 0x060294AD RID: 169133 RVA: 0x005A2C2C File Offset: 0x005A0E2C
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

		// Token: 0x1700B5B6 RID: 46518
		// (get) Token: 0x060294AE RID: 169134 RVA: 0x005A2C68 File Offset: 0x005A0E68
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

		// Token: 0x1700B5B7 RID: 46519
		// (get) Token: 0x060294AF RID: 169135 RVA: 0x005A2CA4 File Offset: 0x005A0EA4
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

		// Token: 0x1700B5B8 RID: 46520
		// (get) Token: 0x060294B0 RID: 169136 RVA: 0x005A2CE0 File Offset: 0x005A0EE0
		public ICubeMapBinding? CubeMapBinding
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ICubeMapBinding?(default(ICubeMapBinding).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B5B9 RID: 46521
		// (get) Token: 0x060294B1 RID: 169137 RVA: 0x005A2D40 File Offset: 0x005A0F40
		public ITeleportSceneEffect? TeleportSceneEffect
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ITeleportSceneEffect?(default(ITeleportSceneEffect).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B5BA RID: 46522
		// (get) Token: 0x060294B2 RID: 169138 RVA: 0x005A2DA0 File Offset: 0x005A0FA0
		public TTeleportTransitionOption TeleportLoadingEffectType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return TTeleportTransitionOption.NONE;
				}
				return (TTeleportTransitionOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060294B3 RID: 169139 RVA: 0x005A2DE0 File Offset: 0x005A0FE0
		public TTable? TeleportLoadingEffect<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060294B4 RID: 169140 RVA: 0x005A2E28 File Offset: 0x005A1028
		public ITeleportTransitionInDigitalScreen TeleportLoadingEffectAsITeleportTransitionInDigitalScreen()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x060294B5 RID: 169141 RVA: 0x005A2E44 File Offset: 0x005A1044
		public ITeleportTransitionInSeamlessType TeleportLoadingEffectAsITeleportTransitionInSeamlessType()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x060294B6 RID: 169142 RVA: 0x005A2E60 File Offset: 0x005A1060
		public ITeleportTransitionWithCenterText TeleportLoadingEffectAsITeleportTransitionWithCenterText()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x060294B7 RID: 169143 RVA: 0x005A2E7C File Offset: 0x005A107C
		public ITeleportTransitionWithCharacterDisplay TeleportLoadingEffectAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x060294B8 RID: 169144 RVA: 0x005A2E98 File Offset: 0x005A1098
		public ITeleportTransitionWithCustomLoading TeleportLoadingEffectAsITeleportTransitionWithCustomLoading()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x060294B9 RID: 169145 RVA: 0x005A2EB4 File Offset: 0x005A10B4
		public ITeleportTransitionWithCustomScreen TeleportLoadingEffectAsITeleportTransitionWithCustomScreen()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x060294BA RID: 169146 RVA: 0x005A2ED0 File Offset: 0x005A10D0
		public ITeleportTransitionWithEffect TeleportLoadingEffectAsITeleportTransitionWithEffect()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x060294BB RID: 169147 RVA: 0x005A2EEC File Offset: 0x005A10EC
		public ITeleportTransitionWithFadeInScreen TeleportLoadingEffectAsITeleportTransitionWithFadeInScreen()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x060294BC RID: 169148 RVA: 0x005A2F08 File Offset: 0x005A1108
		public ITeleportTransitionWithMp4 TeleportLoadingEffectAsITeleportTransitionWithMp4()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x060294BD RID: 169149 RVA: 0x005A2F24 File Offset: 0x005A1124
		public ITeleportTransitionWithPlayFlow TeleportLoadingEffectAsITeleportTransitionWithPlayFlow()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x060294BE RID: 169150 RVA: 0x005A2F40 File Offset: 0x005A1140
		public ITeleportTransitionWithSpecialCustomLoading TeleportLoadingEffectAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TeleportLoadingEffect<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x1700B5BB RID: 46523
		// (get) Token: 0x060294BF RID: 169151 RVA: 0x005A2F5C File Offset: 0x005A115C
		public IConditionGroup? Condition
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B5BC RID: 46524
		// (get) Token: 0x060294C0 RID: 169152 RVA: 0x005A2FBC File Offset: 0x005A11BC
		public IVectorInfo? TeleportToSelfPos
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B5BD RID: 46525
		// (get) Token: 0x060294C1 RID: 169153 RVA: 0x005A301C File Offset: 0x005A121C
		public IGravityFlipTeleportConfig? GravityConfig
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IGravityFlipTeleportConfig?(default(IGravityFlipTeleportConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B5BE RID: 46526
		// (get) Token: 0x060294C2 RID: 169154 RVA: 0x005A307C File Offset: 0x005A127C
		public bool NoBlindSpot
		{
			get
			{
				int num = this.__p.__offset(24);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B5BF RID: 46527
		// (get) Token: 0x060294C3 RID: 169155 RVA: 0x005A30BC File Offset: 0x005A12BC
		public ETeleportActionType ActionAfterTeleport
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return ETeleportActionType.Dodge;
				}
				return (ETeleportActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060294C4 RID: 169156 RVA: 0x005A30FC File Offset: 0x005A12FC
		public int NpcMonsterEntityIds(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700B5C0 RID: 46528
		// (get) Token: 0x060294C5 RID: 169157 RVA: 0x005A313C File Offset: 0x005A133C
		public int NpcMonsterEntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060294C6 RID: 169158 RVA: 0x005A3168 File Offset: 0x005A1368
		public Span<int> GetNpcMonsterEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x060294C7 RID: 169159 RVA: 0x005A3178 File Offset: 0x005A1378
		public int[] GetNpcMonsterEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(28);
		}

		// Token: 0x1700B5C1 RID: 46529
		// (get) Token: 0x060294C8 RID: 169160 RVA: 0x005A3188 File Offset: 0x005A1388
		public IAfterTeleportConfig? AfterTeleportConfig
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return new IAfterTeleportConfig?(default(IAfterTeleportConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B5C2 RID: 46530
		// (get) Token: 0x060294C9 RID: 169161 RVA: 0x005A31E8 File Offset: 0x005A13E8
		public int TeleportStreamRadius
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B5C3 RID: 46531
		// (get) Token: 0x060294CA RID: 169162 RVA: 0x005A3228 File Offset: 0x005A1428
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060294CB RID: 169163 RVA: 0x005A3268 File Offset: 0x005A1468
		public static Offset<IStaticNoRenderPortal> CreateIStaticNoRenderPortal(FlatBufferBuilder builder, ENoRenderPortalType Type = ENoRenderPortalType.Static, EPortalModel PortalModel = EPortalModel.A, int LinkPortalEntityId = 0, Offset<ICubeMapBinding> CubeMapBindingOffset = default(Offset<ICubeMapBinding>), Offset<ITeleportSceneEffect> TeleportSceneEffectOffset = default(Offset<ITeleportSceneEffect>), TTeleportTransitionOption TeleportLoadingEffect_type = TTeleportTransitionOption.NONE, int TeleportLoadingEffectOffset = 0, Offset<IConditionGroup> ConditionOffset = default(Offset<IConditionGroup>), Offset<IVectorInfo> TeleportToSelfPosOffset = default(Offset<IVectorInfo>), Offset<IGravityFlipTeleportConfig> GravityConfigOffset = default(Offset<IGravityFlipTeleportConfig>), bool NoBlindSpot = false, ETeleportActionType ActionAfterTeleport = ETeleportActionType.Dodge, VectorOffset NpcMonsterEntityIdsOffset = default(VectorOffset), Offset<IAfterTeleportConfig> AfterTeleportConfigOffset = default(Offset<IAfterTeleportConfig>), int TeleportStreamRadius = 0, byte NullMask = 0)
		{
			builder.StartTable(16);
			IStaticNoRenderPortal.AddTeleportStreamRadius(builder, TeleportStreamRadius);
			IStaticNoRenderPortal.AddAfterTeleportConfig(builder, AfterTeleportConfigOffset);
			IStaticNoRenderPortal.AddNpcMonsterEntityIds(builder, NpcMonsterEntityIdsOffset);
			IStaticNoRenderPortal.AddGravityConfig(builder, GravityConfigOffset);
			IStaticNoRenderPortal.AddTeleportToSelfPos(builder, TeleportToSelfPosOffset);
			IStaticNoRenderPortal.AddCondition(builder, ConditionOffset);
			IStaticNoRenderPortal.AddTeleportLoadingEffect(builder, TeleportLoadingEffectOffset);
			IStaticNoRenderPortal.AddTeleportSceneEffect(builder, TeleportSceneEffectOffset);
			IStaticNoRenderPortal.AddCubeMapBinding(builder, CubeMapBindingOffset);
			IStaticNoRenderPortal.AddLinkPortalEntityId(builder, LinkPortalEntityId);
			IStaticNoRenderPortal.AddNullMask(builder, NullMask);
			IStaticNoRenderPortal.AddActionAfterTeleport(builder, ActionAfterTeleport);
			IStaticNoRenderPortal.AddNoBlindSpot(builder, NoBlindSpot);
			IStaticNoRenderPortal.AddTeleportLoadingEffectType(builder, TeleportLoadingEffect_type);
			IStaticNoRenderPortal.AddPortalModel(builder, PortalModel);
			IStaticNoRenderPortal.AddType(builder, Type);
			return IStaticNoRenderPortal.EndIStaticNoRenderPortal(builder);
		}

		// Token: 0x060294CC RID: 169164 RVA: 0x005A3300 File Offset: 0x005A1500
		public static void StartIStaticNoRenderPortal(FlatBufferBuilder builder)
		{
			builder.StartTable(16);
		}

		// Token: 0x060294CD RID: 169165 RVA: 0x005A330A File Offset: 0x005A150A
		public static void AddType(FlatBufferBuilder builder, ENoRenderPortalType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060294CE RID: 169166 RVA: 0x005A3315 File Offset: 0x005A1515
		public static void AddPortalModel(FlatBufferBuilder builder, EPortalModel portalModel)
		{
			builder.AddByte(1, (byte)portalModel, 0);
		}

		// Token: 0x060294CF RID: 169167 RVA: 0x005A3320 File Offset: 0x005A1520
		public static void AddLinkPortalEntityId(FlatBufferBuilder builder, int linkPortalEntityId)
		{
			builder.AddInt(2, linkPortalEntityId, 0);
		}

		// Token: 0x060294D0 RID: 169168 RVA: 0x005A332B File Offset: 0x005A152B
		public static void AddCubeMapBinding(FlatBufferBuilder builder, Offset<ICubeMapBinding> cubeMapBindingOffset)
		{
			builder.AddOffset(3, cubeMapBindingOffset.Value, 0);
		}

		// Token: 0x060294D1 RID: 169169 RVA: 0x005A333B File Offset: 0x005A153B
		public static void AddTeleportSceneEffect(FlatBufferBuilder builder, Offset<ITeleportSceneEffect> teleportSceneEffectOffset)
		{
			builder.AddOffset(4, teleportSceneEffectOffset.Value, 0);
		}

		// Token: 0x060294D2 RID: 169170 RVA: 0x005A334B File Offset: 0x005A154B
		public static void AddTeleportLoadingEffectType(FlatBufferBuilder builder, TTeleportTransitionOption teleportLoadingEffectType)
		{
			builder.AddByte(5, (byte)teleportLoadingEffectType, 0);
		}

		// Token: 0x060294D3 RID: 169171 RVA: 0x005A3356 File Offset: 0x005A1556
		public static void AddTeleportLoadingEffect(FlatBufferBuilder builder, int teleportLoadingEffectOffset)
		{
			builder.AddOffset(6, teleportLoadingEffectOffset, 0);
		}

		// Token: 0x060294D4 RID: 169172 RVA: 0x005A3361 File Offset: 0x005A1561
		public static void AddCondition(FlatBufferBuilder builder, Offset<IConditionGroup> conditionOffset)
		{
			builder.AddOffset(7, conditionOffset.Value, 0);
		}

		// Token: 0x060294D5 RID: 169173 RVA: 0x005A3371 File Offset: 0x005A1571
		public static void AddTeleportToSelfPos(FlatBufferBuilder builder, Offset<IVectorInfo> teleportToSelfPosOffset)
		{
			builder.AddOffset(8, teleportToSelfPosOffset.Value, 0);
		}

		// Token: 0x060294D6 RID: 169174 RVA: 0x005A3381 File Offset: 0x005A1581
		public static void AddGravityConfig(FlatBufferBuilder builder, Offset<IGravityFlipTeleportConfig> gravityConfigOffset)
		{
			builder.AddOffset(9, gravityConfigOffset.Value, 0);
		}

		// Token: 0x060294D7 RID: 169175 RVA: 0x005A3392 File Offset: 0x005A1592
		public static void AddNoBlindSpot(FlatBufferBuilder builder, bool noBlindSpot)
		{
			builder.AddBool(10, noBlindSpot, false);
		}

		// Token: 0x060294D8 RID: 169176 RVA: 0x005A339E File Offset: 0x005A159E
		public static void AddActionAfterTeleport(FlatBufferBuilder builder, ETeleportActionType actionAfterTeleport)
		{
			builder.AddByte(11, (byte)actionAfterTeleport, 0);
		}

		// Token: 0x060294D9 RID: 169177 RVA: 0x005A33AA File Offset: 0x005A15AA
		public static void AddNpcMonsterEntityIds(FlatBufferBuilder builder, VectorOffset npcMonsterEntityIdsOffset)
		{
			builder.AddOffset(12, npcMonsterEntityIdsOffset.Value, 0);
		}

		// Token: 0x060294DA RID: 169178 RVA: 0x005A33BC File Offset: 0x005A15BC
		public static VectorOffset CreateNpcMonsterEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060294DB RID: 169179 RVA: 0x005A33F3 File Offset: 0x005A15F3
		public static VectorOffset CreateNpcMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060294DC RID: 169180 RVA: 0x005A340D File Offset: 0x005A160D
		public static VectorOffset CreateNpcMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060294DD RID: 169181 RVA: 0x005A342B File Offset: 0x005A162B
		public static VectorOffset CreateNpcMonsterEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060294DE RID: 169182 RVA: 0x005A3444 File Offset: 0x005A1644
		public static void StartNpcMonsterEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060294DF RID: 169183 RVA: 0x005A344F File Offset: 0x005A164F
		public static void AddAfterTeleportConfig(FlatBufferBuilder builder, Offset<IAfterTeleportConfig> afterTeleportConfigOffset)
		{
			builder.AddOffset(13, afterTeleportConfigOffset.Value, 0);
		}

		// Token: 0x060294E0 RID: 169184 RVA: 0x005A3460 File Offset: 0x005A1660
		public static void AddTeleportStreamRadius(FlatBufferBuilder builder, int teleportStreamRadius)
		{
			builder.AddInt(14, teleportStreamRadius, 0);
		}

		// Token: 0x060294E1 RID: 169185 RVA: 0x005A346C File Offset: 0x005A166C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(15, nullMask, 0);
		}

		// Token: 0x060294E2 RID: 169186 RVA: 0x005A3478 File Offset: 0x005A1678
		public static Offset<IStaticNoRenderPortal> EndIStaticNoRenderPortal(FlatBufferBuilder builder)
		{
			return new Offset<IStaticNoRenderPortal>(builder.EndTable());
		}

		// Token: 0x060294E3 RID: 169187 RVA: 0x005A3488 File Offset: 0x005A1688
		public IStaticNoRenderPortalT UnPack()
		{
			IStaticNoRenderPortalT staticNoRenderPortalT = new IStaticNoRenderPortalT();
			this.UnPackTo(staticNoRenderPortalT);
			return staticNoRenderPortalT;
		}

		// Token: 0x060294E4 RID: 169188 RVA: 0x005A34A4 File Offset: 0x005A16A4
		public void UnPackTo(IStaticNoRenderPortalT _o)
		{
			_o.Type = this.Type;
			_o.PortalModel = this.PortalModel;
			_o.LinkPortalEntityId = this.LinkPortalEntityId;
			_o.CubeMapBinding = ((this.CubeMapBinding != null) ? this.CubeMapBinding.Value.UnPack() : null);
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

		// Token: 0x060294E5 RID: 169189 RVA: 0x005A3948 File Offset: 0x005A1B48
		public static Offset<IStaticNoRenderPortal> Pack(FlatBufferBuilder builder, IStaticNoRenderPortalT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStaticNoRenderPortal>);
			}
			Offset<ICubeMapBinding> cubeMapBindingOffset = (_o.CubeMapBinding == null) ? default(Offset<ICubeMapBinding>) : ICubeMapBinding.Pack(builder, _o.CubeMapBinding);
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
			return IStaticNoRenderPortal.CreateIStaticNoRenderPortal(builder, _o.Type, _o.PortalModel, _o.LinkPortalEntityId, cubeMapBindingOffset, teleportSceneEffectOffset, teleportLoadingEffect_type, teleportLoadingEffectOffset, conditionOffset, teleportToSelfPosOffset, gravityConfigOffset, _o.NoBlindSpot, _o.ActionAfterTeleport, npcMonsterEntityIdsOffset, afterTeleportConfigOffset, _o.TeleportStreamRadius, _o.NullMask);
		}

		// Token: 0x0400FCD6 RID: 64726
		private Table __p;
	}
}
