using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C1B RID: 23579
	public struct INpcUiInteractOnShop : IFlatbufferObject
	{
		// Token: 0x1700ACD7 RID: 44247
		// (get) Token: 0x0602701A RID: 159770 RVA: 0x00557281 File Offset: 0x00555481
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602701B RID: 159771 RVA: 0x0055728E File Offset: 0x0055548E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602701C RID: 159772 RVA: 0x00557298 File Offset: 0x00555498
		public static INpcUiInteractOnShop GetRootAsINpcUiInteractOnShop(ByteBuffer _bb)
		{
			return INpcUiInteractOnShop.GetRootAsINpcUiInteractOnShop(_bb, default(INpcUiInteractOnShop));
		}

		// Token: 0x0602701D RID: 159773 RVA: 0x005572B4 File Offset: 0x005554B4
		public static INpcUiInteractOnShop GetRootAsINpcUiInteractOnShop(ByteBuffer _bb, INpcUiInteractOnShop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602701E RID: 159774 RVA: 0x005572D1 File Offset: 0x005554D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602701F RID: 159775 RVA: 0x005572E0 File Offset: 0x005554E0
		public INpcUiInteractOnShop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ACD8 RID: 44248
		// (get) Token: 0x06027020 RID: 159776 RVA: 0x005572F0 File Offset: 0x005554F0
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

		// Token: 0x1700ACD9 RID: 44249
		// (get) Token: 0x06027021 RID: 159777 RVA: 0x0055732C File Offset: 0x0055552C
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

		// Token: 0x06027022 RID: 159778 RVA: 0x00557363 File Offset: 0x00555563
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06027023 RID: 159779 RVA: 0x00557372 File Offset: 0x00555572
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700ACDA RID: 44250
		// (get) Token: 0x06027024 RID: 159780 RVA: 0x00557380 File Offset: 0x00555580
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

		// Token: 0x06027025 RID: 159781 RVA: 0x005573B7 File Offset: 0x005555B7
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06027026 RID: 159782 RVA: 0x005573C6 File Offset: 0x005555C6
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700ACDB RID: 44251
		// (get) Token: 0x06027027 RID: 159783 RVA: 0x005573D4 File Offset: 0x005555D4
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

		// Token: 0x06027028 RID: 159784 RVA: 0x0055740C File Offset: 0x0055560C
		public Span<byte> GetShopSuccessMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06027029 RID: 159785 RVA: 0x0055741C File Offset: 0x0055561C
		public byte[] GetShopSuccessMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700ACDC RID: 44252
		// (get) Token: 0x0602702A RID: 159786 RVA: 0x0055742C File Offset: 0x0055562C
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

		// Token: 0x1700ACDD RID: 44253
		// (get) Token: 0x0602702B RID: 159787 RVA: 0x0055748C File Offset: 0x0055568C
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

		// Token: 0x1700ACDE RID: 44254
		// (get) Token: 0x0602702C RID: 159788 RVA: 0x005574EC File Offset: 0x005556EC
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

		// Token: 0x1700ACDF RID: 44255
		// (get) Token: 0x0602702D RID: 159789 RVA: 0x0055754C File Offset: 0x0055574C
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

		// Token: 0x1700ACE0 RID: 44256
		// (get) Token: 0x0602702E RID: 159790 RVA: 0x005575AC File Offset: 0x005557AC
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

		// Token: 0x0602702F RID: 159791 RVA: 0x005575EC File Offset: 0x005557EC
		public TTable? ExitMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06027030 RID: 159792 RVA: 0x00557634 File Offset: 0x00555834
		public IMontageAsset ExitMontageAsIMontageAsset()
		{
			return this.ExitMontage<IMontageAsset>().Value;
		}

		// Token: 0x06027031 RID: 159793 RVA: 0x00557650 File Offset: 0x00555850
		public IMontageRegistered ExitMontageAsIMontageRegistered()
		{
			return this.ExitMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700ACE1 RID: 44257
		// (get) Token: 0x06027032 RID: 159794 RVA: 0x0055766C File Offset: 0x0055586C
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

		// Token: 0x06027033 RID: 159795 RVA: 0x005576CC File Offset: 0x005558CC
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

		// Token: 0x06027034 RID: 159796 RVA: 0x0055773C File Offset: 0x0055593C
		public static void StartINpcUiInteractOnShop(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x06027035 RID: 159797 RVA: 0x00557746 File Offset: 0x00555946
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027036 RID: 159798 RVA: 0x00557751 File Offset: 0x00555951
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x06027037 RID: 159799 RVA: 0x00557761 File Offset: 0x00555961
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x06027038 RID: 159800 RVA: 0x00557771 File Offset: 0x00555971
		public static void AddShopSuccessMontage(FlatBufferBuilder builder, StringOffset shopSuccessMontageOffset)
		{
			builder.AddOffset(3, shopSuccessMontageOffset.Value, 0);
		}

		// Token: 0x06027039 RID: 159801 RVA: 0x00557781 File Offset: 0x00555981
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(4, enterFlowOffset.Value, 0);
		}

		// Token: 0x0602703A RID: 159802 RVA: 0x00557791 File Offset: 0x00555991
		public static void AddShopSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopSuccessFlowOffset)
		{
			builder.AddOffset(5, shopSuccessFlowOffset.Value, 0);
		}

		// Token: 0x0602703B RID: 159803 RVA: 0x005577A1 File Offset: 0x005559A1
		public static void AddShopFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopFailedFlowOffset)
		{
			builder.AddOffset(6, shopFailedFlowOffset.Value, 0);
		}

		// Token: 0x0602703C RID: 159804 RVA: 0x005577B1 File Offset: 0x005559B1
		public static void AddWorkingFlow(FlatBufferBuilder builder, Offset<IPlayFlow> workingFlowOffset)
		{
			builder.AddOffset(7, workingFlowOffset.Value, 0);
		}

		// Token: 0x0602703D RID: 159805 RVA: 0x005577C1 File Offset: 0x005559C1
		public static void AddExitMontageType(FlatBufferBuilder builder, TMontageConfig exitMontageType)
		{
			builder.AddByte(8, (byte)exitMontageType, 0);
		}

		// Token: 0x0602703E RID: 159806 RVA: 0x005577CC File Offset: 0x005559CC
		public static void AddExitMontage(FlatBufferBuilder builder, int exitMontageOffset)
		{
			builder.AddOffset(9, exitMontageOffset, 0);
		}

		// Token: 0x0602703F RID: 159807 RVA: 0x005577D8 File Offset: 0x005559D8
		public static void AddExitFlow(FlatBufferBuilder builder, Offset<IPlayFlow> exitFlowOffset)
		{
			builder.AddOffset(10, exitFlowOffset.Value, 0);
		}

		// Token: 0x06027040 RID: 159808 RVA: 0x005577E9 File Offset: 0x005559E9
		public static Offset<INpcUiInteractOnShop> EndINpcUiInteractOnShop(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnShop>(builder.EndTable());
		}

		// Token: 0x06027041 RID: 159809 RVA: 0x005577F8 File Offset: 0x005559F8
		public INpcUiInteractOnShopT UnPack()
		{
			INpcUiInteractOnShopT npcUiInteractOnShopT = new INpcUiInteractOnShopT();
			this.UnPackTo(npcUiInteractOnShopT);
			return npcUiInteractOnShopT;
		}

		// Token: 0x06027042 RID: 159810 RVA: 0x00557814 File Offset: 0x00555A14
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

		// Token: 0x06027043 RID: 159811 RVA: 0x005579D8 File Offset: 0x00555BD8
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

		// Token: 0x0400F6C7 RID: 63175
		private Table __p;
	}
}
