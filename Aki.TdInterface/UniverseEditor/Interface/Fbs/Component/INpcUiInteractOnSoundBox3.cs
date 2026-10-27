using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005680 RID: 22144
	public struct INpcUiInteractOnSoundBox3 : IFlatbufferObject
	{
		// Token: 0x1700A472 RID: 42098
		// (get) Token: 0x06024E67 RID: 151143 RVA: 0x00518127 File Offset: 0x00516327
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024E68 RID: 151144 RVA: 0x00518134 File Offset: 0x00516334
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024E69 RID: 151145 RVA: 0x0051813C File Offset: 0x0051633C
		public static INpcUiInteractOnSoundBox3 GetRootAsINpcUiInteractOnSoundBox3(ByteBuffer _bb)
		{
			return INpcUiInteractOnSoundBox3.GetRootAsINpcUiInteractOnSoundBox3(_bb, default(INpcUiInteractOnSoundBox3));
		}

		// Token: 0x06024E6A RID: 151146 RVA: 0x00518158 File Offset: 0x00516358
		public static INpcUiInteractOnSoundBox3 GetRootAsINpcUiInteractOnSoundBox3(ByteBuffer _bb, INpcUiInteractOnSoundBox3 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024E6B RID: 151147 RVA: 0x00518175 File Offset: 0x00516375
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024E6C RID: 151148 RVA: 0x00518184 File Offset: 0x00516384
		public INpcUiInteractOnSoundBox3 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A473 RID: 42099
		// (get) Token: 0x06024E6D RID: 151149 RVA: 0x00518194 File Offset: 0x00516394
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

		// Token: 0x1700A474 RID: 42100
		// (get) Token: 0x06024E6E RID: 151150 RVA: 0x005181D0 File Offset: 0x005163D0
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

		// Token: 0x06024E6F RID: 151151 RVA: 0x00518207 File Offset: 0x00516407
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024E70 RID: 151152 RVA: 0x00518216 File Offset: 0x00516416
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A475 RID: 42101
		// (get) Token: 0x06024E71 RID: 151153 RVA: 0x00518224 File Offset: 0x00516424
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

		// Token: 0x06024E72 RID: 151154 RVA: 0x0051825B File Offset: 0x0051645B
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06024E73 RID: 151155 RVA: 0x0051826A File Offset: 0x0051646A
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A476 RID: 42102
		// (get) Token: 0x06024E74 RID: 151156 RVA: 0x00518278 File Offset: 0x00516478
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

		// Token: 0x06024E75 RID: 151157 RVA: 0x005182B0 File Offset: 0x005164B0
		public Span<byte> GetShopSuccessMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06024E76 RID: 151158 RVA: 0x005182C0 File Offset: 0x005164C0
		public byte[] GetShopSuccessMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A477 RID: 42103
		// (get) Token: 0x06024E77 RID: 151159 RVA: 0x005182D0 File Offset: 0x005164D0
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

		// Token: 0x1700A478 RID: 42104
		// (get) Token: 0x06024E78 RID: 151160 RVA: 0x00518330 File Offset: 0x00516530
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

		// Token: 0x1700A479 RID: 42105
		// (get) Token: 0x06024E79 RID: 151161 RVA: 0x00518390 File Offset: 0x00516590
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

		// Token: 0x1700A47A RID: 42106
		// (get) Token: 0x06024E7A RID: 151162 RVA: 0x005183F0 File Offset: 0x005165F0
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

		// Token: 0x06024E7B RID: 151163 RVA: 0x00518428 File Offset: 0x00516628
		public Span<byte> GetUpgradeSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06024E7C RID: 151164 RVA: 0x00518438 File Offset: 0x00516638
		public byte[] GetUpgradeSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700A47B RID: 42107
		// (get) Token: 0x06024E7D RID: 151165 RVA: 0x00518448 File Offset: 0x00516648
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

		// Token: 0x1700A47C RID: 42108
		// (get) Token: 0x06024E7E RID: 151166 RVA: 0x005184A8 File Offset: 0x005166A8
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

		// Token: 0x06024E7F RID: 151167 RVA: 0x005184E8 File Offset: 0x005166E8
		public TTable? ExitMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024E80 RID: 151168 RVA: 0x00518530 File Offset: 0x00516730
		public IMontageAsset ExitMontageAsIMontageAsset()
		{
			return this.ExitMontage<IMontageAsset>().Value;
		}

		// Token: 0x06024E81 RID: 151169 RVA: 0x0051854C File Offset: 0x0051674C
		public IMontageRegistered ExitMontageAsIMontageRegistered()
		{
			return this.ExitMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700A47D RID: 42109
		// (get) Token: 0x06024E82 RID: 151170 RVA: 0x00518568 File Offset: 0x00516768
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

		// Token: 0x06024E83 RID: 151171 RVA: 0x005185C8 File Offset: 0x005167C8
		public static Offset<INpcUiInteractOnSoundBox3> CreateINpcUiInteractOnSoundBox3(FlatBufferBuilder builder, ENpcUiInteractType Type = ENpcUiInteractType.HandInItem, StringOffset EnterMontageOffset = default(StringOffset), StringOffset StandByMontageOffset = default(StringOffset), StringOffset ShopSuccessMontageOffset = default(StringOffset), Offset<IPlayFlow> EnterFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> ShopSuccessFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> ShopFailedFlowOffset = default(Offset<IPlayFlow>), StringOffset UpgradeSequenceOffset = default(StringOffset), Offset<IPlayFlow> UpgradeFlowOffset = default(Offset<IPlayFlow>), TMontageConfig ExitMontage_type = TMontageConfig.NONE, int ExitMontageOffset = 0, Offset<IPlayFlow> ExitFlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(12);
			INpcUiInteractOnSoundBox3.AddExitFlow(builder, ExitFlowOffset);
			INpcUiInteractOnSoundBox3.AddExitMontage(builder, ExitMontageOffset);
			INpcUiInteractOnSoundBox3.AddUpgradeFlow(builder, UpgradeFlowOffset);
			INpcUiInteractOnSoundBox3.AddUpgradeSequence(builder, UpgradeSequenceOffset);
			INpcUiInteractOnSoundBox3.AddShopFailedFlow(builder, ShopFailedFlowOffset);
			INpcUiInteractOnSoundBox3.AddShopSuccessFlow(builder, ShopSuccessFlowOffset);
			INpcUiInteractOnSoundBox3.AddEnterFlow(builder, EnterFlowOffset);
			INpcUiInteractOnSoundBox3.AddShopSuccessMontage(builder, ShopSuccessMontageOffset);
			INpcUiInteractOnSoundBox3.AddStandByMontage(builder, StandByMontageOffset);
			INpcUiInteractOnSoundBox3.AddEnterMontage(builder, EnterMontageOffset);
			INpcUiInteractOnSoundBox3.AddExitMontageType(builder, ExitMontage_type);
			INpcUiInteractOnSoundBox3.AddType(builder, Type);
			return INpcUiInteractOnSoundBox3.EndINpcUiInteractOnSoundBox3(builder);
		}

		// Token: 0x06024E84 RID: 151172 RVA: 0x00518640 File Offset: 0x00516840
		public static void StartINpcUiInteractOnSoundBox3(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06024E85 RID: 151173 RVA: 0x0051864A File Offset: 0x0051684A
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024E86 RID: 151174 RVA: 0x00518655 File Offset: 0x00516855
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x06024E87 RID: 151175 RVA: 0x00518665 File Offset: 0x00516865
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x06024E88 RID: 151176 RVA: 0x00518675 File Offset: 0x00516875
		public static void AddShopSuccessMontage(FlatBufferBuilder builder, StringOffset shopSuccessMontageOffset)
		{
			builder.AddOffset(3, shopSuccessMontageOffset.Value, 0);
		}

		// Token: 0x06024E89 RID: 151177 RVA: 0x00518685 File Offset: 0x00516885
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(4, enterFlowOffset.Value, 0);
		}

		// Token: 0x06024E8A RID: 151178 RVA: 0x00518695 File Offset: 0x00516895
		public static void AddShopSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopSuccessFlowOffset)
		{
			builder.AddOffset(5, shopSuccessFlowOffset.Value, 0);
		}

		// Token: 0x06024E8B RID: 151179 RVA: 0x005186A5 File Offset: 0x005168A5
		public static void AddShopFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopFailedFlowOffset)
		{
			builder.AddOffset(6, shopFailedFlowOffset.Value, 0);
		}

		// Token: 0x06024E8C RID: 151180 RVA: 0x005186B5 File Offset: 0x005168B5
		public static void AddUpgradeSequence(FlatBufferBuilder builder, StringOffset upgradeSequenceOffset)
		{
			builder.AddOffset(7, upgradeSequenceOffset.Value, 0);
		}

		// Token: 0x06024E8D RID: 151181 RVA: 0x005186C5 File Offset: 0x005168C5
		public static void AddUpgradeFlow(FlatBufferBuilder builder, Offset<IPlayFlow> upgradeFlowOffset)
		{
			builder.AddOffset(8, upgradeFlowOffset.Value, 0);
		}

		// Token: 0x06024E8E RID: 151182 RVA: 0x005186D5 File Offset: 0x005168D5
		public static void AddExitMontageType(FlatBufferBuilder builder, TMontageConfig exitMontageType)
		{
			builder.AddByte(9, (byte)exitMontageType, 0);
		}

		// Token: 0x06024E8F RID: 151183 RVA: 0x005186E1 File Offset: 0x005168E1
		public static void AddExitMontage(FlatBufferBuilder builder, int exitMontageOffset)
		{
			builder.AddOffset(10, exitMontageOffset, 0);
		}

		// Token: 0x06024E90 RID: 151184 RVA: 0x005186ED File Offset: 0x005168ED
		public static void AddExitFlow(FlatBufferBuilder builder, Offset<IPlayFlow> exitFlowOffset)
		{
			builder.AddOffset(11, exitFlowOffset.Value, 0);
		}

		// Token: 0x06024E91 RID: 151185 RVA: 0x005186FE File Offset: 0x005168FE
		public static Offset<INpcUiInteractOnSoundBox3> EndINpcUiInteractOnSoundBox3(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnSoundBox3>(builder.EndTable());
		}

		// Token: 0x06024E92 RID: 151186 RVA: 0x0051870C File Offset: 0x0051690C
		public INpcUiInteractOnSoundBox3T UnPack()
		{
			INpcUiInteractOnSoundBox3T npcUiInteractOnSoundBox3T = new INpcUiInteractOnSoundBox3T();
			this.UnPackTo(npcUiInteractOnSoundBox3T);
			return npcUiInteractOnSoundBox3T;
		}

		// Token: 0x06024E93 RID: 151187 RVA: 0x00518728 File Offset: 0x00516928
		public void UnPackTo(INpcUiInteractOnSoundBox3T _o)
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

		// Token: 0x06024E94 RID: 151188 RVA: 0x005188F8 File Offset: 0x00516AF8
		public static Offset<INpcUiInteractOnSoundBox3> Pack(FlatBufferBuilder builder, INpcUiInteractOnSoundBox3T _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcUiInteractOnSoundBox3>);
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
			return INpcUiInteractOnSoundBox3.CreateINpcUiInteractOnSoundBox3(builder, _o.Type, enterMontageOffset, standByMontageOffset, shopSuccessMontageOffset, enterFlowOffset, shopSuccessFlowOffset, shopFailedFlowOffset, upgradeSequenceOffset, upgradeFlowOffset, exitMontage_type, exitMontageOffset, exitFlowOffset);
		}

		// Token: 0x0400EA74 RID: 60020
		private Table __p;
	}
}
