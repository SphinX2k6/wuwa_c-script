using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C2A RID: 23594
	public struct INpcUiInteractOnVillageInfr : IFlatbufferObject
	{
		// Token: 0x1700AD46 RID: 44358
		// (get) Token: 0x06027172 RID: 160114 RVA: 0x0055B0AB File Offset: 0x005592AB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027173 RID: 160115 RVA: 0x0055B0B8 File Offset: 0x005592B8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027174 RID: 160116 RVA: 0x0055B0C0 File Offset: 0x005592C0
		public static INpcUiInteractOnVillageInfr GetRootAsINpcUiInteractOnVillageInfr(ByteBuffer _bb)
		{
			return INpcUiInteractOnVillageInfr.GetRootAsINpcUiInteractOnVillageInfr(_bb, default(INpcUiInteractOnVillageInfr));
		}

		// Token: 0x06027175 RID: 160117 RVA: 0x0055B0DC File Offset: 0x005592DC
		public static INpcUiInteractOnVillageInfr GetRootAsINpcUiInteractOnVillageInfr(ByteBuffer _bb, INpcUiInteractOnVillageInfr obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027176 RID: 160118 RVA: 0x0055B0F9 File Offset: 0x005592F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027177 RID: 160119 RVA: 0x0055B108 File Offset: 0x00559308
		public INpcUiInteractOnVillageInfr __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD47 RID: 44359
		// (get) Token: 0x06027178 RID: 160120 RVA: 0x0055B118 File Offset: 0x00559318
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

		// Token: 0x1700AD48 RID: 44360
		// (get) Token: 0x06027179 RID: 160121 RVA: 0x0055B154 File Offset: 0x00559354
		public TMontageConfig EnterMontageType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TMontageConfig.NONE;
				}
				return (TMontageConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602717A RID: 160122 RVA: 0x0055B190 File Offset: 0x00559390
		public TTable? EnterMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602717B RID: 160123 RVA: 0x0055B1D4 File Offset: 0x005593D4
		public IMontageAsset EnterMontageAsIMontageAsset()
		{
			return this.EnterMontage<IMontageAsset>().Value;
		}

		// Token: 0x0602717C RID: 160124 RVA: 0x0055B1F0 File Offset: 0x005593F0
		public IMontageRegistered EnterMontageAsIMontageRegistered()
		{
			return this.EnterMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700AD49 RID: 44361
		// (get) Token: 0x0602717D RID: 160125 RVA: 0x0055B20C File Offset: 0x0055940C
		public TMontageConfig DeliverSuccessMontageType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TMontageConfig.NONE;
				}
				return (TMontageConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602717E RID: 160126 RVA: 0x0055B24C File Offset: 0x0055944C
		public TTable? DeliverSuccessMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602717F RID: 160127 RVA: 0x0055B294 File Offset: 0x00559494
		public IMontageAsset DeliverSuccessMontageAsIMontageAsset()
		{
			return this.DeliverSuccessMontage<IMontageAsset>().Value;
		}

		// Token: 0x06027180 RID: 160128 RVA: 0x0055B2B0 File Offset: 0x005594B0
		public IMontageRegistered DeliverSuccessMontageAsIMontageRegistered()
		{
			return this.DeliverSuccessMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700AD4A RID: 44362
		// (get) Token: 0x06027181 RID: 160129 RVA: 0x0055B2CC File Offset: 0x005594CC
		public TMontageConfig CompleteMontageType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return TMontageConfig.NONE;
				}
				return (TMontageConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027182 RID: 160130 RVA: 0x0055B30C File Offset: 0x0055950C
		public TTable? CompleteMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027183 RID: 160131 RVA: 0x0055B354 File Offset: 0x00559554
		public IMontageAsset CompleteMontageAsIMontageAsset()
		{
			return this.CompleteMontage<IMontageAsset>().Value;
		}

		// Token: 0x06027184 RID: 160132 RVA: 0x0055B370 File Offset: 0x00559570
		public IMontageRegistered CompleteMontageAsIMontageRegistered()
		{
			return this.CompleteMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700AD4B RID: 44363
		// (get) Token: 0x06027185 RID: 160133 RVA: 0x0055B38C File Offset: 0x0055958C
		public IPlayFlow? EnterFlow
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AD4C RID: 44364
		// (get) Token: 0x06027186 RID: 160134 RVA: 0x0055B3EC File Offset: 0x005595EC
		public IPlayFlow? DeliverSuccessFlow
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AD4D RID: 44365
		// (get) Token: 0x06027187 RID: 160135 RVA: 0x0055B44C File Offset: 0x0055964C
		public IPlayFlow? CompleteFlow
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06027188 RID: 160136 RVA: 0x0055B4AC File Offset: 0x005596AC
		public static Offset<INpcUiInteractOnVillageInfr> CreateINpcUiInteractOnVillageInfr(FlatBufferBuilder builder, ENpcUiInteractType Type = ENpcUiInteractType.HandInItem, TMontageConfig EnterMontage_type = TMontageConfig.NONE, int EnterMontageOffset = 0, TMontageConfig DeliverSuccessMontage_type = TMontageConfig.NONE, int DeliverSuccessMontageOffset = 0, TMontageConfig CompleteMontage_type = TMontageConfig.NONE, int CompleteMontageOffset = 0, Offset<IPlayFlow> EnterFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> DeliverSuccessFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> CompleteFlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(10);
			INpcUiInteractOnVillageInfr.AddCompleteFlow(builder, CompleteFlowOffset);
			INpcUiInteractOnVillageInfr.AddDeliverSuccessFlow(builder, DeliverSuccessFlowOffset);
			INpcUiInteractOnVillageInfr.AddEnterFlow(builder, EnterFlowOffset);
			INpcUiInteractOnVillageInfr.AddCompleteMontage(builder, CompleteMontageOffset);
			INpcUiInteractOnVillageInfr.AddDeliverSuccessMontage(builder, DeliverSuccessMontageOffset);
			INpcUiInteractOnVillageInfr.AddEnterMontage(builder, EnterMontageOffset);
			INpcUiInteractOnVillageInfr.AddCompleteMontageType(builder, CompleteMontage_type);
			INpcUiInteractOnVillageInfr.AddDeliverSuccessMontageType(builder, DeliverSuccessMontage_type);
			INpcUiInteractOnVillageInfr.AddEnterMontageType(builder, EnterMontage_type);
			INpcUiInteractOnVillageInfr.AddType(builder, Type);
			return INpcUiInteractOnVillageInfr.EndINpcUiInteractOnVillageInfr(builder);
		}

		// Token: 0x06027189 RID: 160137 RVA: 0x0055B514 File Offset: 0x00559714
		public static void StartINpcUiInteractOnVillageInfr(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0602718A RID: 160138 RVA: 0x0055B51E File Offset: 0x0055971E
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602718B RID: 160139 RVA: 0x0055B529 File Offset: 0x00559729
		public static void AddEnterMontageType(FlatBufferBuilder builder, TMontageConfig enterMontageType)
		{
			builder.AddByte(1, (byte)enterMontageType, 0);
		}

		// Token: 0x0602718C RID: 160140 RVA: 0x0055B534 File Offset: 0x00559734
		public static void AddEnterMontage(FlatBufferBuilder builder, int enterMontageOffset)
		{
			builder.AddOffset(2, enterMontageOffset, 0);
		}

		// Token: 0x0602718D RID: 160141 RVA: 0x0055B53F File Offset: 0x0055973F
		public static void AddDeliverSuccessMontageType(FlatBufferBuilder builder, TMontageConfig deliverSuccessMontageType)
		{
			builder.AddByte(3, (byte)deliverSuccessMontageType, 0);
		}

		// Token: 0x0602718E RID: 160142 RVA: 0x0055B54A File Offset: 0x0055974A
		public static void AddDeliverSuccessMontage(FlatBufferBuilder builder, int deliverSuccessMontageOffset)
		{
			builder.AddOffset(4, deliverSuccessMontageOffset, 0);
		}

		// Token: 0x0602718F RID: 160143 RVA: 0x0055B555 File Offset: 0x00559755
		public static void AddCompleteMontageType(FlatBufferBuilder builder, TMontageConfig completeMontageType)
		{
			builder.AddByte(5, (byte)completeMontageType, 0);
		}

		// Token: 0x06027190 RID: 160144 RVA: 0x0055B560 File Offset: 0x00559760
		public static void AddCompleteMontage(FlatBufferBuilder builder, int completeMontageOffset)
		{
			builder.AddOffset(6, completeMontageOffset, 0);
		}

		// Token: 0x06027191 RID: 160145 RVA: 0x0055B56B File Offset: 0x0055976B
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(7, enterFlowOffset.Value, 0);
		}

		// Token: 0x06027192 RID: 160146 RVA: 0x0055B57B File Offset: 0x0055977B
		public static void AddDeliverSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> deliverSuccessFlowOffset)
		{
			builder.AddOffset(8, deliverSuccessFlowOffset.Value, 0);
		}

		// Token: 0x06027193 RID: 160147 RVA: 0x0055B58B File Offset: 0x0055978B
		public static void AddCompleteFlow(FlatBufferBuilder builder, Offset<IPlayFlow> completeFlowOffset)
		{
			builder.AddOffset(9, completeFlowOffset.Value, 0);
		}

		// Token: 0x06027194 RID: 160148 RVA: 0x0055B59C File Offset: 0x0055979C
		public static Offset<INpcUiInteractOnVillageInfr> EndINpcUiInteractOnVillageInfr(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnVillageInfr>(builder.EndTable());
		}

		// Token: 0x06027195 RID: 160149 RVA: 0x0055B5AC File Offset: 0x005597AC
		public INpcUiInteractOnVillageInfrT UnPack()
		{
			INpcUiInteractOnVillageInfrT npcUiInteractOnVillageInfrT = new INpcUiInteractOnVillageInfrT();
			this.UnPackTo(npcUiInteractOnVillageInfrT);
			return npcUiInteractOnVillageInfrT;
		}

		// Token: 0x06027196 RID: 160150 RVA: 0x0055B5C8 File Offset: 0x005597C8
		public void UnPackTo(INpcUiInteractOnVillageInfrT _o)
		{
			_o.Type = this.Type;
			_o.EnterMontage = new TMontageConfigUnion();
			_o.EnterMontage.Type = this.EnterMontageType;
			TMontageConfig tmontageConfig = this.EnterMontageType;
			if (tmontageConfig != TMontageConfig.IMontageAsset)
			{
				if (tmontageConfig == TMontageConfig.IMontageRegistered)
				{
					_o.EnterMontage.Value = ((this.EnterMontage<IMontageRegistered>() != null) ? this.EnterMontage<IMontageRegistered>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.EnterMontage.Value = ((this.EnterMontage<IMontageAsset>() != null) ? this.EnterMontage<IMontageAsset>().Value.UnPack() : null);
			}
			_o.DeliverSuccessMontage = new TMontageConfigUnion();
			_o.DeliverSuccessMontage.Type = this.DeliverSuccessMontageType;
			tmontageConfig = this.DeliverSuccessMontageType;
			if (tmontageConfig != TMontageConfig.IMontageAsset)
			{
				if (tmontageConfig == TMontageConfig.IMontageRegistered)
				{
					_o.DeliverSuccessMontage.Value = ((this.DeliverSuccessMontage<IMontageRegistered>() != null) ? this.DeliverSuccessMontage<IMontageRegistered>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.DeliverSuccessMontage.Value = ((this.DeliverSuccessMontage<IMontageAsset>() != null) ? this.DeliverSuccessMontage<IMontageAsset>().Value.UnPack() : null);
			}
			_o.CompleteMontage = new TMontageConfigUnion();
			_o.CompleteMontage.Type = this.CompleteMontageType;
			tmontageConfig = this.CompleteMontageType;
			if (tmontageConfig != TMontageConfig.IMontageAsset)
			{
				if (tmontageConfig == TMontageConfig.IMontageRegistered)
				{
					_o.CompleteMontage.Value = ((this.CompleteMontage<IMontageRegistered>() != null) ? this.CompleteMontage<IMontageRegistered>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.CompleteMontage.Value = ((this.CompleteMontage<IMontageAsset>() != null) ? this.CompleteMontage<IMontageAsset>().Value.UnPack() : null);
			}
			_o.EnterFlow = ((this.EnterFlow != null) ? this.EnterFlow.Value.UnPack() : null);
			_o.DeliverSuccessFlow = ((this.DeliverSuccessFlow != null) ? this.DeliverSuccessFlow.Value.UnPack() : null);
			_o.CompleteFlow = ((this.CompleteFlow != null) ? this.CompleteFlow.Value.UnPack() : null);
		}

		// Token: 0x06027197 RID: 160151 RVA: 0x0055B840 File Offset: 0x00559A40
		public static Offset<INpcUiInteractOnVillageInfr> Pack(FlatBufferBuilder builder, INpcUiInteractOnVillageInfrT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcUiInteractOnVillageInfr>);
			}
			TMontageConfig enterMontage_type = (_o.EnterMontage == null) ? TMontageConfig.NONE : _o.EnterMontage.Type;
			int enterMontageOffset = (_o.EnterMontage == null) ? 0 : TMontageConfigUnion.Pack(builder, _o.EnterMontage);
			TMontageConfig deliverSuccessMontage_type = (_o.DeliverSuccessMontage == null) ? TMontageConfig.NONE : _o.DeliverSuccessMontage.Type;
			int deliverSuccessMontageOffset = (_o.DeliverSuccessMontage == null) ? 0 : TMontageConfigUnion.Pack(builder, _o.DeliverSuccessMontage);
			TMontageConfig completeMontage_type = (_o.CompleteMontage == null) ? TMontageConfig.NONE : _o.CompleteMontage.Type;
			int completeMontageOffset = (_o.CompleteMontage == null) ? 0 : TMontageConfigUnion.Pack(builder, _o.CompleteMontage);
			Offset<IPlayFlow> enterFlowOffset = (_o.EnterFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.EnterFlow);
			Offset<IPlayFlow> deliverSuccessFlowOffset = (_o.DeliverSuccessFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.DeliverSuccessFlow);
			Offset<IPlayFlow> completeFlowOffset = (_o.CompleteFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.CompleteFlow);
			return INpcUiInteractOnVillageInfr.CreateINpcUiInteractOnVillageInfr(builder, _o.Type, enterMontage_type, enterMontageOffset, deliverSuccessMontage_type, deliverSuccessMontageOffset, completeMontage_type, completeMontageOffset, enterFlowOffset, deliverSuccessFlowOffset, completeFlowOffset);
		}

		// Token: 0x0400F701 RID: 63233
		private Table __p;
	}
}
