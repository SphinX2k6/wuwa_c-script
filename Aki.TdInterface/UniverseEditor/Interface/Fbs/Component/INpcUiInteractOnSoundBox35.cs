using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C24 RID: 23588
	public struct INpcUiInteractOnSoundBox35 : IFlatbufferObject
	{
		// Token: 0x1700AD18 RID: 44312
		// (get) Token: 0x060270E6 RID: 159974 RVA: 0x005598BB File Offset: 0x00557ABB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060270E7 RID: 159975 RVA: 0x005598C8 File Offset: 0x00557AC8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060270E8 RID: 159976 RVA: 0x005598D0 File Offset: 0x00557AD0
		public static INpcUiInteractOnSoundBox35 GetRootAsINpcUiInteractOnSoundBox35(ByteBuffer _bb)
		{
			return INpcUiInteractOnSoundBox35.GetRootAsINpcUiInteractOnSoundBox35(_bb, default(INpcUiInteractOnSoundBox35));
		}

		// Token: 0x060270E9 RID: 159977 RVA: 0x005598EC File Offset: 0x00557AEC
		public static INpcUiInteractOnSoundBox35 GetRootAsINpcUiInteractOnSoundBox35(ByteBuffer _bb, INpcUiInteractOnSoundBox35 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060270EA RID: 159978 RVA: 0x00559909 File Offset: 0x00557B09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060270EB RID: 159979 RVA: 0x00559918 File Offset: 0x00557B18
		public INpcUiInteractOnSoundBox35 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD19 RID: 44313
		// (get) Token: 0x060270EC RID: 159980 RVA: 0x00559928 File Offset: 0x00557B28
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

		// Token: 0x1700AD1A RID: 44314
		// (get) Token: 0x060270ED RID: 159981 RVA: 0x00559964 File Offset: 0x00557B64
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

		// Token: 0x060270EE RID: 159982 RVA: 0x0055999B File Offset: 0x00557B9B
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060270EF RID: 159983 RVA: 0x005599AA File Offset: 0x00557BAA
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AD1B RID: 44315
		// (get) Token: 0x060270F0 RID: 159984 RVA: 0x005599B8 File Offset: 0x00557BB8
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

		// Token: 0x060270F1 RID: 159985 RVA: 0x005599EF File Offset: 0x00557BEF
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060270F2 RID: 159986 RVA: 0x005599FE File Offset: 0x00557BFE
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700AD1C RID: 44316
		// (get) Token: 0x060270F3 RID: 159987 RVA: 0x00559A0C File Offset: 0x00557C0C
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

		// Token: 0x060270F4 RID: 159988 RVA: 0x00559A44 File Offset: 0x00557C44
		public Span<byte> GetShopSuccessMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060270F5 RID: 159989 RVA: 0x00559A54 File Offset: 0x00557C54
		public byte[] GetShopSuccessMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700AD1D RID: 44317
		// (get) Token: 0x060270F6 RID: 159990 RVA: 0x00559A64 File Offset: 0x00557C64
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

		// Token: 0x1700AD1E RID: 44318
		// (get) Token: 0x060270F7 RID: 159991 RVA: 0x00559AC4 File Offset: 0x00557CC4
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

		// Token: 0x1700AD1F RID: 44319
		// (get) Token: 0x060270F8 RID: 159992 RVA: 0x00559B24 File Offset: 0x00557D24
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

		// Token: 0x1700AD20 RID: 44320
		// (get) Token: 0x060270F9 RID: 159993 RVA: 0x00559B84 File Offset: 0x00557D84
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

		// Token: 0x060270FA RID: 159994 RVA: 0x00559BBC File Offset: 0x00557DBC
		public Span<byte> GetUpgradeSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060270FB RID: 159995 RVA: 0x00559BCC File Offset: 0x00557DCC
		public byte[] GetUpgradeSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700AD21 RID: 44321
		// (get) Token: 0x060270FC RID: 159996 RVA: 0x00559BDC File Offset: 0x00557DDC
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

		// Token: 0x1700AD22 RID: 44322
		// (get) Token: 0x060270FD RID: 159997 RVA: 0x00559C3C File Offset: 0x00557E3C
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

		// Token: 0x060270FE RID: 159998 RVA: 0x00559C7C File Offset: 0x00557E7C
		public TTable? ExitMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060270FF RID: 159999 RVA: 0x00559CC4 File Offset: 0x00557EC4
		public IMontageAsset ExitMontageAsIMontageAsset()
		{
			return this.ExitMontage<IMontageAsset>().Value;
		}

		// Token: 0x06027100 RID: 160000 RVA: 0x00559CE0 File Offset: 0x00557EE0
		public IMontageRegistered ExitMontageAsIMontageRegistered()
		{
			return this.ExitMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700AD23 RID: 44323
		// (get) Token: 0x06027101 RID: 160001 RVA: 0x00559CFC File Offset: 0x00557EFC
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

		// Token: 0x06027102 RID: 160002 RVA: 0x00559D5C File Offset: 0x00557F5C
		public static Offset<INpcUiInteractOnSoundBox35> CreateINpcUiInteractOnSoundBox35(FlatBufferBuilder builder, ENpcUiInteractType Type = ENpcUiInteractType.HandInItem, StringOffset EnterMontageOffset = default(StringOffset), StringOffset StandByMontageOffset = default(StringOffset), StringOffset ShopSuccessMontageOffset = default(StringOffset), Offset<IPlayFlow> EnterFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> ShopSuccessFlowOffset = default(Offset<IPlayFlow>), Offset<IPlayFlow> ShopFailedFlowOffset = default(Offset<IPlayFlow>), StringOffset UpgradeSequenceOffset = default(StringOffset), Offset<IPlayFlow> UpgradeFlowOffset = default(Offset<IPlayFlow>), TMontageConfig ExitMontage_type = TMontageConfig.NONE, int ExitMontageOffset = 0, Offset<IPlayFlow> ExitFlowOffset = default(Offset<IPlayFlow>))
		{
			builder.StartTable(12);
			INpcUiInteractOnSoundBox35.AddExitFlow(builder, ExitFlowOffset);
			INpcUiInteractOnSoundBox35.AddExitMontage(builder, ExitMontageOffset);
			INpcUiInteractOnSoundBox35.AddUpgradeFlow(builder, UpgradeFlowOffset);
			INpcUiInteractOnSoundBox35.AddUpgradeSequence(builder, UpgradeSequenceOffset);
			INpcUiInteractOnSoundBox35.AddShopFailedFlow(builder, ShopFailedFlowOffset);
			INpcUiInteractOnSoundBox35.AddShopSuccessFlow(builder, ShopSuccessFlowOffset);
			INpcUiInteractOnSoundBox35.AddEnterFlow(builder, EnterFlowOffset);
			INpcUiInteractOnSoundBox35.AddShopSuccessMontage(builder, ShopSuccessMontageOffset);
			INpcUiInteractOnSoundBox35.AddStandByMontage(builder, StandByMontageOffset);
			INpcUiInteractOnSoundBox35.AddEnterMontage(builder, EnterMontageOffset);
			INpcUiInteractOnSoundBox35.AddExitMontageType(builder, ExitMontage_type);
			INpcUiInteractOnSoundBox35.AddType(builder, Type);
			return INpcUiInteractOnSoundBox35.EndINpcUiInteractOnSoundBox35(builder);
		}

		// Token: 0x06027103 RID: 160003 RVA: 0x00559DD4 File Offset: 0x00557FD4
		public static void StartINpcUiInteractOnSoundBox35(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06027104 RID: 160004 RVA: 0x00559DDE File Offset: 0x00557FDE
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027105 RID: 160005 RVA: 0x00559DE9 File Offset: 0x00557FE9
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x06027106 RID: 160006 RVA: 0x00559DF9 File Offset: 0x00557FF9
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x06027107 RID: 160007 RVA: 0x00559E09 File Offset: 0x00558009
		public static void AddShopSuccessMontage(FlatBufferBuilder builder, StringOffset shopSuccessMontageOffset)
		{
			builder.AddOffset(3, shopSuccessMontageOffset.Value, 0);
		}

		// Token: 0x06027108 RID: 160008 RVA: 0x00559E19 File Offset: 0x00558019
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(4, enterFlowOffset.Value, 0);
		}

		// Token: 0x06027109 RID: 160009 RVA: 0x00559E29 File Offset: 0x00558029
		public static void AddShopSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopSuccessFlowOffset)
		{
			builder.AddOffset(5, shopSuccessFlowOffset.Value, 0);
		}

		// Token: 0x0602710A RID: 160010 RVA: 0x00559E39 File Offset: 0x00558039
		public static void AddShopFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopFailedFlowOffset)
		{
			builder.AddOffset(6, shopFailedFlowOffset.Value, 0);
		}

		// Token: 0x0602710B RID: 160011 RVA: 0x00559E49 File Offset: 0x00558049
		public static void AddUpgradeSequence(FlatBufferBuilder builder, StringOffset upgradeSequenceOffset)
		{
			builder.AddOffset(7, upgradeSequenceOffset.Value, 0);
		}

		// Token: 0x0602710C RID: 160012 RVA: 0x00559E59 File Offset: 0x00558059
		public static void AddUpgradeFlow(FlatBufferBuilder builder, Offset<IPlayFlow> upgradeFlowOffset)
		{
			builder.AddOffset(8, upgradeFlowOffset.Value, 0);
		}

		// Token: 0x0602710D RID: 160013 RVA: 0x00559E69 File Offset: 0x00558069
		public static void AddExitMontageType(FlatBufferBuilder builder, TMontageConfig exitMontageType)
		{
			builder.AddByte(9, (byte)exitMontageType, 0);
		}

		// Token: 0x0602710E RID: 160014 RVA: 0x00559E75 File Offset: 0x00558075
		public static void AddExitMontage(FlatBufferBuilder builder, int exitMontageOffset)
		{
			builder.AddOffset(10, exitMontageOffset, 0);
		}

		// Token: 0x0602710F RID: 160015 RVA: 0x00559E81 File Offset: 0x00558081
		public static void AddExitFlow(FlatBufferBuilder builder, Offset<IPlayFlow> exitFlowOffset)
		{
			builder.AddOffset(11, exitFlowOffset.Value, 0);
		}

		// Token: 0x06027110 RID: 160016 RVA: 0x00559E92 File Offset: 0x00558092
		public static Offset<INpcUiInteractOnSoundBox35> EndINpcUiInteractOnSoundBox35(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnSoundBox35>(builder.EndTable());
		}

		// Token: 0x06027111 RID: 160017 RVA: 0x00559EA0 File Offset: 0x005580A0
		public INpcUiInteractOnSoundBox35T UnPack()
		{
			INpcUiInteractOnSoundBox35T npcUiInteractOnSoundBox35T = new INpcUiInteractOnSoundBox35T();
			this.UnPackTo(npcUiInteractOnSoundBox35T);
			return npcUiInteractOnSoundBox35T;
		}

		// Token: 0x06027112 RID: 160018 RVA: 0x00559EBC File Offset: 0x005580BC
		public void UnPackTo(INpcUiInteractOnSoundBox35T _o)
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

		// Token: 0x06027113 RID: 160019 RVA: 0x0055A08C File Offset: 0x0055828C
		public static Offset<INpcUiInteractOnSoundBox35> Pack(FlatBufferBuilder builder, INpcUiInteractOnSoundBox35T _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcUiInteractOnSoundBox35>);
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
			return INpcUiInteractOnSoundBox35.CreateINpcUiInteractOnSoundBox35(builder, _o.Type, enterMontageOffset, standByMontageOffset, shopSuccessMontageOffset, enterFlowOffset, shopSuccessFlowOffset, shopFailedFlowOffset, upgradeSequenceOffset, upgradeFlowOffset, exitMontage_type, exitMontageOffset, exitFlowOffset);
		}

		// Token: 0x0400F6E9 RID: 63209
		private Table __p;
	}
}
