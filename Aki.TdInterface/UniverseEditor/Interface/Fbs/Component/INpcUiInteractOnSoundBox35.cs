using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005683 RID: 22147
	public struct INpcUiInteractOnSoundBox35 : IFlatbufferObject
	{
		// Token: 0x1700A489 RID: 42121
		// (get) Token: 0x06024EAD RID: 151213 RVA: 0x00518D1F File Offset: 0x00516F1F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024EAE RID: 151214 RVA: 0x00518D2C File Offset: 0x00516F2C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024EAF RID: 151215 RVA: 0x00518D34 File Offset: 0x00516F34
		public static INpcUiInteractOnSoundBox35 GetRootAsINpcUiInteractOnSoundBox35(ByteBuffer _bb)
		{
			return INpcUiInteractOnSoundBox35.GetRootAsINpcUiInteractOnSoundBox35(_bb, default(INpcUiInteractOnSoundBox35));
		}

		// Token: 0x06024EB0 RID: 151216 RVA: 0x00518D50 File Offset: 0x00516F50
		public static INpcUiInteractOnSoundBox35 GetRootAsINpcUiInteractOnSoundBox35(ByteBuffer _bb, INpcUiInteractOnSoundBox35 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024EB1 RID: 151217 RVA: 0x00518D6D File Offset: 0x00516F6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024EB2 RID: 151218 RVA: 0x00518D7C File Offset: 0x00516F7C
		public INpcUiInteractOnSoundBox35 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A48A RID: 42122
		// (get) Token: 0x06024EB3 RID: 151219 RVA: 0x00518D8C File Offset: 0x00516F8C
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

		// Token: 0x1700A48B RID: 42123
		// (get) Token: 0x06024EB4 RID: 151220 RVA: 0x00518DC8 File Offset: 0x00516FC8
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

		// Token: 0x06024EB5 RID: 151221 RVA: 0x00518DFF File Offset: 0x00516FFF
		public Span<byte> GetEnterMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06024EB6 RID: 151222 RVA: 0x00518E0E File Offset: 0x0051700E
		public byte[] GetEnterMontageArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700A48C RID: 42124
		// (get) Token: 0x06024EB7 RID: 151223 RVA: 0x00518E1C File Offset: 0x0051701C
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

		// Token: 0x06024EB8 RID: 151224 RVA: 0x00518E53 File Offset: 0x00517053
		public Span<byte> GetStandByMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06024EB9 RID: 151225 RVA: 0x00518E62 File Offset: 0x00517062
		public byte[] GetStandByMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A48D RID: 42125
		// (get) Token: 0x06024EBA RID: 151226 RVA: 0x00518E70 File Offset: 0x00517070
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

		// Token: 0x06024EBB RID: 151227 RVA: 0x00518EA8 File Offset: 0x005170A8
		public Span<byte> GetShopSuccessMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06024EBC RID: 151228 RVA: 0x00518EB8 File Offset: 0x005170B8
		public byte[] GetShopSuccessMontageArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700A48E RID: 42126
		// (get) Token: 0x06024EBD RID: 151229 RVA: 0x00518EC8 File Offset: 0x005170C8
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

		// Token: 0x1700A48F RID: 42127
		// (get) Token: 0x06024EBE RID: 151230 RVA: 0x00518F28 File Offset: 0x00517128
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

		// Token: 0x1700A490 RID: 42128
		// (get) Token: 0x06024EBF RID: 151231 RVA: 0x00518F88 File Offset: 0x00517188
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

		// Token: 0x1700A491 RID: 42129
		// (get) Token: 0x06024EC0 RID: 151232 RVA: 0x00518FE8 File Offset: 0x005171E8
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

		// Token: 0x06024EC1 RID: 151233 RVA: 0x00519020 File Offset: 0x00517220
		public Span<byte> GetUpgradeSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06024EC2 RID: 151234 RVA: 0x00519030 File Offset: 0x00517230
		public byte[] GetUpgradeSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(18);
		}

		// Token: 0x1700A492 RID: 42130
		// (get) Token: 0x06024EC3 RID: 151235 RVA: 0x00519040 File Offset: 0x00517240
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

		// Token: 0x1700A493 RID: 42131
		// (get) Token: 0x06024EC4 RID: 151236 RVA: 0x005190A0 File Offset: 0x005172A0
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

		// Token: 0x06024EC5 RID: 151237 RVA: 0x005190E0 File Offset: 0x005172E0
		public TTable? ExitMontage<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06024EC6 RID: 151238 RVA: 0x00519128 File Offset: 0x00517328
		public IMontageAsset ExitMontageAsIMontageAsset()
		{
			return this.ExitMontage<IMontageAsset>().Value;
		}

		// Token: 0x06024EC7 RID: 151239 RVA: 0x00519144 File Offset: 0x00517344
		public IMontageRegistered ExitMontageAsIMontageRegistered()
		{
			return this.ExitMontage<IMontageRegistered>().Value;
		}

		// Token: 0x1700A494 RID: 42132
		// (get) Token: 0x06024EC8 RID: 151240 RVA: 0x00519160 File Offset: 0x00517360
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

		// Token: 0x06024EC9 RID: 151241 RVA: 0x005191C0 File Offset: 0x005173C0
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

		// Token: 0x06024ECA RID: 151242 RVA: 0x00519238 File Offset: 0x00517438
		public static void StartINpcUiInteractOnSoundBox35(FlatBufferBuilder builder)
		{
			builder.StartTable(12);
		}

		// Token: 0x06024ECB RID: 151243 RVA: 0x00519242 File Offset: 0x00517442
		public static void AddType(FlatBufferBuilder builder, ENpcUiInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024ECC RID: 151244 RVA: 0x0051924D File Offset: 0x0051744D
		public static void AddEnterMontage(FlatBufferBuilder builder, StringOffset enterMontageOffset)
		{
			builder.AddOffset(1, enterMontageOffset.Value, 0);
		}

		// Token: 0x06024ECD RID: 151245 RVA: 0x0051925D File Offset: 0x0051745D
		public static void AddStandByMontage(FlatBufferBuilder builder, StringOffset standByMontageOffset)
		{
			builder.AddOffset(2, standByMontageOffset.Value, 0);
		}

		// Token: 0x06024ECE RID: 151246 RVA: 0x0051926D File Offset: 0x0051746D
		public static void AddShopSuccessMontage(FlatBufferBuilder builder, StringOffset shopSuccessMontageOffset)
		{
			builder.AddOffset(3, shopSuccessMontageOffset.Value, 0);
		}

		// Token: 0x06024ECF RID: 151247 RVA: 0x0051927D File Offset: 0x0051747D
		public static void AddEnterFlow(FlatBufferBuilder builder, Offset<IPlayFlow> enterFlowOffset)
		{
			builder.AddOffset(4, enterFlowOffset.Value, 0);
		}

		// Token: 0x06024ED0 RID: 151248 RVA: 0x0051928D File Offset: 0x0051748D
		public static void AddShopSuccessFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopSuccessFlowOffset)
		{
			builder.AddOffset(5, shopSuccessFlowOffset.Value, 0);
		}

		// Token: 0x06024ED1 RID: 151249 RVA: 0x0051929D File Offset: 0x0051749D
		public static void AddShopFailedFlow(FlatBufferBuilder builder, Offset<IPlayFlow> shopFailedFlowOffset)
		{
			builder.AddOffset(6, shopFailedFlowOffset.Value, 0);
		}

		// Token: 0x06024ED2 RID: 151250 RVA: 0x005192AD File Offset: 0x005174AD
		public static void AddUpgradeSequence(FlatBufferBuilder builder, StringOffset upgradeSequenceOffset)
		{
			builder.AddOffset(7, upgradeSequenceOffset.Value, 0);
		}

		// Token: 0x06024ED3 RID: 151251 RVA: 0x005192BD File Offset: 0x005174BD
		public static void AddUpgradeFlow(FlatBufferBuilder builder, Offset<IPlayFlow> upgradeFlowOffset)
		{
			builder.AddOffset(8, upgradeFlowOffset.Value, 0);
		}

		// Token: 0x06024ED4 RID: 151252 RVA: 0x005192CD File Offset: 0x005174CD
		public static void AddExitMontageType(FlatBufferBuilder builder, TMontageConfig exitMontageType)
		{
			builder.AddByte(9, (byte)exitMontageType, 0);
		}

		// Token: 0x06024ED5 RID: 151253 RVA: 0x005192D9 File Offset: 0x005174D9
		public static void AddExitMontage(FlatBufferBuilder builder, int exitMontageOffset)
		{
			builder.AddOffset(10, exitMontageOffset, 0);
		}

		// Token: 0x06024ED6 RID: 151254 RVA: 0x005192E5 File Offset: 0x005174E5
		public static void AddExitFlow(FlatBufferBuilder builder, Offset<IPlayFlow> exitFlowOffset)
		{
			builder.AddOffset(11, exitFlowOffset.Value, 0);
		}

		// Token: 0x06024ED7 RID: 151255 RVA: 0x005192F6 File Offset: 0x005174F6
		public static Offset<INpcUiInteractOnSoundBox35> EndINpcUiInteractOnSoundBox35(FlatBufferBuilder builder)
		{
			return new Offset<INpcUiInteractOnSoundBox35>(builder.EndTable());
		}

		// Token: 0x06024ED8 RID: 151256 RVA: 0x00519304 File Offset: 0x00517504
		public INpcUiInteractOnSoundBox35T UnPack()
		{
			INpcUiInteractOnSoundBox35T npcUiInteractOnSoundBox35T = new INpcUiInteractOnSoundBox35T();
			this.UnPackTo(npcUiInteractOnSoundBox35T);
			return npcUiInteractOnSoundBox35T;
		}

		// Token: 0x06024ED9 RID: 151257 RVA: 0x00519320 File Offset: 0x00517520
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

		// Token: 0x06024EDA RID: 151258 RVA: 0x005194F0 File Offset: 0x005176F0
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

		// Token: 0x0400EA80 RID: 60032
		private Table __p;
	}
}
