using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C0C RID: 23564
	public struct INpcUiInteractOnAntiqueShop : IFlatbufferObject
	{
		// Token: 0x1700AC82 RID: 44162
		// (get) Token: 0x06026F10 RID: 159504 RVA: 0x00554A98 File Offset: 0x00552C98
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026F11 RID: 159505 RVA: 0x00554AA5 File Offset: 0x00552CA5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026F12 RID: 159506 RVA: 0x00554AAC File Offset: 0x00552CAC
		public static INpcUiInteractOnAntiqueShop GetRootAsINpcUiInteractOnAntiqueShop(ByteBuffer _bb)
		{
			return INpcUiInteractOnAntiqueShop.GetRootAsINpcUiInteractOnAntiqueShop(_bb, default(INpcUiInteractOnAntiqueShop));
		}

		// Token: 0x06026F13 RID: 159507 RVA: 0x00554AC8 File Offset: 0x00552CC8
		public static INpcUiInteractOnAntiqueShop GetRootAsINpcUiInteractOnAntiqueShop(ByteBuffer _bb, INpcUiInteractOnAntiqueShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026F14 RID: 159508 RVA: 0x00554AE5 File Offset: 0x00552CE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026F15 RID: 159509 RVA: 0x00554AF4 File Offset: 0x00552CF4
		public INpcUiInteractOnAntiqueShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC83 RID: 44163
		// (get) Token: 0x06026F16 RID: 159510 RVA: 0x00554B04 File Offset: 0x00552D04
		public ENpcUiInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcUiInteractType.HandInItem;
				}
				return (ENpcUiInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AC84 RID: 44164
		// (get) Token: 0x06026F17 RID: 159511 RVA: 0x00554B40 File Offset: 0x00552D40
		public string EnterMontage
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026F18 RID: 159512 RVA: 0x00554B77 File Offset: 0x00552D77
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06026F19 RID: 159513 RVA: 0x00554B86 File Offset: 0x00552D86
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AC85 RID: 44165
		// (get) Token: 0x06026F1A RID: 159514 RVA: 0x00554B94 File Offset: 0x00552D94
		public string StandByMontage
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026F1B RID: 159515 RVA: 0x00554BCB File Offset: 0x00552DCB
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06026F1C RID: 159516 RVA: 0x00554BDA File Offset: 0x00552DDA
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700AC86 RID: 44166
		// (get) Token: 0x06026F1D RID: 159517 RVA: 0x00554BE8 File Offset: 0x00552DE8
		public string ShopSuccessMontage
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026F1E RID: 159518 RVA: 0x00554C20 File Offset: 0x00552E20
		public Span<byte> GetShopSuccessMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06026F1F RID: 159519 RVA: 0x00554C30 File Offset: 0x00552E30
		public byte[] GetShopSuccessMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700AC87 RID: 44167
		// (get) Token: 0x06026F20 RID: 159520 RVA: 0x00554C40 File Offset: 0x00552E40
		public IPlayFlow? EnterFlow
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC88 RID: 44168
		// (get) Token: 0x06026F21 RID: 159521 RVA: 0x00554CA0 File Offset: 0x00552EA0
		public IPlayFlow? ShopSuccessFlow
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC89 RID: 44169
		// (get) Token: 0x06026F22 RID: 159522 RVA: 0x00554D00 File Offset: 0x00552F00
		public IPlayFlow? ShopFailedFlow
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC8A RID: 44170
		// (get) Token: 0x06026F23 RID: 159523 RVA: 0x00554D60 File Offset: 0x00552F60
		public string UpgradeSequence
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026F24 RID: 159524 RVA: 0x00554D98 File Offset: 0x00552F98
		public Span<byte> GetUpgradeSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06026F25 RID: 159525 RVA: 0x00554DA8 File Offset: 0x00552FA8
		public byte[] GetUpgradeSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700AC8B RID: 44171
		// (get) Token: 0x06026F26 RID: 159526 RVA: 0x00554DB8 File Offset: 0x00552FB8
		public TMontageConfig ExitMontageType
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return TMontageConfig.NONE;
				}
				return (TMontageConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026F27 RID: 159527 RVA: 0x00554DF8 File Offset: 0x00552FF8
		public TTable? ExitMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06026F28 RID: 159528 RVA: 0x00554E40 File Offset: 0x00553040
		public IMontageAsset ExitMontageAsIMontageAsset()
		{
			return this.ExitMontage<IMontageAsset>().Value;
		}

		// Token: 0x06026F29 RID: 159529 RVA: 0x00554E5C File Offset: 0x0055305C
		public IMontageRegistered ExitMontageAsIMontageRegistered()
		{
			return this.ExitMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700AC8C RID: 44172
		// (get) Token: 0x06026F2A RID: 159530 RVA: 0x00554E78 File Offset: 0x00553078
		public IPlayFlow? ExitFlow
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06026F2B RID: 159531 RVA: 0x00554ED8 File Offset: 0x005530D8
		public static Offset<INpcUiInteractOnAntiqueShop> CreateINpcUiInteractOnAntiqueShop(FlatBufferBuilder builder, ENpcUiInteractType Type = ENpcUiInteractType.HandInItem, StringOffset EnterMontageOffset = default(StringOffset), StringOffset StandByMontageOffset = default(StringOffset), StringOffset ShopSuccessMontageOffset = default(StringOffset), Offset<IPlayFlow> EnterFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> ShopSuccessFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> ShopFailedFlowOffset = default(Offset<IPlayFlow>), StringOffset UpgradeSequenceOffset = default(StringOffset), TMontageConfig ExitMontage_type = TMontageConfig.NONE, int ExitMontageOffset = 0, Offset<IPlayFlow> ExitFlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(11);
			INpcUiInteractOnAntiqueShop.AddExitFlow(builder, ExitFlowOffset);
			INpcUiInteractOnAntiqueShop.AddExitMontage(builder, ExitMontageOffset);
			INpcUiInteractOnAntiqueShop.AddUpgradeSequence(builder, UpgradeSequenceOffset);
			INpcUiInteractOnAntiqueShop.AddShopFailedFlow(builder, ShopFailedFlowOffset);
			INpcUiInteractOnAntiqueShop.AddShopSuccessFlow(builder, ShopSuccessFlowOffset);
			INpcUiInteractOnAntiqueShop.AddEnterFlow(builder, EnterFlowOffset);
			INpcUiInteractOnAntiqueShop.AddShopSuccessMontage(builder, ShopSuccessMontageOffset);
			INpcUiInteractOnAntiqueShop.AddStandByMontage(builder, StandByMontageOffset);
			INpcUiInteractOnAntiqueShop.AddEnterMontage(builder, EnterMontageOffset);
			INpcUiInteractOnAntiqueShop.AddExitMontageType(builder, ExitMontage_type);
			INpcUiInteractOnAntiqueShop.AddType(builder, Type);
			return INpcUiInteractOnAntiqueShop.EndINpcUiInteractOnAntiqueShop(builder);
		}

		// Token: 0x06026F2C RID: 159532 RVA: 0x00554F48 File Offset: 0x00553148
		public static void StartINpcUiInteractOnAntiqueShop(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06026F2D RID: 159533 RVA: 0x00554F52 File Offset: 0x00553152
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026F2E RID: 159534 RVA: 0x00554F5D File Offset: 0x0055315D
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x06026F2F RID: 159535 RVA: 0x00554F6D File Offset: 0x0055316D
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x06026F30 RID: 159536 RVA: 0x00554F7D File Offset: 0x0055317D
		public static void AddShopSuccessMontage(FlatBufferBuilder builder, StringOffset shopSuccessMontageOffset)
		{
			builder.AddOffset(3, shopSuccessMontageOffset.Value, 0);
		}

		// Token: 0x06026F31 RID: 159537 RVA: 0x00554F8D File Offset: 0x0055318D
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(4, enterFlowOffset.Value, 0);
		}

		// Token: 0x06026F32 RID: 159538 RVA: 0x00554F9D File Offset: 0x0055319D
		public static void AddShopSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopSuccessFlowOffset)
		{
			builder.AddOffset(5, shopSuccessFlowOffset.Value, 0);
		}

		// Token: 0x06026F33 RID: 159539 RVA: 0x00554FAD File Offset: 0x005531AD
		public static void AddShopFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopFailedFlowOffset)
		{
			builder.AddOffset(6, shopFailedFlowOffset.Value, 0);
		}

		// Token: 0x06026F34 RID: 159540 RVA: 0x00554FBD File Offset: 0x005531BD
		public static void AddUpgradeSequence(FlatBufferBuilder builder, StringOffset upgradeSequenceOffset)
		{
			builder.AddOffset(7, upgradeSequenceOffset.Value, 0);
		}

		// Token: 0x06026F35 RID: 159541 RVA: 0x00554FCD File Offset: 0x005531CD
		public static void AddExitMontageType(FlatBufferBuilder builder, TMontageConfig exitMontageType)
		{
			builder.AddByte(8, (byte)exitMontageType, 0);
		}

		// Token: 0x06026F36 RID: 159542 RVA: 0x00554FD8 File Offset: 0x005531D8
		public static void AddExitMontage(FlatBufferBuilder builder, int exitMontageOffset)
		{
			builder.AddOffset(9, exitMontageOffset, 0);
		}

		// Token: 0x06026F37 RID: 159543 RVA: 0x00554FE4 File Offset: 0x005531E4
		public static void AddExitFlow(FlatBufferBuilder builder, Offset<IPlayFlow> exitFlowOffset)
		{
			builder.AddOffset(10, exitFlowOffset.Value, 0);
		}

		// Token: 0x06026F38 RID: 159544 RVA: 0x00554FF5 File Offset: 0x005531F5
		public static Offset<INpcUiInteractOnAntiqueShop> EndINpcUiInteractOnAntiqueShop(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnAntiqueShop>(builder.EndTable());
		}

		// Token: 0x06026F39 RID: 159545 RVA: 0x00555004 File Offset: 0x00553204
		public INpcUiInteractOnAntiqueShopT UnPack()
		{
			INpcUiInteractOnAntiqueShopT npcUiInteractOnAntiqueShopT = new INpcUiInteractOnAntiqueShopT();
			this.UnPackTo(npcUiInteractOnAntiqueShopT);
			return npcUiInteractOnAntiqueShopT;
		}

		// Token: 0x06026F3A RID: 159546 RVA: 0x00555020 File Offset: 0x00553220
		public void UnPackTo(INpcUiInteractOnAntiqueShopT _o)
		{
			_o.Type = this.Type;
			_o.EnterMontage = this.EnterMontage;
			_o.StandByMontage = this.StandByMontage;
			_o.ShopSuccessMontage = this.ShopSuccessMontage;
			_o.EnterFlow = ((this.EnterFlow != null) ? this.EnterFlow.Value.UnPack() : null);
			_o.ShopSuccessFlow = ((this.ShopSuccessFlow != null) ? this.ShopSuccessFlow.Value.UnPack() : null);
			_o.ShopFailedFlow = ((this.ShopFailedFlow != null) ? this.ShopFailedFlow.Value.UnPack() : null);
			_o.UpgradeSequence = this.UpgradeSequence;
			_o.ExitMontage = new TMontageConfigUnion();
			_o.ExitMontage.Type = this.ExitMontageType;
			TMontageConfig exitMontageType = this.ExitMontageType;
			if (exitMontageType != TMontageConfig.IMontageAsset)
			{
				if (exitMontageType == TMontageConfig.IMontageRegistered)
				{
					_o.ExitMontage.Value = ((this.ExitMontage<IMontageRegistered>() != null) ? this.ExitMontage<IMontageRegistered>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.ExitMontage.Value = ((this.ExitMontage<IMontageAsset>() != null) ? this.ExitMontage<IMontageAsset>().Value.UnPack() : null);
			}
			_o.ExitFlow = ((this.ExitFlow != null) ? this.ExitFlow.Value.UnPack() : null);
		}

		// Token: 0x06026F3B RID: 159547 RVA: 0x005551C0 File Offset: 0x005533C0
		public static Offset<INpcUiInteractOnAntiqueShop> Pack(FlatBufferBuilder builder, INpcUiInteractOnAntiqueShopT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcUiInteractOnAntiqueShop>);
			}
			StringOffset enterMontageOffset = (_o.EnterMontage == null) ? default(StringOffset) : builder.CreateString(_o.EnterMontage);
			StringOffset standByMontageOffset = (_o.StandByMontage == null) ? default(StringOffset) : builder.CreateString(_o.StandByMontage);
			StringOffset shopSuccessMontageOffset = (_o.ShopSuccessMontage == null) ? default(StringOffset) : builder.CreateString(_o.ShopSuccessMontage);
			Offset<IPlayFlow> enterFlowOffset = (_o.EnterFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.EnterFlow);
			Offset<IPlayFlow> shopSuccessFlowOffset = (_o.ShopSuccessFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.ShopSuccessFlow);
			Offset<IPlayFlow> shopFailedFlowOffset = (_o.ShopFailedFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.ShopFailedFlow);
			StringOffset upgradeSequenceOffset = (_o.UpgradeSequence == null) ? default(StringOffset) : builder.CreateString(_o.UpgradeSequence);
			TMontageConfig exitMontage_type = (_o.ExitMontage == null) ? TMontageConfig.NONE : _o.ExitMontage.Type;
			int exitMontageOffset = (_o.ExitMontage == null) ? 0 : TMontageConfigUnion.Pack(builder, _o.ExitMontage);
			Offset<IPlayFlow> exitFlowOffset = (_o.ExitFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.ExitFlow);
			return INpcUiInteractOnAntiqueShop.CreateINpcUiInteractOnAntiqueShop(builder, _o.Type, enterMontageOffset, standByMontageOffset, shopSuccessMontageOffset, enterFlowOffset, shopSuccessFlowOffset, shopFailedFlowOffset, upgradeSequenceOffset, exitMontage_type, exitMontageOffset, exitFlowOffset);
		}

		// Token: 0x0400F69A RID: 63130
		private Table __p;
	}
}
