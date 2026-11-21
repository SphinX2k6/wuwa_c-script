using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C21 RID: 23585
	public struct INpcUiInteractOnSoundBox3 : IFlatbufferObject
	{
		// Token: 0x1700AD01 RID: 44289
		// (get) Token: 0x060270A0 RID: 159904 RVA: 0x00558CC3 File Offset: 0x00556EC3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060270A1 RID: 159905 RVA: 0x00558CD0 File Offset: 0x00556ED0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060270A2 RID: 159906 RVA: 0x00558CD8 File Offset: 0x00556ED8
		public static INpcUiInteractOnSoundBox3 GetRootAsINpcUiInteractOnSoundBox3(ByteBuffer _bb)
		{
			return INpcUiInteractOnSoundBox3.GetRootAsINpcUiInteractOnSoundBox3(_bb, default(INpcUiInteractOnSoundBox3));
		}

		// Token: 0x060270A3 RID: 159907 RVA: 0x00558CF4 File Offset: 0x00556EF4
		public static INpcUiInteractOnSoundBox3 GetRootAsINpcUiInteractOnSoundBox3(ByteBuffer _bb, INpcUiInteractOnSoundBox3 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060270A4 RID: 159908 RVA: 0x00558D11 File Offset: 0x00556F11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060270A5 RID: 159909 RVA: 0x00558D20 File Offset: 0x00556F20
		public INpcUiInteractOnSoundBox3 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AD02 RID: 44290
		// (get) Token: 0x060270A6 RID: 159910 RVA: 0x00558D30 File Offset: 0x00556F30
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

		// Token: 0x1700AD03 RID: 44291
		// (get) Token: 0x060270A7 RID: 159911 RVA: 0x00558D6C File Offset: 0x00556F6C
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

		// Token: 0x060270A8 RID: 159912 RVA: 0x00558DA3 File Offset: 0x00556FA3
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060270A9 RID: 159913 RVA: 0x00558DB2 File Offset: 0x00556FB2
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AD04 RID: 44292
		// (get) Token: 0x060270AA RID: 159914 RVA: 0x00558DC0 File Offset: 0x00556FC0
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

		// Token: 0x060270AB RID: 159915 RVA: 0x00558DF7 File Offset: 0x00556FF7
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060270AC RID: 159916 RVA: 0x00558E06 File Offset: 0x00557006
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700AD05 RID: 44293
		// (get) Token: 0x060270AD RID: 159917 RVA: 0x00558E14 File Offset: 0x00557014
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

		// Token: 0x060270AE RID: 159918 RVA: 0x00558E4C File Offset: 0x0055704C
		public Span<byte> GetShopSuccessMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060270AF RID: 159919 RVA: 0x00558E5C File Offset: 0x0055705C
		public byte[] GetShopSuccessMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700AD06 RID: 44294
		// (get) Token: 0x060270B0 RID: 159920 RVA: 0x00558E6C File Offset: 0x0055706C
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

		// Token: 0x1700AD07 RID: 44295
		// (get) Token: 0x060270B1 RID: 159921 RVA: 0x00558ECC File Offset: 0x005570CC
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

		// Token: 0x1700AD08 RID: 44296
		// (get) Token: 0x060270B2 RID: 159922 RVA: 0x00558F2C File Offset: 0x0055712C
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

		// Token: 0x1700AD09 RID: 44297
		// (get) Token: 0x060270B3 RID: 159923 RVA: 0x00558F8C File Offset: 0x0055718C
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

		// Token: 0x060270B4 RID: 159924 RVA: 0x00558FC4 File Offset: 0x005571C4
		public Span<byte> GetUpgradeSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x060270B5 RID: 159925 RVA: 0x00558FD4 File Offset: 0x005571D4
		public byte[] GetUpgradeSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700AD0A RID: 44298
		// (get) Token: 0x060270B6 RID: 159926 RVA: 0x00558FE4 File Offset: 0x005571E4
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

		// Token: 0x1700AD0B RID: 44299
		// (get) Token: 0x060270B7 RID: 159927 RVA: 0x00559044 File Offset: 0x00557244
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

		// Token: 0x060270B8 RID: 159928 RVA: 0x00559084 File Offset: 0x00557284
		public TTable? ExitMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060270B9 RID: 159929 RVA: 0x005590CC File Offset: 0x005572CC
		public IMontageAsset ExitMontageAsIMontageAsset()
		{
			return this.ExitMontage<IMontageAsset>().Value;
		}

		// Token: 0x060270BA RID: 159930 RVA: 0x005590E8 File Offset: 0x005572E8
		public IMontageRegistered ExitMontageAsIMontageRegistered()
		{
			return this.ExitMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700AD0C RID: 44300
		// (get) Token: 0x060270BB RID: 159931 RVA: 0x00559104 File Offset: 0x00557304
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

		// Token: 0x060270BC RID: 159932 RVA: 0x00559164 File Offset: 0x00557364
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

		// Token: 0x060270BD RID: 159933 RVA: 0x005591DC File Offset: 0x005573DC
		public static void StartINpcUiInteractOnSoundBox3(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x060270BE RID: 159934 RVA: 0x005591E6 File Offset: 0x005573E6
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060270BF RID: 159935 RVA: 0x005591F1 File Offset: 0x005573F1
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x060270C0 RID: 159936 RVA: 0x00559201 File Offset: 0x00557401
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x060270C1 RID: 159937 RVA: 0x00559211 File Offset: 0x00557411
		public static void AddShopSuccessMontage(FlatBufferBuilder builder, StringOffset shopSuccessMontageOffset)
		{
			builder.AddOffset(3, shopSuccessMontageOffset.Value, 0);
		}

		// Token: 0x060270C2 RID: 159938 RVA: 0x00559221 File Offset: 0x00557421
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(4, enterFlowOffset.Value, 0);
		}

		// Token: 0x060270C3 RID: 159939 RVA: 0x00559231 File Offset: 0x00557431
		public static void AddShopSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopSuccessFlowOffset)
		{
			builder.AddOffset(5, shopSuccessFlowOffset.Value, 0);
		}

		// Token: 0x060270C4 RID: 159940 RVA: 0x00559241 File Offset: 0x00557441
		public static void AddShopFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopFailedFlowOffset)
		{
			builder.AddOffset(6, shopFailedFlowOffset.Value, 0);
		}

		// Token: 0x060270C5 RID: 159941 RVA: 0x00559251 File Offset: 0x00557451
		public static void AddUpgradeSequence(FlatBufferBuilder builder, StringOffset upgradeSequenceOffset)
		{
			builder.AddOffset(7, upgradeSequenceOffset.Value, 0);
		}

		// Token: 0x060270C6 RID: 159942 RVA: 0x00559261 File Offset: 0x00557461
		public static void AddUpgradeFlow(FlatBufferBuilder builder, Offset<IPlayFlow> upgradeFlowOffset)
		{
			builder.AddOffset(8, upgradeFlowOffset.Value, 0);
		}

		// Token: 0x060270C7 RID: 159943 RVA: 0x00559271 File Offset: 0x00557471
		public static void AddExitMontageType(FlatBufferBuilder builder, TMontageConfig exitMontageType)
		{
			builder.AddByte(9, (byte)exitMontageType, 0);
		}

		// Token: 0x060270C8 RID: 159944 RVA: 0x0055927D File Offset: 0x0055747D
		public static void AddExitMontage(FlatBufferBuilder builder, int exitMontageOffset)
		{
			builder.AddOffset(10, exitMontageOffset, 0);
		}

		// Token: 0x060270C9 RID: 159945 RVA: 0x00559289 File Offset: 0x00557489
		public static void AddExitFlow(FlatBufferBuilder builder, Offset<IPlayFlow> exitFlowOffset)
		{
			builder.AddOffset(11, exitFlowOffset.Value, 0);
		}

		// Token: 0x060270CA RID: 159946 RVA: 0x0055929A File Offset: 0x0055749A
		public static Offset<INpcUiInteractOnSoundBox3> EndINpcUiInteractOnSoundBox3(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnSoundBox3>(builder.EndTable());
		}

		// Token: 0x060270CB RID: 159947 RVA: 0x005592A8 File Offset: 0x005574A8
		public INpcUiInteractOnSoundBox3T UnPack()
		{
			INpcUiInteractOnSoundBox3T npcUiInteractOnSoundBox3T = new INpcUiInteractOnSoundBox3T();
			this.UnPackTo(npcUiInteractOnSoundBox3T);
			return npcUiInteractOnSoundBox3T;
		}

		// Token: 0x060270CC RID: 159948 RVA: 0x005592C4 File Offset: 0x005574C4
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

		// Token: 0x060270CD RID: 159949 RVA: 0x00559494 File Offset: 0x00557694
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

		// Token: 0x0400F6DD RID: 63197
		private Table __p;
	}
}
