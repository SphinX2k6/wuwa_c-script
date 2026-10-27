using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200567D RID: 22141
	public struct INpcUiInteractOnShopNew : IFlatbufferObject
	{
		// Token: 0x1700A45D RID: 42077
		// (get) Token: 0x06024E21 RID: 151073 RVA: 0x0051721C File Offset: 0x0051541C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024E22 RID: 151074 RVA: 0x00517229 File Offset: 0x00515429
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024E23 RID: 151075 RVA: 0x00517230 File Offset: 0x00515430
		public static INpcUiInteractOnShopNew GetRootAsINpcUiInteractOnShopNew(ByteBuffer _bb)
		{
			return INpcUiInteractOnShopNew.GetRootAsINpcUiInteractOnShopNew(_bb, default(INpcUiInteractOnShopNew));
		}

		// Token: 0x06024E24 RID: 151076 RVA: 0x0051724C File Offset: 0x0051544C
		public static INpcUiInteractOnShopNew GetRootAsINpcUiInteractOnShopNew(ByteBuffer _bb, INpcUiInteractOnShopNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024E25 RID: 151077 RVA: 0x00517269 File Offset: 0x00515469
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024E26 RID: 151078 RVA: 0x00517278 File Offset: 0x00515478
		public INpcUiInteractOnShopNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A45E RID: 42078
		// (get) Token: 0x06024E27 RID: 151079 RVA: 0x00517288 File Offset: 0x00515488
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

		// Token: 0x1700A45F RID: 42079
		// (get) Token: 0x06024E28 RID: 151080 RVA: 0x005172C4 File Offset: 0x005154C4
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

		// Token: 0x06024E29 RID: 151081 RVA: 0x00517300 File Offset: 0x00515500
		public TTable? EnterMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024E2A RID: 151082 RVA: 0x00517344 File Offset: 0x00515544
		public IMontageAsset EnterMontageAsIMontageAsset()
		{
			return this.EnterMontage<IMontageAsset>().Value;
		}

		// Token: 0x06024E2B RID: 151083 RVA: 0x00517360 File Offset: 0x00515560
		public IMontageRegistered EnterMontageAsIMontageRegistered()
		{
			return this.EnterMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700A460 RID: 42080
		// (get) Token: 0x06024E2C RID: 151084 RVA: 0x0051737C File Offset: 0x0051557C
		public TMontageConfig StandByMontageType
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

		// Token: 0x06024E2D RID: 151085 RVA: 0x005173BC File Offset: 0x005155BC
		public TTable? StandByMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024E2E RID: 151086 RVA: 0x00517404 File Offset: 0x00515604
		public IMontageAsset StandByMontageAsIMontageAsset()
		{
			return this.StandByMontage<IMontageAsset>().Value;
		}

		// Token: 0x06024E2F RID: 151087 RVA: 0x00517420 File Offset: 0x00515620
		public IMontageRegistered StandByMontageAsIMontageRegistered()
		{
			return this.StandByMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700A461 RID: 42081
		// (get) Token: 0x06024E30 RID: 151088 RVA: 0x0051743C File Offset: 0x0051563C
		public TMontageConfig ShopSuccessMontageType
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

		// Token: 0x06024E31 RID: 151089 RVA: 0x0051747C File Offset: 0x0051567C
		public TTable? ShopSuccessMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024E32 RID: 151090 RVA: 0x005174C4 File Offset: 0x005156C4
		public IMontageAsset ShopSuccessMontageAsIMontageAsset()
		{
			return this.ShopSuccessMontage<IMontageAsset>().Value;
		}

		// Token: 0x06024E33 RID: 151091 RVA: 0x005174E0 File Offset: 0x005156E0
		public IMontageRegistered ShopSuccessMontageAsIMontageRegistered()
		{
			return this.ShopSuccessMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700A462 RID: 42082
		// (get) Token: 0x06024E34 RID: 151092 RVA: 0x005174FC File Offset: 0x005156FC
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

		// Token: 0x1700A463 RID: 42083
		// (get) Token: 0x06024E35 RID: 151093 RVA: 0x0051755C File Offset: 0x0051575C
		public IPlayFlow? ShopSuccessFlow
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

		// Token: 0x1700A464 RID: 42084
		// (get) Token: 0x06024E36 RID: 151094 RVA: 0x005175BC File Offset: 0x005157BC
		public IPlayFlow? ShopFailedFlow
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

		// Token: 0x1700A465 RID: 42085
		// (get) Token: 0x06024E37 RID: 151095 RVA: 0x0051761C File Offset: 0x0051581C
		public IPlayFlow? WorkingFlow
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

		// Token: 0x1700A466 RID: 42086
		// (get) Token: 0x06024E38 RID: 151096 RVA: 0x0051767C File Offset: 0x0051587C
		public TMontageConfig ExitMontageType
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return TMontageConfig.NONE;
				}
				return (TMontageConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024E39 RID: 151097 RVA: 0x005176BC File Offset: 0x005158BC
		public TTable? ExitMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024E3A RID: 151098 RVA: 0x00517704 File Offset: 0x00515904
		public IMontageAsset ExitMontageAsIMontageAsset()
		{
			return this.ExitMontage<IMontageAsset>().Value;
		}

		// Token: 0x06024E3B RID: 151099 RVA: 0x00517720 File Offset: 0x00515920
		public IMontageRegistered ExitMontageAsIMontageRegistered()
		{
			return this.ExitMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700A467 RID: 42087
		// (get) Token: 0x06024E3C RID: 151100 RVA: 0x0051773C File Offset: 0x0051593C
		public IPlayFlow? ExitFlow
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06024E3D RID: 151101 RVA: 0x0051779C File Offset: 0x0051599C
		public static Offset<INpcUiInteractOnShopNew> CreateINpcUiInteractOnShopNew(FlatBufferBuilder builder, ENpcUiInteractType Type = ENpcUiInteractType.HandInItem, TMontageConfig EnterMontage_type = TMontageConfig.NONE, int EnterMontageOffset = 0, TMontageConfig StandByMontage_type = TMontageConfig.NONE, int StandByMontageOffset = 0, TMontageConfig ShopSuccessMontage_type = TMontageConfig.NONE, int ShopSuccessMontageOffset = 0, Offset<IPlayFlow> EnterFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> ShopSuccessFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> ShopFailedFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> WorkingFlowOffset = default(Offset<IPlayFlow>), TMontageConfig ExitMontage_type = TMontageConfig.NONE, int ExitMontageOffset = 0, Offset<IPlayFlow> ExitFlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(14);
			INpcUiInteractOnShopNew.AddExitFlow(builder, ExitFlowOffset);
			INpcUiInteractOnShopNew.AddExitMontage(builder, ExitMontageOffset);
			INpcUiInteractOnShopNew.AddWorkingFlow(builder, WorkingFlowOffset);
			INpcUiInteractOnShopNew.AddShopFailedFlow(builder, ShopFailedFlowOffset);
			INpcUiInteractOnShopNew.AddShopSuccessFlow(builder, ShopSuccessFlowOffset);
			INpcUiInteractOnShopNew.AddEnterFlow(builder, EnterFlowOffset);
			INpcUiInteractOnShopNew.AddShopSuccessMontage(builder, ShopSuccessMontageOffset);
			INpcUiInteractOnShopNew.AddStandByMontage(builder, StandByMontageOffset);
			INpcUiInteractOnShopNew.AddEnterMontage(builder, EnterMontageOffset);
			INpcUiInteractOnShopNew.AddExitMontageType(builder, ExitMontage_type);
			INpcUiInteractOnShopNew.AddShopSuccessMontageType(builder, ShopSuccessMontage_type);
			INpcUiInteractOnShopNew.AddStandByMontageType(builder, StandByMontage_type);
			INpcUiInteractOnShopNew.AddEnterMontageType(builder, EnterMontage_type);
			INpcUiInteractOnShopNew.AddType(builder, Type);
			return INpcUiInteractOnShopNew.EndINpcUiInteractOnShopNew(builder);
		}

		// Token: 0x06024E3E RID: 151102 RVA: 0x00517824 File Offset: 0x00515A24
		public static void StartINpcUiInteractOnShopNew(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x06024E3F RID: 151103 RVA: 0x0051782E File Offset: 0x00515A2E
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024E40 RID: 151104 RVA: 0x00517839 File Offset: 0x00515A39
		public static void AddEnterMontageType(FlatBufferBuilder builder, TMontageConfig enterMontageType)
		{
			builder.AddByte(1, (byte)enterMontageType, 0);
		}

		// Token: 0x06024E41 RID: 151105 RVA: 0x00517844 File Offset: 0x00515A44
		public static void AddEnterMontage(FlatBufferBuilder builder, int enterMontageOffset)
		{
			builder.AddOffset(2, enterMontageOffset, 0);
		}

		// Token: 0x06024E42 RID: 151106 RVA: 0x0051784F File Offset: 0x00515A4F
		public static void AddStandByMontageType(FlatBufferBuilder builder, TMontageConfig standByMontageType)
		{
			builder.AddByte(3, (byte)standByMontageType, 0);
		}

		// Token: 0x06024E43 RID: 151107 RVA: 0x0051785A File Offset: 0x00515A5A
		public static void AddStandByMontage(FlatBufferBuilder builder, int standByMontageOffset)
		{
			builder.AddOffset(4, standByMontageOffset, 0);
		}

		// Token: 0x06024E44 RID: 151108 RVA: 0x00517865 File Offset: 0x00515A65
		public static void AddShopSuccessMontageType(FlatBufferBuilder builder, TMontageConfig shopSuccessMontageType)
		{
			builder.AddByte(5, (byte)shopSuccessMontageType, 0);
		}

		// Token: 0x06024E45 RID: 151109 RVA: 0x00517870 File Offset: 0x00515A70
		public static void AddShopSuccessMontage(FlatBufferBuilder builder, int shopSuccessMontageOffset)
		{
			builder.AddOffset(6, shopSuccessMontageOffset, 0);
		}

		// Token: 0x06024E46 RID: 151110 RVA: 0x0051787B File Offset: 0x00515A7B
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(7, enterFlowOffset.Value, 0);
		}

		// Token: 0x06024E47 RID: 151111 RVA: 0x0051788B File Offset: 0x00515A8B
		public static void AddShopSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopSuccessFlowOffset)
		{
			builder.AddOffset(8, shopSuccessFlowOffset.Value, 0);
		}

		// Token: 0x06024E48 RID: 151112 RVA: 0x0051789B File Offset: 0x00515A9B
		public static void AddShopFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopFailedFlowOffset)
		{
			builder.AddOffset(9, shopFailedFlowOffset.Value, 0);
		}

		// Token: 0x06024E49 RID: 151113 RVA: 0x005178AC File Offset: 0x00515AAC
		public static void AddWorkingFlow(FlatBufferBuilder builder, Offset<IPlayFlow> workingFlowOffset)
		{
			builder.AddOffset(10, workingFlowOffset.Value, 0);
		}

		// Token: 0x06024E4A RID: 151114 RVA: 0x005178BD File Offset: 0x00515ABD
		public static void AddExitMontageType(FlatBufferBuilder builder, TMontageConfig exitMontageType)
		{
			builder.AddByte(11, (byte)exitMontageType, 0);
		}

		// Token: 0x06024E4B RID: 151115 RVA: 0x005178C9 File Offset: 0x00515AC9
		public static void AddExitMontage(FlatBufferBuilder builder, int exitMontageOffset)
		{
			builder.AddOffset(12, exitMontageOffset, 0);
		}

		// Token: 0x06024E4C RID: 151116 RVA: 0x005178D5 File Offset: 0x00515AD5
		public static void AddExitFlow(FlatBufferBuilder builder, Offset<IPlayFlow> exitFlowOffset)
		{
			builder.AddOffset(13, exitFlowOffset.Value, 0);
		}

		// Token: 0x06024E4D RID: 151117 RVA: 0x005178E6 File Offset: 0x00515AE6
		public static Offset<INpcUiInteractOnShopNew> EndINpcUiInteractOnShopNew(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnShopNew>(builder.EndTable());
		}

		// Token: 0x06024E4E RID: 151118 RVA: 0x005178F4 File Offset: 0x00515AF4
		public INpcUiInteractOnShopNewT UnPack()
		{
			INpcUiInteractOnShopNewT npcUiInteractOnShopNewT = new INpcUiInteractOnShopNewT();
			this.UnPackTo(npcUiInteractOnShopNewT);
			return npcUiInteractOnShopNewT;
		}

		// Token: 0x06024E4F RID: 151119 RVA: 0x00517910 File Offset: 0x00515B10
		public void UnPackTo(INpcUiInteractOnShopNewT _o)
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
			_o.StandByMontage = new TMontageConfigUnion();
			_o.StandByMontage.Type = this.StandByMontageType;
			tmontageConfig = this.StandByMontageType;
			if (tmontageConfig != TMontageConfig.IMontageAsset)
			{
				if (tmontageConfig == TMontageConfig.IMontageRegistered)
				{
					_o.StandByMontage.Value = ((this.StandByMontage<IMontageRegistered>() != null) ? this.StandByMontage<IMontageRegistered>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.StandByMontage.Value = ((this.StandByMontage<IMontageAsset>() != null) ? this.StandByMontage<IMontageAsset>().Value.UnPack() : null);
			}
			_o.ShopSuccessMontage = new TMontageConfigUnion();
			_o.ShopSuccessMontage.Type = this.ShopSuccessMontageType;
			tmontageConfig = this.ShopSuccessMontageType;
			if (tmontageConfig != TMontageConfig.IMontageAsset)
			{
				if (tmontageConfig == TMontageConfig.IMontageRegistered)
				{
					_o.ShopSuccessMontage.Value = ((this.ShopSuccessMontage<IMontageRegistered>() != null) ? this.ShopSuccessMontage<IMontageRegistered>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.ShopSuccessMontage.Value = ((this.ShopSuccessMontage<IMontageAsset>() != null) ? this.ShopSuccessMontage<IMontageAsset>().Value.UnPack() : null);
			}
			_o.EnterFlow = ((this.EnterFlow != null) ? this.EnterFlow.Value.UnPack() : null);
			_o.ShopSuccessFlow = ((this.ShopSuccessFlow != null) ? this.ShopSuccessFlow.Value.UnPack() : null);
			_o.ShopFailedFlow = ((this.ShopFailedFlow != null) ? this.ShopFailedFlow.Value.UnPack() : null);
			_o.WorkingFlow = ((this.WorkingFlow != null) ? this.WorkingFlow.Value.UnPack() : null);
			_o.ExitMontage = new TMontageConfigUnion();
			_o.ExitMontage.Type = this.ExitMontageType;
			tmontageConfig = this.ExitMontageType;
			if (tmontageConfig != TMontageConfig.IMontageAsset)
			{
				if (tmontageConfig == TMontageConfig.IMontageRegistered)
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

		// Token: 0x06024E50 RID: 151120 RVA: 0x00517C84 File Offset: 0x00515E84
		public static Offset<INpcUiInteractOnShopNew> Pack(FlatBufferBuilder builder, INpcUiInteractOnShopNewT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcUiInteractOnShopNew>);
			}
			TMontageConfig enterMontage_type = (_o.EnterMontage == null) ? TMontageConfig.NONE : _o.EnterMontage.Type;
			int enterMontageOffset = (_o.EnterMontage == null) ? 0 : TMontageConfigUnion.Pack(builder, _o.EnterMontage);
			TMontageConfig standByMontage_type = (_o.StandByMontage == null) ? TMontageConfig.NONE : _o.StandByMontage.Type;
			int standByMontageOffset = (_o.StandByMontage == null) ? 0 : TMontageConfigUnion.Pack(builder, _o.StandByMontage);
			TMontageConfig shopSuccessMontage_type = (_o.ShopSuccessMontage == null) ? TMontageConfig.NONE : _o.ShopSuccessMontage.Type;
			int shopSuccessMontageOffset = (_o.ShopSuccessMontage == null) ? 0 : TMontageConfigUnion.Pack(builder, _o.ShopSuccessMontage);
			Offset<IPlayFlow> enterFlowOffset = (_o.EnterFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.EnterFlow);
			Offset<IPlayFlow> shopSuccessFlowOffset = (_o.ShopSuccessFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.ShopSuccessFlow);
			Offset<IPlayFlow> shopFailedFlowOffset = (_o.ShopFailedFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.ShopFailedFlow);
			Offset<IPlayFlow> workingFlowOffset = (_o.WorkingFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.WorkingFlow);
			TMontageConfig exitMontage_type = (_o.ExitMontage == null) ? TMontageConfig.NONE : _o.ExitMontage.Type;
			int exitMontageOffset = (_o.ExitMontage == null) ? 0 : TMontageConfigUnion.Pack(builder, _o.ExitMontage);
			Offset<IPlayFlow> exitFlowOffset = (_o.ExitFlow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.ExitFlow);
			return INpcUiInteractOnShopNew.CreateINpcUiInteractOnShopNew(builder, _o.Type, enterMontage_type, enterMontageOffset, standByMontage_type, standByMontageOffset, shopSuccessMontage_type, shopSuccessMontageOffset, enterFlowOffset, shopSuccessFlowOffset, shopFailedFlowOffset, workingFlowOffset, exitMontage_type, exitMontageOffset, exitFlowOffset);
		}

		// Token: 0x0400EA69 RID: 60009
		private Table __p;
	}
}
