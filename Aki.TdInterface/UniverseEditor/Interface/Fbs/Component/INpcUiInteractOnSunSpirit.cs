using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005686 RID: 22150
	public struct INpcUiInteractOnSunSpirit : IFlatbufferObject
	{
		// Token: 0x1700A4A0 RID: 42144
		// (get) Token: 0x06024EF3 RID: 151283 RVA: 0x00519917 File Offset: 0x00517B17
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024EF4 RID: 151284 RVA: 0x00519924 File Offset: 0x00517B24
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024EF5 RID: 151285 RVA: 0x0051992C File Offset: 0x00517B2C
		public static INpcUiInteractOnSunSpirit GetRootAsINpcUiInteractOnSunSpirit(ByteBuffer _bb)
		{
			return INpcUiInteractOnSunSpirit.GetRootAsINpcUiInteractOnSunSpirit(_bb, default(INpcUiInteractOnSunSpirit));
		}

		// Token: 0x06024EF6 RID: 151286 RVA: 0x00519948 File Offset: 0x00517B48
		public static INpcUiInteractOnSunSpirit GetRootAsINpcUiInteractOnSunSpirit(ByteBuffer _bb, INpcUiInteractOnSunSpirit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024EF7 RID: 151287 RVA: 0x00519965 File Offset: 0x00517B65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024EF8 RID: 151288 RVA: 0x00519974 File Offset: 0x00517B74
		public INpcUiInteractOnSunSpirit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A4A1 RID: 42145
		// (get) Token: 0x06024EF9 RID: 151289 RVA: 0x00519984 File Offset: 0x00517B84
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

		// Token: 0x1700A4A2 RID: 42146
		// (get) Token: 0x06024EFA RID: 151290 RVA: 0x005199C0 File Offset: 0x00517BC0
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

		// Token: 0x06024EFB RID: 151291 RVA: 0x005199F7 File Offset: 0x00517BF7
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024EFC RID: 151292 RVA: 0x00519A06 File Offset: 0x00517C06
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A4A3 RID: 42147
		// (get) Token: 0x06024EFD RID: 151293 RVA: 0x00519A14 File Offset: 0x00517C14
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

		// Token: 0x06024EFE RID: 151294 RVA: 0x00519A4B File Offset: 0x00517C4B
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06024EFF RID: 151295 RVA: 0x00519A5A File Offset: 0x00517C5A
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A4A4 RID: 42148
		// (get) Token: 0x06024F00 RID: 151296 RVA: 0x00519A68 File Offset: 0x00517C68
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

		// Token: 0x06024F01 RID: 151297 RVA: 0x00519AA0 File Offset: 0x00517CA0
		public Span<byte> GetShopSuccessMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06024F02 RID: 151298 RVA: 0x00519AB0 File Offset: 0x00517CB0
		public byte[] GetShopSuccessMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A4A5 RID: 42149
		// (get) Token: 0x06024F03 RID: 151299 RVA: 0x00519AC0 File Offset: 0x00517CC0
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

		// Token: 0x1700A4A6 RID: 42150
		// (get) Token: 0x06024F04 RID: 151300 RVA: 0x00519B20 File Offset: 0x00517D20
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

		// Token: 0x1700A4A7 RID: 42151
		// (get) Token: 0x06024F05 RID: 151301 RVA: 0x00519B80 File Offset: 0x00517D80
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

		// Token: 0x1700A4A8 RID: 42152
		// (get) Token: 0x06024F06 RID: 151302 RVA: 0x00519BE0 File Offset: 0x00517DE0
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

		// Token: 0x06024F07 RID: 151303 RVA: 0x00519C18 File Offset: 0x00517E18
		public Span<byte> GetUpgradeSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06024F08 RID: 151304 RVA: 0x00519C28 File Offset: 0x00517E28
		public byte[] GetUpgradeSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700A4A9 RID: 42153
		// (get) Token: 0x06024F09 RID: 151305 RVA: 0x00519C38 File Offset: 0x00517E38
		public IPlayFlow? UpgradeFlow
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

		// Token: 0x1700A4AA RID: 42154
		// (get) Token: 0x06024F0A RID: 151306 RVA: 0x00519C98 File Offset: 0x00517E98
		public TMontageConfig ExitMontageType
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return TMontageConfig.NONE;
				}
				return (TMontageConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024F0B RID: 151307 RVA: 0x00519CD8 File Offset: 0x00517ED8
		public TTable? ExitMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024F0C RID: 151308 RVA: 0x00519D20 File Offset: 0x00517F20
		public IMontageAsset ExitMontageAsIMontageAsset()
		{
			return this.ExitMontage<IMontageAsset>().Value;
		}

		// Token: 0x06024F0D RID: 151309 RVA: 0x00519D3C File Offset: 0x00517F3C
		public IMontageRegistered ExitMontageAsIMontageRegistered()
		{
			return this.ExitMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700A4AB RID: 42155
		// (get) Token: 0x06024F0E RID: 151310 RVA: 0x00519D58 File Offset: 0x00517F58
		public IPlayFlow? ExitFlow
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024F0F RID: 151311 RVA: 0x00519DB8 File Offset: 0x00517FB8
		public static Offset<INpcUiInteractOnSunSpirit> CreateINpcUiInteractOnSunSpirit(FlatBufferBuilder builder, ENpcUiInteractType Type = ENpcUiInteractType.HandInItem, StringOffset EnterMontageOffset = default(StringOffset), StringOffset StandByMontageOffset = default(StringOffset), StringOffset ShopSuccessMontageOffset = default(StringOffset), Offset<IPlayFlow> EnterFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> ShopSuccessFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> ShopFailedFlowOffset = default(Offset<IPlayFlow>), StringOffset UpgradeSequenceOffset = default(StringOffset), Offset<IPlayFlow> UpgradeFlowOffset = default(Offset<IPlayFlow>), TMontageConfig ExitMontage_type = TMontageConfig.NONE, int ExitMontageOffset = 0, Offset<IPlayFlow> ExitFlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(12);
			INpcUiInteractOnSunSpirit.AddExitFlow(builder, ExitFlowOffset);
			INpcUiInteractOnSunSpirit.AddExitMontage(builder, ExitMontageOffset);
			INpcUiInteractOnSunSpirit.AddUpgradeFlow(builder, UpgradeFlowOffset);
			INpcUiInteractOnSunSpirit.AddUpgradeSequence(builder, UpgradeSequenceOffset);
			INpcUiInteractOnSunSpirit.AddShopFailedFlow(builder, ShopFailedFlowOffset);
			INpcUiInteractOnSunSpirit.AddShopSuccessFlow(builder, ShopSuccessFlowOffset);
			INpcUiInteractOnSunSpirit.AddEnterFlow(builder, EnterFlowOffset);
			INpcUiInteractOnSunSpirit.AddShopSuccessMontage(builder, ShopSuccessMontageOffset);
			INpcUiInteractOnSunSpirit.AddStandByMontage(builder, StandByMontageOffset);
			INpcUiInteractOnSunSpirit.AddEnterMontage(builder, EnterMontageOffset);
			INpcUiInteractOnSunSpirit.AddExitMontageType(builder, ExitMontage_type);
			INpcUiInteractOnSunSpirit.AddType(builder, Type);
			return INpcUiInteractOnSunSpirit.EndINpcUiInteractOnSunSpirit(builder);
		}

		// Token: 0x06024F10 RID: 151312 RVA: 0x00519E30 File Offset: 0x00518030
		public static void StartINpcUiInteractOnSunSpirit(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06024F11 RID: 151313 RVA: 0x00519E3A File Offset: 0x0051803A
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024F12 RID: 151314 RVA: 0x00519E45 File Offset: 0x00518045
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x06024F13 RID: 151315 RVA: 0x00519E55 File Offset: 0x00518055
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x06024F14 RID: 151316 RVA: 0x00519E65 File Offset: 0x00518065
		public static void AddShopSuccessMontage(FlatBufferBuilder builder, StringOffset shopSuccessMontageOffset)
		{
			builder.AddOffset(3, shopSuccessMontageOffset.Value, 0);
		}

		// Token: 0x06024F15 RID: 151317 RVA: 0x00519E75 File Offset: 0x00518075
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(4, enterFlowOffset.Value, 0);
		}

		// Token: 0x06024F16 RID: 151318 RVA: 0x00519E85 File Offset: 0x00518085
		public static void AddShopSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopSuccessFlowOffset)
		{
			builder.AddOffset(5, shopSuccessFlowOffset.Value, 0);
		}

		// Token: 0x06024F17 RID: 151319 RVA: 0x00519E95 File Offset: 0x00518095
		public static void AddShopFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopFailedFlowOffset)
		{
			builder.AddOffset(6, shopFailedFlowOffset.Value, 0);
		}

		// Token: 0x06024F18 RID: 151320 RVA: 0x00519EA5 File Offset: 0x005180A5
		public static void AddUpgradeSequence(FlatBufferBuilder builder, StringOffset upgradeSequenceOffset)
		{
			builder.AddOffset(7, upgradeSequenceOffset.Value, 0);
		}

		// Token: 0x06024F19 RID: 151321 RVA: 0x00519EB5 File Offset: 0x005180B5
		public static void AddUpgradeFlow(FlatBufferBuilder builder, Offset<IPlayFlow> upgradeFlowOffset)
		{
			builder.AddOffset(8, upgradeFlowOffset.Value, 0);
		}

		// Token: 0x06024F1A RID: 151322 RVA: 0x00519EC5 File Offset: 0x005180C5
		public static void AddExitMontageType(FlatBufferBuilder builder, TMontageConfig exitMontageType)
		{
			builder.AddByte(9, (byte)exitMontageType, 0);
		}

		// Token: 0x06024F1B RID: 151323 RVA: 0x00519ED1 File Offset: 0x005180D1
		public static void AddExitMontage(FlatBufferBuilder builder, int exitMontageOffset)
		{
			builder.AddOffset(10, exitMontageOffset, 0);
		}

		// Token: 0x06024F1C RID: 151324 RVA: 0x00519EDD File Offset: 0x005180DD
		public static void AddExitFlow(FlatBufferBuilder builder, Offset<IPlayFlow> exitFlowOffset)
		{
			builder.AddOffset(11, exitFlowOffset.Value, 0);
		}

		// Token: 0x06024F1D RID: 151325 RVA: 0x00519EEE File Offset: 0x005180EE
		public static Offset<INpcUiInteractOnSunSpirit> EndINpcUiInteractOnSunSpirit(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnSunSpirit>(builder.EndTable());
		}

		// Token: 0x06024F1E RID: 151326 RVA: 0x00519EFC File Offset: 0x005180FC
		public INpcUiInteractOnSunSpiritT UnPack()
		{
			INpcUiInteractOnSunSpiritT npcUiInteractOnSunSpiritT = new INpcUiInteractOnSunSpiritT();
			this.UnPackTo(npcUiInteractOnSunSpiritT);
			return npcUiInteractOnSunSpiritT;
		}

		// Token: 0x06024F1F RID: 151327 RVA: 0x00519F18 File Offset: 0x00518118
		public void UnPackTo(INpcUiInteractOnSunSpiritT _o)
		{
			_o.Type = this.Type;
			_o.EnterMontage = this.EnterMontage;
			_o.StandByMontage = this.StandByMontage;
			_o.ShopSuccessMontage = this.ShopSuccessMontage;
			_o.EnterFlow = ((this.EnterFlow != null) ? this.EnterFlow.Value.UnPack() : null);
			_o.ShopSuccessFlow = ((this.ShopSuccessFlow != null) ? this.ShopSuccessFlow.Value.UnPack() : null);
			_o.ShopFailedFlow = ((this.ShopFailedFlow != null) ? this.ShopFailedFlow.Value.UnPack() : null);
			_o.UpgradeSequence = this.UpgradeSequence;
			_o.UpgradeFlow = ((this.UpgradeFlow != null) ? this.UpgradeFlow.Value.UnPack() : null);
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

		// Token: 0x06024F20 RID: 151328 RVA: 0x0051A0E8 File Offset: 0x005182E8
		public static Offset<INpcUiInteractOnSunSpirit> Pack(FlatBufferBuilder builder, INpcUiInteractOnSunSpiritT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcUiInteractOnSunSpirit>);
			}
			StringOffset enterMontageOffset = (_o.EnterMontage == null) ? default(StringOffset) : builder.CreateString(_o.EnterMontage);
			StringOffset standByMontageOffset = (_o.StandByMontage == null) ? default(StringOffset) : builder.CreateString(_o.StandByMontage);
			StringOffset shopSuccessMontageOffset = (_o.ShopSuccessMontage == null) ? default(StringOffset) : builder.CreateString(_o.ShopSuccessMontage);
			Offset<IPlayFlow> enterFlowOffset = (_o.EnterFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.EnterFlow);
			Offset<IPlayFlow> shopSuccessFlowOffset = (_o.ShopSuccessFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.ShopSuccessFlow);
			Offset<IPlayFlow> shopFailedFlowOffset = (_o.ShopFailedFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.ShopFailedFlow);
			StringOffset upgradeSequenceOffset = (_o.UpgradeSequence == null) ? default(StringOffset) : builder.CreateString(_o.UpgradeSequence);
			Offset<IPlayFlow> upgradeFlowOffset = (_o.UpgradeFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.UpgradeFlow);
			TMontageConfig exitMontage_type = (_o.ExitMontage == null) ? TMontageConfig.NONE : _o.ExitMontage.Type;
			int exitMontageOffset = (_o.ExitMontage == null) ? 0 : TMontageConfigUnion.Pack(builder, _o.ExitMontage);
			Offset<IPlayFlow> exitFlowOffset = (_o.ExitFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.ExitFlow);
			return INpcUiInteractOnSunSpirit.CreateINpcUiInteractOnSunSpirit(builder, _o.Type, enterMontageOffset, standByMontageOffset, shopSuccessMontageOffset, enterFlowOffset, shopSuccessFlowOffset, shopFailedFlowOffset, upgradeSequenceOffset, upgradeFlowOffset, exitMontage_type, exitMontageOffset, exitFlowOffset);
		}

		// Token: 0x0400EA8C RID: 60044
		private Table __p;
	}
}
