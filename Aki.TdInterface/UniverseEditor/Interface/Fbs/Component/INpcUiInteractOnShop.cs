using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200567A RID: 22138
	public struct INpcUiInteractOnShop : IFlatbufferObject
	{
		// Token: 0x1700A448 RID: 42056
		// (get) Token: 0x06024DE1 RID: 151009 RVA: 0x005166E5 File Offset: 0x005148E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024DE2 RID: 151010 RVA: 0x005166F2 File Offset: 0x005148F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024DE3 RID: 151011 RVA: 0x005166FC File Offset: 0x005148FC
		public static INpcUiInteractOnShop GetRootAsINpcUiInteractOnShop(ByteBuffer _bb)
		{
			return INpcUiInteractOnShop.GetRootAsINpcUiInteractOnShop(_bb, default(INpcUiInteractOnShop));
		}

		// Token: 0x06024DE4 RID: 151012 RVA: 0x00516718 File Offset: 0x00514918
		public static INpcUiInteractOnShop GetRootAsINpcUiInteractOnShop(ByteBuffer _bb, INpcUiInteractOnShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024DE5 RID: 151013 RVA: 0x00516735 File Offset: 0x00514935
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024DE6 RID: 151014 RVA: 0x00516744 File Offset: 0x00514944
		public INpcUiInteractOnShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A449 RID: 42057
		// (get) Token: 0x06024DE7 RID: 151015 RVA: 0x00516754 File Offset: 0x00514954
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

		// Token: 0x1700A44A RID: 42058
		// (get) Token: 0x06024DE8 RID: 151016 RVA: 0x00516790 File Offset: 0x00514990
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

		// Token: 0x06024DE9 RID: 151017 RVA: 0x005167C7 File Offset: 0x005149C7
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024DEA RID: 151018 RVA: 0x005167D6 File Offset: 0x005149D6
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A44B RID: 42059
		// (get) Token: 0x06024DEB RID: 151019 RVA: 0x005167E4 File Offset: 0x005149E4
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

		// Token: 0x06024DEC RID: 151020 RVA: 0x0051681B File Offset: 0x00514A1B
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06024DED RID: 151021 RVA: 0x0051682A File Offset: 0x00514A2A
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A44C RID: 42060
		// (get) Token: 0x06024DEE RID: 151022 RVA: 0x00516838 File Offset: 0x00514A38
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

		// Token: 0x06024DEF RID: 151023 RVA: 0x00516870 File Offset: 0x00514A70
		public Span<byte> GetShopSuccessMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06024DF0 RID: 151024 RVA: 0x00516880 File Offset: 0x00514A80
		public byte[] GetShopSuccessMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A44D RID: 42061
		// (get) Token: 0x06024DF1 RID: 151025 RVA: 0x00516890 File Offset: 0x00514A90
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

		// Token: 0x1700A44E RID: 42062
		// (get) Token: 0x06024DF2 RID: 151026 RVA: 0x005168F0 File Offset: 0x00514AF0
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

		// Token: 0x1700A44F RID: 42063
		// (get) Token: 0x06024DF3 RID: 151027 RVA: 0x00516950 File Offset: 0x00514B50
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

		// Token: 0x1700A450 RID: 42064
		// (get) Token: 0x06024DF4 RID: 151028 RVA: 0x005169B0 File Offset: 0x00514BB0
		public IPlayFlow? WorkingFlow
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

		// Token: 0x1700A451 RID: 42065
		// (get) Token: 0x06024DF5 RID: 151029 RVA: 0x00516A10 File Offset: 0x00514C10
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

		// Token: 0x06024DF6 RID: 151030 RVA: 0x00516A50 File Offset: 0x00514C50
		public TTable? ExitMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024DF7 RID: 151031 RVA: 0x00516A98 File Offset: 0x00514C98
		public IMontageAsset ExitMontageAsIMontageAsset()
		{
			return this.ExitMontage<IMontageAsset>().Value;
		}

		// Token: 0x06024DF8 RID: 151032 RVA: 0x00516AB4 File Offset: 0x00514CB4
		public IMontageRegistered ExitMontageAsIMontageRegistered()
		{
			return this.ExitMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700A452 RID: 42066
		// (get) Token: 0x06024DF9 RID: 151033 RVA: 0x00516AD0 File Offset: 0x00514CD0
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

		// Token: 0x06024DFA RID: 151034 RVA: 0x00516B30 File Offset: 0x00514D30
		public static Offset<INpcUiInteractOnShop> CreateINpcUiInteractOnShop(FlatBufferBuilder builder, ENpcUiInteractType Type = ENpcUiInteractType.HandInItem, StringOffset EnterMontageOffset = default(StringOffset), StringOffset StandByMontageOffset = default(StringOffset), StringOffset ShopSuccessMontageOffset = default(StringOffset), Offset<IPlayFlow> EnterFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> ShopSuccessFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> ShopFailedFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> WorkingFlowOffset = default(Offset<IPlayFlow>), TMontageConfig ExitMontage_type = TMontageConfig.NONE, int ExitMontageOffset = 0, Offset<IPlayFlow> ExitFlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(11);
			INpcUiInteractOnShop.AddExitFlow(builder, ExitFlowOffset);
			INpcUiInteractOnShop.AddExitMontage(builder, ExitMontageOffset);
			INpcUiInteractOnShop.AddWorkingFlow(builder, WorkingFlowOffset);
			INpcUiInteractOnShop.AddShopFailedFlow(builder, ShopFailedFlowOffset);
			INpcUiInteractOnShop.AddShopSuccessFlow(builder, ShopSuccessFlowOffset);
			INpcUiInteractOnShop.AddEnterFlow(builder, EnterFlowOffset);
			INpcUiInteractOnShop.AddShopSuccessMontage(builder, ShopSuccessMontageOffset);
			INpcUiInteractOnShop.AddStandByMontage(builder, StandByMontageOffset);
			INpcUiInteractOnShop.AddEnterMontage(builder, EnterMontageOffset);
			INpcUiInteractOnShop.AddExitMontageType(builder, ExitMontage_type);
			INpcUiInteractOnShop.AddType(builder, Type);
			return INpcUiInteractOnShop.EndINpcUiInteractOnShop(builder);
		}

		// Token: 0x06024DFB RID: 151035 RVA: 0x00516BA0 File Offset: 0x00514DA0
		public static void StartINpcUiInteractOnShop(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06024DFC RID: 151036 RVA: 0x00516BAA File Offset: 0x00514DAA
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024DFD RID: 151037 RVA: 0x00516BB5 File Offset: 0x00514DB5
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x06024DFE RID: 151038 RVA: 0x00516BC5 File Offset: 0x00514DC5
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x06024DFF RID: 151039 RVA: 0x00516BD5 File Offset: 0x00514DD5
		public static void AddShopSuccessMontage(FlatBufferBuilder builder, StringOffset shopSuccessMontageOffset)
		{
			builder.AddOffset(3, shopSuccessMontageOffset.Value, 0);
		}

		// Token: 0x06024E00 RID: 151040 RVA: 0x00516BE5 File Offset: 0x00514DE5
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(4, enterFlowOffset.Value, 0);
		}

		// Token: 0x06024E01 RID: 151041 RVA: 0x00516BF5 File Offset: 0x00514DF5
		public static void AddShopSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopSuccessFlowOffset)
		{
			builder.AddOffset(5, shopSuccessFlowOffset.Value, 0);
		}

		// Token: 0x06024E02 RID: 151042 RVA: 0x00516C05 File Offset: 0x00514E05
		public static void AddShopFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopFailedFlowOffset)
		{
			builder.AddOffset(6, shopFailedFlowOffset.Value, 0);
		}

		// Token: 0x06024E03 RID: 151043 RVA: 0x00516C15 File Offset: 0x00514E15
		public static void AddWorkingFlow(FlatBufferBuilder builder, Offset<IPlayFlow> workingFlowOffset)
		{
			builder.AddOffset(7, workingFlowOffset.Value, 0);
		}

		// Token: 0x06024E04 RID: 151044 RVA: 0x00516C25 File Offset: 0x00514E25
		public static void AddExitMontageType(FlatBufferBuilder builder, TMontageConfig exitMontageType)
		{
			builder.AddByte(8, (byte)exitMontageType, 0);
		}

		// Token: 0x06024E05 RID: 151045 RVA: 0x00516C30 File Offset: 0x00514E30
		public static void AddExitMontage(FlatBufferBuilder builder, int exitMontageOffset)
		{
			builder.AddOffset(9, exitMontageOffset, 0);
		}

		// Token: 0x06024E06 RID: 151046 RVA: 0x00516C3C File Offset: 0x00514E3C
		public static void AddExitFlow(FlatBufferBuilder builder, Offset<IPlayFlow> exitFlowOffset)
		{
			builder.AddOffset(10, exitFlowOffset.Value, 0);
		}

		// Token: 0x06024E07 RID: 151047 RVA: 0x00516C4D File Offset: 0x00514E4D
		public static Offset<INpcUiInteractOnShop> EndINpcUiInteractOnShop(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnShop>(builder.EndTable());
		}

		// Token: 0x06024E08 RID: 151048 RVA: 0x00516C5C File Offset: 0x00514E5C
		public INpcUiInteractOnShopT UnPack()
		{
			INpcUiInteractOnShopT npcUiInteractOnShopT = new INpcUiInteractOnShopT();
			this.UnPackTo(npcUiInteractOnShopT);
			return npcUiInteractOnShopT;
		}

		// Token: 0x06024E09 RID: 151049 RVA: 0x00516C78 File Offset: 0x00514E78
		public void UnPackTo(INpcUiInteractOnShopT _o)
		{
			_o.Type = this.Type;
			_o.EnterMontage = this.EnterMontage;
			_o.StandByMontage = this.StandByMontage;
			_o.ShopSuccessMontage = this.ShopSuccessMontage;
			_o.EnterFlow = ((this.EnterFlow != null) ? this.EnterFlow.Value.UnPack() : null);
			_o.ShopSuccessFlow = ((this.ShopSuccessFlow != null) ? this.ShopSuccessFlow.Value.UnPack() : null);
			_o.ShopFailedFlow = ((this.ShopFailedFlow != null) ? this.ShopFailedFlow.Value.UnPack() : null);
			_o.WorkingFlow = ((this.WorkingFlow != null) ? this.WorkingFlow.Value.UnPack() : null);
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

		// Token: 0x06024E0A RID: 151050 RVA: 0x00516E3C File Offset: 0x0051503C
		public static Offset<INpcUiInteractOnShop> Pack(FlatBufferBuilder builder, INpcUiInteractOnShopT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcUiInteractOnShop>);
			}
			StringOffset enterMontageOffset = (_o.EnterMontage == null) ? default(StringOffset) : builder.CreateString(_o.EnterMontage);
			StringOffset standByMontageOffset = (_o.StandByMontage == null) ? default(StringOffset) : builder.CreateString(_o.StandByMontage);
			StringOffset shopSuccessMontageOffset = (_o.ShopSuccessMontage == null) ? default(StringOffset) : builder.CreateString(_o.ShopSuccessMontage);
			Offset<IPlayFlow> enterFlowOffset = (_o.EnterFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.EnterFlow);
			Offset<IPlayFlow> shopSuccessFlowOffset = (_o.ShopSuccessFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.ShopSuccessFlow);
			Offset<IPlayFlow> shopFailedFlowOffset = (_o.ShopFailedFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.ShopFailedFlow);
			Offset<IPlayFlow> workingFlowOffset = (_o.WorkingFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.WorkingFlow);
			TMontageConfig exitMontage_type = (_o.ExitMontage == null) ? TMontageConfig.NONE : _o.ExitMontage.Type;
			int exitMontageOffset = (_o.ExitMontage == null) ? 0 : TMontageConfigUnion.Pack(builder, _o.ExitMontage);
			Offset<IPlayFlow> exitFlowOffset = (_o.ExitFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.ExitFlow);
			return INpcUiInteractOnShop.CreateINpcUiInteractOnShop(builder, _o.Type, enterMontageOffset, standByMontageOffset, shopSuccessMontageOffset, enterFlowOffset, shopSuccessFlowOffset, shopFailedFlowOffset, workingFlowOffset, exitMontage_type, exitMontageOffset, exitFlowOffset);
		}

		// Token: 0x0400EA5E RID: 59998
		private Table __p;
	}
}
