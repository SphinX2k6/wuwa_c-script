using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005689 RID: 22153
	public struct INpcUiInteractOnVillageInfr : IFlatbufferObject
	{
		// Token: 0x1700A4B7 RID: 42167
		// (get) Token: 0x06024F39 RID: 151353 RVA: 0x0051A50F File Offset: 0x0051870F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024F3A RID: 151354 RVA: 0x0051A51C File Offset: 0x0051871C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024F3B RID: 151355 RVA: 0x0051A524 File Offset: 0x00518724
		public static INpcUiInteractOnVillageInfr GetRootAsINpcUiInteractOnVillageInfr(ByteBuffer _bb)
		{
			return INpcUiInteractOnVillageInfr.GetRootAsINpcUiInteractOnVillageInfr(_bb, default(INpcUiInteractOnVillageInfr));
		}

		// Token: 0x06024F3C RID: 151356 RVA: 0x0051A540 File Offset: 0x00518740
		public static INpcUiInteractOnVillageInfr GetRootAsINpcUiInteractOnVillageInfr(ByteBuffer _bb, INpcUiInteractOnVillageInfr obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024F3D RID: 151357 RVA: 0x0051A55D File Offset: 0x0051875D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024F3E RID: 151358 RVA: 0x0051A56C File Offset: 0x0051876C
		public INpcUiInteractOnVillageInfr __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4B8 RID: 42168
		// (get) Token: 0x06024F3F RID: 151359 RVA: 0x0051A57C File Offset: 0x0051877C
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

		// Token: 0x1700A4B9 RID: 42169
		// (get) Token: 0x06024F40 RID: 151360 RVA: 0x0051A5B8 File Offset: 0x005187B8
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

		// Token: 0x06024F41 RID: 151361 RVA: 0x0051A5F4 File Offset: 0x005187F4
		public TTable? EnterMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024F42 RID: 151362 RVA: 0x0051A638 File Offset: 0x00518838
		public IMontageAsset EnterMontageAsIMontageAsset()
		{
			return this.EnterMontage<IMontageAsset>().Value;
		}

		// Token: 0x06024F43 RID: 151363 RVA: 0x0051A654 File Offset: 0x00518854
		public IMontageRegistered EnterMontageAsIMontageRegistered()
		{
			return this.EnterMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700A4BA RID: 42170
		// (get) Token: 0x06024F44 RID: 151364 RVA: 0x0051A670 File Offset: 0x00518870
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

		// Token: 0x06024F45 RID: 151365 RVA: 0x0051A6B0 File Offset: 0x005188B0
		public TTable? DeliverSuccessMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024F46 RID: 151366 RVA: 0x0051A6F8 File Offset: 0x005188F8
		public IMontageAsset DeliverSuccessMontageAsIMontageAsset()
		{
			return this.DeliverSuccessMontage<IMontageAsset>().Value;
		}

		// Token: 0x06024F47 RID: 151367 RVA: 0x0051A714 File Offset: 0x00518914
		public IMontageRegistered DeliverSuccessMontageAsIMontageRegistered()
		{
			return this.DeliverSuccessMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700A4BB RID: 42171
		// (get) Token: 0x06024F48 RID: 151368 RVA: 0x0051A730 File Offset: 0x00518930
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

		// Token: 0x06024F49 RID: 151369 RVA: 0x0051A770 File Offset: 0x00518970
		public TTable? CompleteMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024F4A RID: 151370 RVA: 0x0051A7B8 File Offset: 0x005189B8
		public IMontageAsset CompleteMontageAsIMontageAsset()
		{
			return this.CompleteMontage<IMontageAsset>().Value;
		}

		// Token: 0x06024F4B RID: 151371 RVA: 0x0051A7D4 File Offset: 0x005189D4
		public IMontageRegistered CompleteMontageAsIMontageRegistered()
		{
			return this.CompleteMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700A4BC RID: 42172
		// (get) Token: 0x06024F4C RID: 151372 RVA: 0x0051A7F0 File Offset: 0x005189F0
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

		// Token: 0x1700A4BD RID: 42173
		// (get) Token: 0x06024F4D RID: 151373 RVA: 0x0051A850 File Offset: 0x00518A50
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

		// Token: 0x1700A4BE RID: 42174
		// (get) Token: 0x06024F4E RID: 151374 RVA: 0x0051A8B0 File Offset: 0x00518AB0
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

		// Token: 0x06024F4F RID: 151375 RVA: 0x0051A910 File Offset: 0x00518B10
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

		// Token: 0x06024F50 RID: 151376 RVA: 0x0051A978 File Offset: 0x00518B78
		public static void StartINpcUiInteractOnVillageInfr(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06024F51 RID: 151377 RVA: 0x0051A982 File Offset: 0x00518B82
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024F52 RID: 151378 RVA: 0x0051A98D File Offset: 0x00518B8D
		public static void AddEnterMontageType(FlatBufferBuilder builder, TMontageConfig enterMontageType)
		{
			builder.AddByte(1, (byte)enterMontageType, 0);
		}

		// Token: 0x06024F53 RID: 151379 RVA: 0x0051A998 File Offset: 0x00518B98
		public static void AddEnterMontage(FlatBufferBuilder builder, int enterMontageOffset)
		{
			builder.AddOffset(2, enterMontageOffset, 0);
		}

		// Token: 0x06024F54 RID: 151380 RVA: 0x0051A9A3 File Offset: 0x00518BA3
		public static void AddDeliverSuccessMontageType(FlatBufferBuilder builder, TMontageConfig deliverSuccessMontageType)
		{
			builder.AddByte(3, (byte)deliverSuccessMontageType, 0);
		}

		// Token: 0x06024F55 RID: 151381 RVA: 0x0051A9AE File Offset: 0x00518BAE
		public static void AddDeliverSuccessMontage(FlatBufferBuilder builder, int deliverSuccessMontageOffset)
		{
			builder.AddOffset(4, deliverSuccessMontageOffset, 0);
		}

		// Token: 0x06024F56 RID: 151382 RVA: 0x0051A9B9 File Offset: 0x00518BB9
		public static void AddCompleteMontageType(FlatBufferBuilder builder, TMontageConfig completeMontageType)
		{
			builder.AddByte(5, (byte)completeMontageType, 0);
		}

		// Token: 0x06024F57 RID: 151383 RVA: 0x0051A9C4 File Offset: 0x00518BC4
		public static void AddCompleteMontage(FlatBufferBuilder builder, int completeMontageOffset)
		{
			builder.AddOffset(6, completeMontageOffset, 0);
		}

		// Token: 0x06024F58 RID: 151384 RVA: 0x0051A9CF File Offset: 0x00518BCF
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(7, enterFlowOffset.Value, 0);
		}

		// Token: 0x06024F59 RID: 151385 RVA: 0x0051A9DF File Offset: 0x00518BDF
		public static void AddDeliverSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> deliverSuccessFlowOffset)
		{
			builder.AddOffset(8, deliverSuccessFlowOffset.Value, 0);
		}

		// Token: 0x06024F5A RID: 151386 RVA: 0x0051A9EF File Offset: 0x00518BEF
		public static void AddCompleteFlow(FlatBufferBuilder builder, Offset<IPlayFlow> completeFlowOffset)
		{
			builder.AddOffset(9, completeFlowOffset.Value, 0);
		}

		// Token: 0x06024F5B RID: 151387 RVA: 0x0051AA00 File Offset: 0x00518C00
		public static Offset<INpcUiInteractOnVillageInfr> EndINpcUiInteractOnVillageInfr(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnVillageInfr>(builder.EndTable());
		}

		// Token: 0x06024F5C RID: 151388 RVA: 0x0051AA10 File Offset: 0x00518C10
		public INpcUiInteractOnVillageInfrT UnPack()
		{
			INpcUiInteractOnVillageInfrT npcUiInteractOnVillageInfrT = new INpcUiInteractOnVillageInfrT();
			this.UnPackTo(npcUiInteractOnVillageInfrT);
			return npcUiInteractOnVillageInfrT;
		}

		// Token: 0x06024F5D RID: 151389 RVA: 0x0051AA2C File Offset: 0x00518C2C
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

		// Token: 0x06024F5E RID: 151390 RVA: 0x0051ACA4 File Offset: 0x00518EA4
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

		// Token: 0x0400EA98 RID: 60056
		private Table __p;
	}
}
