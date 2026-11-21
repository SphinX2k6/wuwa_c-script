using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C27 RID: 23591
	public struct INpcUiInteractOnSunSpirit : IFlatbufferObject
	{
		// Token: 0x1700AD2F RID: 44335
		// (get) Token: 0x0602712C RID: 160044 RVA: 0x0055A4B3 File Offset: 0x005586B3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602712D RID: 160045 RVA: 0x0055A4C0 File Offset: 0x005586C0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602712E RID: 160046 RVA: 0x0055A4C8 File Offset: 0x005586C8
		public static INpcUiInteractOnSunSpirit GetRootAsINpcUiInteractOnSunSpirit(ByteBuffer _bb)
		{
			return INpcUiInteractOnSunSpirit.GetRootAsINpcUiInteractOnSunSpirit(_bb, default(INpcUiInteractOnSunSpirit));
		}

		// Token: 0x0602712F RID: 160047 RVA: 0x0055A4E4 File Offset: 0x005586E4
		public static INpcUiInteractOnSunSpirit GetRootAsINpcUiInteractOnSunSpirit(ByteBuffer _bb, INpcUiInteractOnSunSpirit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027130 RID: 160048 RVA: 0x0055A501 File Offset: 0x00558701
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027131 RID: 160049 RVA: 0x0055A510 File Offset: 0x00558710
		public INpcUiInteractOnSunSpirit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD30 RID: 44336
		// (get) Token: 0x06027132 RID: 160050 RVA: 0x0055A520 File Offset: 0x00558720
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

		// Token: 0x1700AD31 RID: 44337
		// (get) Token: 0x06027133 RID: 160051 RVA: 0x0055A55C File Offset: 0x0055875C
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

		// Token: 0x06027134 RID: 160052 RVA: 0x0055A593 File Offset: 0x00558793
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06027135 RID: 160053 RVA: 0x0055A5A2 File Offset: 0x005587A2
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AD32 RID: 44338
		// (get) Token: 0x06027136 RID: 160054 RVA: 0x0055A5B0 File Offset: 0x005587B0
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

		// Token: 0x06027137 RID: 160055 RVA: 0x0055A5E7 File Offset: 0x005587E7
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06027138 RID: 160056 RVA: 0x0055A5F6 File Offset: 0x005587F6
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700AD33 RID: 44339
		// (get) Token: 0x06027139 RID: 160057 RVA: 0x0055A604 File Offset: 0x00558804
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

		// Token: 0x0602713A RID: 160058 RVA: 0x0055A63C File Offset: 0x0055883C
		public Span<byte> GetShopSuccessMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602713B RID: 160059 RVA: 0x0055A64C File Offset: 0x0055884C
		public byte[] GetShopSuccessMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700AD34 RID: 44340
		// (get) Token: 0x0602713C RID: 160060 RVA: 0x0055A65C File Offset: 0x0055885C
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

		// Token: 0x1700AD35 RID: 44341
		// (get) Token: 0x0602713D RID: 160061 RVA: 0x0055A6BC File Offset: 0x005588BC
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

		// Token: 0x1700AD36 RID: 44342
		// (get) Token: 0x0602713E RID: 160062 RVA: 0x0055A71C File Offset: 0x0055891C
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

		// Token: 0x1700AD37 RID: 44343
		// (get) Token: 0x0602713F RID: 160063 RVA: 0x0055A77C File Offset: 0x0055897C
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

		// Token: 0x06027140 RID: 160064 RVA: 0x0055A7B4 File Offset: 0x005589B4
		public Span<byte> GetUpgradeSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06027141 RID: 160065 RVA: 0x0055A7C4 File Offset: 0x005589C4
		public byte[] GetUpgradeSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700AD38 RID: 44344
		// (get) Token: 0x06027142 RID: 160066 RVA: 0x0055A7D4 File Offset: 0x005589D4
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

		// Token: 0x1700AD39 RID: 44345
		// (get) Token: 0x06027143 RID: 160067 RVA: 0x0055A834 File Offset: 0x00558A34
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

		// Token: 0x06027144 RID: 160068 RVA: 0x0055A874 File Offset: 0x00558A74
		public TTable? ExitMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027145 RID: 160069 RVA: 0x0055A8BC File Offset: 0x00558ABC
		public IMontageAsset ExitMontageAsIMontageAsset()
		{
			return this.ExitMontage<IMontageAsset>().Value;
		}

		// Token: 0x06027146 RID: 160070 RVA: 0x0055A8D8 File Offset: 0x00558AD8
		public IMontageRegistered ExitMontageAsIMontageRegistered()
		{
			return this.ExitMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700AD3A RID: 44346
		// (get) Token: 0x06027147 RID: 160071 RVA: 0x0055A8F4 File Offset: 0x00558AF4
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

		// Token: 0x06027148 RID: 160072 RVA: 0x0055A954 File Offset: 0x00558B54
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

		// Token: 0x06027149 RID: 160073 RVA: 0x0055A9CC File Offset: 0x00558BCC
		public static void StartINpcUiInteractOnSunSpirit(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x0602714A RID: 160074 RVA: 0x0055A9D6 File Offset: 0x00558BD6
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602714B RID: 160075 RVA: 0x0055A9E1 File Offset: 0x00558BE1
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x0602714C RID: 160076 RVA: 0x0055A9F1 File Offset: 0x00558BF1
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x0602714D RID: 160077 RVA: 0x0055AA01 File Offset: 0x00558C01
		public static void AddShopSuccessMontage(FlatBufferBuilder builder, StringOffset shopSuccessMontageOffset)
		{
			builder.AddOffset(3, shopSuccessMontageOffset.Value, 0);
		}

		// Token: 0x0602714E RID: 160078 RVA: 0x0055AA11 File Offset: 0x00558C11
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(4, enterFlowOffset.Value, 0);
		}

		// Token: 0x0602714F RID: 160079 RVA: 0x0055AA21 File Offset: 0x00558C21
		public static void AddShopSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopSuccessFlowOffset)
		{
			builder.AddOffset(5, shopSuccessFlowOffset.Value, 0);
		}

		// Token: 0x06027150 RID: 160080 RVA: 0x0055AA31 File Offset: 0x00558C31
		public static void AddShopFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopFailedFlowOffset)
		{
			builder.AddOffset(6, shopFailedFlowOffset.Value, 0);
		}

		// Token: 0x06027151 RID: 160081 RVA: 0x0055AA41 File Offset: 0x00558C41
		public static void AddUpgradeSequence(FlatBufferBuilder builder, StringOffset upgradeSequenceOffset)
		{
			builder.AddOffset(7, upgradeSequenceOffset.Value, 0);
		}

		// Token: 0x06027152 RID: 160082 RVA: 0x0055AA51 File Offset: 0x00558C51
		public static void AddUpgradeFlow(FlatBufferBuilder builder, Offset<IPlayFlow> upgradeFlowOffset)
		{
			builder.AddOffset(8, upgradeFlowOffset.Value, 0);
		}

		// Token: 0x06027153 RID: 160083 RVA: 0x0055AA61 File Offset: 0x00558C61
		public static void AddExitMontageType(FlatBufferBuilder builder, TMontageConfig exitMontageType)
		{
			builder.AddByte(9, (byte)exitMontageType, 0);
		}

		// Token: 0x06027154 RID: 160084 RVA: 0x0055AA6D File Offset: 0x00558C6D
		public static void AddExitMontage(FlatBufferBuilder builder, int exitMontageOffset)
		{
			builder.AddOffset(10, exitMontageOffset, 0);
		}

		// Token: 0x06027155 RID: 160085 RVA: 0x0055AA79 File Offset: 0x00558C79
		public static void AddExitFlow(FlatBufferBuilder builder, Offset<IPlayFlow> exitFlowOffset)
		{
			builder.AddOffset(11, exitFlowOffset.Value, 0);
		}

		// Token: 0x06027156 RID: 160086 RVA: 0x0055AA8A File Offset: 0x00558C8A
		public static Offset<INpcUiInteractOnSunSpirit> EndINpcUiInteractOnSunSpirit(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnSunSpirit>(builder.EndTable());
		}

		// Token: 0x06027157 RID: 160087 RVA: 0x0055AA98 File Offset: 0x00558C98
		public INpcUiInteractOnSunSpiritT UnPack()
		{
			INpcUiInteractOnSunSpiritT npcUiInteractOnSunSpiritT = new INpcUiInteractOnSunSpiritT();
			this.UnPackTo(npcUiInteractOnSunSpiritT);
			return npcUiInteractOnSunSpiritT;
		}

		// Token: 0x06027158 RID: 160088 RVA: 0x0055AAB4 File Offset: 0x00558CB4
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

		// Token: 0x06027159 RID: 160089 RVA: 0x0055AC84 File Offset: 0x00558E84
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

		// Token: 0x0400F6F5 RID: 63221
		private Table __p;
	}
}
