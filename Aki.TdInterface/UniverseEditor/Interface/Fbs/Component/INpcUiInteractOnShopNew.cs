using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C1E RID: 23582
	public struct INpcUiInteractOnShopNew : IFlatbufferObject
	{
		// Token: 0x1700ACEC RID: 44268
		// (get) Token: 0x0602705A RID: 159834 RVA: 0x00557DB8 File Offset: 0x00555FB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602705B RID: 159835 RVA: 0x00557DC5 File Offset: 0x00555FC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602705C RID: 159836 RVA: 0x00557DCC File Offset: 0x00555FCC
		public static INpcUiInteractOnShopNew GetRootAsINpcUiInteractOnShopNew(ByteBuffer _bb)
		{
			return INpcUiInteractOnShopNew.GetRootAsINpcUiInteractOnShopNew(_bb, default(INpcUiInteractOnShopNew));
		}

		// Token: 0x0602705D RID: 159837 RVA: 0x00557DE8 File Offset: 0x00555FE8
		public static INpcUiInteractOnShopNew GetRootAsINpcUiInteractOnShopNew(ByteBuffer _bb, INpcUiInteractOnShopNew obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602705E RID: 159838 RVA: 0x00557E05 File Offset: 0x00556005
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602705F RID: 159839 RVA: 0x00557E14 File Offset: 0x00556014
		public INpcUiInteractOnShopNew __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACED RID: 44269
		// (get) Token: 0x06027060 RID: 159840 RVA: 0x00557E24 File Offset: 0x00556024
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

		// Token: 0x1700ACEE RID: 44270
		// (get) Token: 0x06027061 RID: 159841 RVA: 0x00557E60 File Offset: 0x00556060
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

		// Token: 0x06027062 RID: 159842 RVA: 0x00557E9C File Offset: 0x0055609C
		public TTable? EnterMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027063 RID: 159843 RVA: 0x00557EE0 File Offset: 0x005560E0
		public IMontageAsset EnterMontageAsIMontageAsset()
		{
			return this.EnterMontage<IMontageAsset>().Value;
		}

		// Token: 0x06027064 RID: 159844 RVA: 0x00557EFC File Offset: 0x005560FC
		public IMontageRegistered EnterMontageAsIMontageRegistered()
		{
			return this.EnterMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700ACEF RID: 44271
		// (get) Token: 0x06027065 RID: 159845 RVA: 0x00557F18 File Offset: 0x00556118
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

		// Token: 0x06027066 RID: 159846 RVA: 0x00557F58 File Offset: 0x00556158
		public TTable? StandByMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027067 RID: 159847 RVA: 0x00557FA0 File Offset: 0x005561A0
		public IMontageAsset StandByMontageAsIMontageAsset()
		{
			return this.StandByMontage<IMontageAsset>().Value;
		}

		// Token: 0x06027068 RID: 159848 RVA: 0x00557FBC File Offset: 0x005561BC
		public IMontageRegistered StandByMontageAsIMontageRegistered()
		{
			return this.StandByMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700ACF0 RID: 44272
		// (get) Token: 0x06027069 RID: 159849 RVA: 0x00557FD8 File Offset: 0x005561D8
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

		// Token: 0x0602706A RID: 159850 RVA: 0x00558018 File Offset: 0x00556218
		public TTable? ShopSuccessMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602706B RID: 159851 RVA: 0x00558060 File Offset: 0x00556260
		public IMontageAsset ShopSuccessMontageAsIMontageAsset()
		{
			return this.ShopSuccessMontage<IMontageAsset>().Value;
		}

		// Token: 0x0602706C RID: 159852 RVA: 0x0055807C File Offset: 0x0055627C
		public IMontageRegistered ShopSuccessMontageAsIMontageRegistered()
		{
			return this.ShopSuccessMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700ACF1 RID: 44273
		// (get) Token: 0x0602706D RID: 159853 RVA: 0x00558098 File Offset: 0x00556298
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

		// Token: 0x1700ACF2 RID: 44274
		// (get) Token: 0x0602706E RID: 159854 RVA: 0x005580F8 File Offset: 0x005562F8
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

		// Token: 0x1700ACF3 RID: 44275
		// (get) Token: 0x0602706F RID: 159855 RVA: 0x00558158 File Offset: 0x00556358
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

		// Token: 0x1700ACF4 RID: 44276
		// (get) Token: 0x06027070 RID: 159856 RVA: 0x005581B8 File Offset: 0x005563B8
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

		// Token: 0x1700ACF5 RID: 44277
		// (get) Token: 0x06027071 RID: 159857 RVA: 0x00558218 File Offset: 0x00556418
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

		// Token: 0x06027072 RID: 159858 RVA: 0x00558258 File Offset: 0x00556458
		public TTable? ExitMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027073 RID: 159859 RVA: 0x005582A0 File Offset: 0x005564A0
		public IMontageAsset ExitMontageAsIMontageAsset()
		{
			return this.ExitMontage<IMontageAsset>().Value;
		}

		// Token: 0x06027074 RID: 159860 RVA: 0x005582BC File Offset: 0x005564BC
		public IMontageRegistered ExitMontageAsIMontageRegistered()
		{
			return this.ExitMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700ACF6 RID: 44278
		// (get) Token: 0x06027075 RID: 159861 RVA: 0x005582D8 File Offset: 0x005564D8
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

		// Token: 0x06027076 RID: 159862 RVA: 0x00558338 File Offset: 0x00556538
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

		// Token: 0x06027077 RID: 159863 RVA: 0x005583C0 File Offset: 0x005565C0
		public static void StartINpcUiInteractOnShopNew(FlatBufferBuilder builder)
		{
			builder.StartTable(14);
		}

		// Token: 0x06027078 RID: 159864 RVA: 0x005583CA File Offset: 0x005565CA
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027079 RID: 159865 RVA: 0x005583D5 File Offset: 0x005565D5
		public static void AddEnterMontageType(FlatBufferBuilder builder, TMontageConfig enterMontageType)
		{
			builder.AddByte(1, (byte)enterMontageType, 0);
		}

		// Token: 0x0602707A RID: 159866 RVA: 0x005583E0 File Offset: 0x005565E0
		public static void AddEnterMontage(FlatBufferBuilder builder, int enterMontageOffset)
		{
			builder.AddOffset(2, enterMontageOffset, 0);
		}

		// Token: 0x0602707B RID: 159867 RVA: 0x005583EB File Offset: 0x005565EB
		public static void AddStandByMontageType(FlatBufferBuilder builder, TMontageConfig standByMontageType)
		{
			builder.AddByte(3, (byte)standByMontageType, 0);
		}

		// Token: 0x0602707C RID: 159868 RVA: 0x005583F6 File Offset: 0x005565F6
		public static void AddStandByMontage(FlatBufferBuilder builder, int standByMontageOffset)
		{
			builder.AddOffset(4, standByMontageOffset, 0);
		}

		// Token: 0x0602707D RID: 159869 RVA: 0x00558401 File Offset: 0x00556601
		public static void AddShopSuccessMontageType(FlatBufferBuilder builder, TMontageConfig shopSuccessMontageType)
		{
			builder.AddByte(5, (byte)shopSuccessMontageType, 0);
		}

		// Token: 0x0602707E RID: 159870 RVA: 0x0055840C File Offset: 0x0055660C
		public static void AddShopSuccessMontage(FlatBufferBuilder builder, int shopSuccessMontageOffset)
		{
			builder.AddOffset(6, shopSuccessMontageOffset, 0);
		}

		// Token: 0x0602707F RID: 159871 RVA: 0x00558417 File Offset: 0x00556617
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(7, enterFlowOffset.Value, 0);
		}

		// Token: 0x06027080 RID: 159872 RVA: 0x00558427 File Offset: 0x00556627
		public static void AddShopSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopSuccessFlowOffset)
		{
			builder.AddOffset(8, shopSuccessFlowOffset.Value, 0);
		}

		// Token: 0x06027081 RID: 159873 RVA: 0x00558437 File Offset: 0x00556637
		public static void AddShopFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopFailedFlowOffset)
		{
			builder.AddOffset(9, shopFailedFlowOffset.Value, 0);
		}

		// Token: 0x06027082 RID: 159874 RVA: 0x00558448 File Offset: 0x00556648
		public static void AddWorkingFlow(FlatBufferBuilder builder, Offset<IPlayFlow> workingFlowOffset)
		{
			builder.AddOffset(10, workingFlowOffset.Value, 0);
		}

		// Token: 0x06027083 RID: 159875 RVA: 0x00558459 File Offset: 0x00556659
		public static void AddExitMontageType(FlatBufferBuilder builder, TMontageConfig exitMontageType)
		{
			builder.AddByte(11, (byte)exitMontageType, 0);
		}

		// Token: 0x06027084 RID: 159876 RVA: 0x00558465 File Offset: 0x00556665
		public static void AddExitMontage(FlatBufferBuilder builder, int exitMontageOffset)
		{
			builder.AddOffset(12, exitMontageOffset, 0);
		}

		// Token: 0x06027085 RID: 159877 RVA: 0x00558471 File Offset: 0x00556671
		public static void AddExitFlow(FlatBufferBuilder builder, Offset<IPlayFlow> exitFlowOffset)
		{
			builder.AddOffset(13, exitFlowOffset.Value, 0);
		}

		// Token: 0x06027086 RID: 159878 RVA: 0x00558482 File Offset: 0x00556682
		public static Offset<INpcUiInteractOnShopNew> EndINpcUiInteractOnShopNew(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnShopNew>(builder.EndTable());
		}

		// Token: 0x06027087 RID: 159879 RVA: 0x00558490 File Offset: 0x00556690
		public INpcUiInteractOnShopNewT UnPack()
		{
			INpcUiInteractOnShopNewT npcUiInteractOnShopNewT = new INpcUiInteractOnShopNewT();
			this.UnPackTo(npcUiInteractOnShopNewT);
			return npcUiInteractOnShopNewT;
		}

		// Token: 0x06027088 RID: 159880 RVA: 0x005584AC File Offset: 0x005566AC
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

		// Token: 0x06027089 RID: 159881 RVA: 0x00558820 File Offset: 0x00556A20
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

		// Token: 0x0400F6D2 RID: 63186
		private Table __p;
	}
}
