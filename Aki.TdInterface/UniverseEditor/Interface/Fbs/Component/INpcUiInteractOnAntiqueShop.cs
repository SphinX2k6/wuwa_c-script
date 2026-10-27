using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200566B RID: 22123
	public struct INpcUiInteractOnAntiqueShop : IFlatbufferObject
	{
		// Token: 0x1700A3F3 RID: 41971
		// (get) Token: 0x06024CD7 RID: 150743 RVA: 0x00513EFC File Offset: 0x005120FC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024CD8 RID: 150744 RVA: 0x00513F09 File Offset: 0x00512109
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024CD9 RID: 150745 RVA: 0x00513F10 File Offset: 0x00512110
		public static INpcUiInteractOnAntiqueShop GetRootAsINpcUiInteractOnAntiqueShop(ByteBuffer _bb)
		{
			return INpcUiInteractOnAntiqueShop.GetRootAsINpcUiInteractOnAntiqueShop(_bb, default(INpcUiInteractOnAntiqueShop));
		}

		// Token: 0x06024CDA RID: 150746 RVA: 0x00513F2C File Offset: 0x0051212C
		public static INpcUiInteractOnAntiqueShop GetRootAsINpcUiInteractOnAntiqueShop(ByteBuffer _bb, INpcUiInteractOnAntiqueShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024CDB RID: 150747 RVA: 0x00513F49 File Offset: 0x00512149
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024CDC RID: 150748 RVA: 0x00513F58 File Offset: 0x00512158
		public INpcUiInteractOnAntiqueShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3F4 RID: 41972
		// (get) Token: 0x06024CDD RID: 150749 RVA: 0x00513F68 File Offset: 0x00512168
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

		// Token: 0x1700A3F5 RID: 41973
		// (get) Token: 0x06024CDE RID: 150750 RVA: 0x00513FA4 File Offset: 0x005121A4
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

		// Token: 0x06024CDF RID: 150751 RVA: 0x00513FDB File Offset: 0x005121DB
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024CE0 RID: 150752 RVA: 0x00513FEA File Offset: 0x005121EA
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A3F6 RID: 41974
		// (get) Token: 0x06024CE1 RID: 150753 RVA: 0x00513FF8 File Offset: 0x005121F8
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

		// Token: 0x06024CE2 RID: 150754 RVA: 0x0051402F File Offset: 0x0051222F
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06024CE3 RID: 150755 RVA: 0x0051403E File Offset: 0x0051223E
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A3F7 RID: 41975
		// (get) Token: 0x06024CE4 RID: 150756 RVA: 0x0051404C File Offset: 0x0051224C
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

		// Token: 0x06024CE5 RID: 150757 RVA: 0x00514084 File Offset: 0x00512284
		public Span<byte> GetShopSuccessMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06024CE6 RID: 150758 RVA: 0x00514094 File Offset: 0x00512294
		public byte[] GetShopSuccessMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A3F8 RID: 41976
		// (get) Token: 0x06024CE7 RID: 150759 RVA: 0x005140A4 File Offset: 0x005122A4
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

		// Token: 0x1700A3F9 RID: 41977
		// (get) Token: 0x06024CE8 RID: 150760 RVA: 0x00514104 File Offset: 0x00512304
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

		// Token: 0x1700A3FA RID: 41978
		// (get) Token: 0x06024CE9 RID: 150761 RVA: 0x00514164 File Offset: 0x00512364
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

		// Token: 0x1700A3FB RID: 41979
		// (get) Token: 0x06024CEA RID: 150762 RVA: 0x005141C4 File Offset: 0x005123C4
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

		// Token: 0x06024CEB RID: 150763 RVA: 0x005141FC File Offset: 0x005123FC
		public Span<byte> GetUpgradeSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06024CEC RID: 150764 RVA: 0x0051420C File Offset: 0x0051240C
		public byte[] GetUpgradeSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700A3FC RID: 41980
		// (get) Token: 0x06024CED RID: 150765 RVA: 0x0051421C File Offset: 0x0051241C
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

		// Token: 0x06024CEE RID: 150766 RVA: 0x0051425C File Offset: 0x0051245C
		public TTable? ExitMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024CEF RID: 150767 RVA: 0x005142A4 File Offset: 0x005124A4
		public IMontageAsset ExitMontageAsIMontageAsset()
		{
			return this.ExitMontage<IMontageAsset>().Value;
		}

		// Token: 0x06024CF0 RID: 150768 RVA: 0x005142C0 File Offset: 0x005124C0
		public IMontageRegistered ExitMontageAsIMontageRegistered()
		{
			return this.ExitMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700A3FD RID: 41981
		// (get) Token: 0x06024CF1 RID: 150769 RVA: 0x005142DC File Offset: 0x005124DC
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

		// Token: 0x06024CF2 RID: 150770 RVA: 0x0051433C File Offset: 0x0051253C
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

		// Token: 0x06024CF3 RID: 150771 RVA: 0x005143AC File Offset: 0x005125AC
		public static void StartINpcUiInteractOnAntiqueShop(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06024CF4 RID: 150772 RVA: 0x005143B6 File Offset: 0x005125B6
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024CF5 RID: 150773 RVA: 0x005143C1 File Offset: 0x005125C1
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x06024CF6 RID: 150774 RVA: 0x005143D1 File Offset: 0x005125D1
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x06024CF7 RID: 150775 RVA: 0x005143E1 File Offset: 0x005125E1
		public static void AddShopSuccessMontage(FlatBufferBuilder builder, StringOffset shopSuccessMontageOffset)
		{
			builder.AddOffset(3, shopSuccessMontageOffset.Value, 0);
		}

		// Token: 0x06024CF8 RID: 150776 RVA: 0x005143F1 File Offset: 0x005125F1
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(4, enterFlowOffset.Value, 0);
		}

		// Token: 0x06024CF9 RID: 150777 RVA: 0x00514401 File Offset: 0x00512601
		public static void AddShopSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopSuccessFlowOffset)
		{
			builder.AddOffset(5, shopSuccessFlowOffset.Value, 0);
		}

		// Token: 0x06024CFA RID: 150778 RVA: 0x00514411 File Offset: 0x00512611
		public static void AddShopFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopFailedFlowOffset)
		{
			builder.AddOffset(6, shopFailedFlowOffset.Value, 0);
		}

		// Token: 0x06024CFB RID: 150779 RVA: 0x00514421 File Offset: 0x00512621
		public static void AddUpgradeSequence(FlatBufferBuilder builder, StringOffset upgradeSequenceOffset)
		{
			builder.AddOffset(7, upgradeSequenceOffset.Value, 0);
		}

		// Token: 0x06024CFC RID: 150780 RVA: 0x00514431 File Offset: 0x00512631
		public static void AddExitMontageType(FlatBufferBuilder builder, TMontageConfig exitMontageType)
		{
			builder.AddByte(8, (byte)exitMontageType, 0);
		}

		// Token: 0x06024CFD RID: 150781 RVA: 0x0051443C File Offset: 0x0051263C
		public static void AddExitMontage(FlatBufferBuilder builder, int exitMontageOffset)
		{
			builder.AddOffset(9, exitMontageOffset, 0);
		}

		// Token: 0x06024CFE RID: 150782 RVA: 0x00514448 File Offset: 0x00512648
		public static void AddExitFlow(FlatBufferBuilder builder, Offset<IPlayFlow> exitFlowOffset)
		{
			builder.AddOffset(10, exitFlowOffset.Value, 0);
		}

		// Token: 0x06024CFF RID: 150783 RVA: 0x00514459 File Offset: 0x00512659
		public static Offset<INpcUiInteractOnAntiqueShop> EndINpcUiInteractOnAntiqueShop(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnAntiqueShop>(builder.EndTable());
		}

		// Token: 0x06024D00 RID: 150784 RVA: 0x00514468 File Offset: 0x00512668
		public INpcUiInteractOnAntiqueShopT UnPack()
		{
			INpcUiInteractOnAntiqueShopT npcUiInteractOnAntiqueShopT = new INpcUiInteractOnAntiqueShopT();
			this.UnPackTo(npcUiInteractOnAntiqueShopT);
			return npcUiInteractOnAntiqueShopT;
		}

		// Token: 0x06024D01 RID: 150785 RVA: 0x00514484 File Offset: 0x00512684
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

		// Token: 0x06024D02 RID: 150786 RVA: 0x00514624 File Offset: 0x00512824
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

		// Token: 0x0400EA31 RID: 59953
		private Table __p;
	}
}
