using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006047 RID: 24647
	public struct ITeleControl2 : IFlatbufferObject
	{
		// Token: 0x1700B6EB RID: 46827
		// (get) Token: 0x060299AC RID: 170412 RVA: 0x005ADF94 File Offset: 0x005AC194
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060299AD RID: 170413 RVA: 0x005ADFA1 File Offset: 0x005AC1A1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060299AE RID: 170414 RVA: 0x005ADFA8 File Offset: 0x005AC1A8
		public static ITeleControl2 GetRootAsITeleControl2(ByteBuffer _bb)
		{
			return ITeleControl2.GetRootAsITeleControl2(_bb, default(ITeleControl2));
		}

		// Token: 0x060299AF RID: 170415 RVA: 0x005ADFC4 File Offset: 0x005AC1C4
		public static ITeleControl2 GetRootAsITeleControl2(ByteBuffer _bb, ITeleControl2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060299B0 RID: 170416 RVA: 0x005ADFE1 File Offset: 0x005AC1E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060299B1 RID: 170417 RVA: 0x005ADFF0 File Offset: 0x005AC1F0
		public ITeleControl2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B6EC RID: 46828
		// (get) Token: 0x060299B2 RID: 170418 RVA: 0x005AE000 File Offset: 0x005AC200
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B6ED RID: 46829
		// (get) Token: 0x060299B3 RID: 170419 RVA: 0x005AE040 File Offset: 0x005AC240
		public ITeleControlBaseCfg? BaseCfg
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITeleControlBaseCfg?(default(ITeleControlBaseCfg).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B6EE RID: 46830
		// (get) Token: 0x060299B4 RID: 170420 RVA: 0x005AE0A0 File Offset: 0x005AC2A0
		public ISearchTargetCfg? SearchTargetCfg
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ISearchTargetCfg?(default(ISearchTargetCfg).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B6EF RID: 46831
		// (get) Token: 0x060299B5 RID: 170421 RVA: 0x005AE100 File Offset: 0x005AC300
		public IBulletCfg? BulletCfg
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IBulletCfg?(default(IBulletCfg).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B6F0 RID: 46832
		// (get) Token: 0x060299B6 RID: 170422 RVA: 0x005AE160 File Offset: 0x005AC360
		public IDestroyCfg? DestroyCfg
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IDestroyCfg?(default(IDestroyCfg).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B6F1 RID: 46833
		// (get) Token: 0x060299B7 RID: 170423 RVA: 0x005AE1C0 File Offset: 0x005AC3C0
		public IHoldCfg? HoldCfg
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IHoldCfg?(default(IHoldCfg).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B6F2 RID: 46834
		// (get) Token: 0x060299B8 RID: 170424 RVA: 0x005AE220 File Offset: 0x005AC420
		public IThrowCfg? ThrowCfg
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return new IThrowCfg?(default(IThrowCfg).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B6F3 RID: 46835
		// (get) Token: 0x060299B9 RID: 170425 RVA: 0x005AE280 File Offset: 0x005AC480
		public int PlayerStateRestritionId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060299BA RID: 170426 RVA: 0x005AE2C0 File Offset: 0x005AC4C0
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700B6F4 RID: 46836
		// (get) Token: 0x060299BB RID: 170427 RVA: 0x005AE300 File Offset: 0x005AC500
		public int MatchRoleOptionTypeLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060299BC RID: 170428 RVA: 0x005AE32C File Offset: 0x005AC52C
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(20, 1);
		}

		// Token: 0x060299BD RID: 170429 RVA: 0x005AE33C File Offset: 0x005AC53C
		public TMatchRoleOption[] GetMatchRoleOptionTypeArray()
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			int num2 = this.__p.__vector(num);
			int num3 = this.__p.__vector_len(num);
			TMatchRoleOption[] array = new TMatchRoleOption[num3];
			for (int i = 0; i < num3; i++)
			{
				array[i] = (TMatchRoleOption)this.__p.bb.Get(num2 + i);
			}
			return array;
		}

		// Token: 0x060299BE RID: 170430 RVA: 0x005AE3A8 File Offset: 0x005AC5A8
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700B6F5 RID: 46837
		// (get) Token: 0x060299BF RID: 170431 RVA: 0x005AE3F0 File Offset: 0x005AC5F0
		public int MatchRoleOptionLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700B6F6 RID: 46838
		// (get) Token: 0x060299C0 RID: 170432 RVA: 0x005AE41C File Offset: 0x005AC61C
		public TTeleCtrlTriggerConfig TriggerCfgType
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return TTeleCtrlTriggerConfig.NONE;
				}
				return (TTeleCtrlTriggerConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060299C1 RID: 170433 RVA: 0x005AE45C File Offset: 0x005AC65C
		public TTable? TriggerCfg<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060299C2 RID: 170434 RVA: 0x005AE4A4 File Offset: 0x005AC6A4
		public IMechascoutExplosiveBarrelTriggerConfig TriggerCfgAsIMechascoutExplosiveBarrelTriggerConfig()
		{
			return this.TriggerCfg<IMechascoutExplosiveBarrelTriggerConfig>().Value;
		}

		// Token: 0x060299C3 RID: 170435 RVA: 0x005AE4C0 File Offset: 0x005AC6C0
		public IMechascoutJavelinTriggerConfig TriggerCfgAsIMechascoutJavelinTriggerConfig()
		{
			return this.TriggerCfg<IMechascoutJavelinTriggerConfig>().Value;
		}

		// Token: 0x1700B6F7 RID: 46839
		// (get) Token: 0x060299C4 RID: 170436 RVA: 0x005AE4DC File Offset: 0x005AC6DC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060299C5 RID: 170437 RVA: 0x005AE51C File Offset: 0x005AC71C
		public static Offset<ITeleControl2> CreateITeleControl2(FlatBufferBuilder builder, bool Disabled = false, Offset<ITeleControlBaseCfg> BaseCfgOffset = default(Offset<ITeleControlBaseCfg>), Offset<ISearchTargetCfg> SearchTargetCfgOffset = default(Offset<ISearchTargetCfg>), Offset<IBulletCfg> BulletCfgOffset = default(Offset<IBulletCfg>), Offset<IDestroyCfg> DestroyCfgOffset = default(Offset<IDestroyCfg>), Offset<IHoldCfg> HoldCfgOffset = default(Offset<IHoldCfg>), Offset<IThrowCfg> ThrowCfgOffset = default(Offset<IThrowCfg>), int PlayerStateRestritionId = 0, VectorOffset MatchRoleOption_typeOffset = default(VectorOffset), VectorOffset MatchRoleOptionOffset = default(VectorOffset), TTeleCtrlTriggerConfig TriggerCfg_type = TTeleCtrlTriggerConfig.NONE, int TriggerCfgOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(13);
			ITeleControl2.AddTriggerCfg(builder, TriggerCfgOffset);
			ITeleControl2.AddMatchRoleOption(builder, MatchRoleOptionOffset);
			ITeleControl2.AddMatchRoleOptionType(builder, MatchRoleOption_typeOffset);
			ITeleControl2.AddPlayerStateRestritionId(builder, PlayerStateRestritionId);
			ITeleControl2.AddThrowCfg(builder, ThrowCfgOffset);
			ITeleControl2.AddHoldCfg(builder, HoldCfgOffset);
			ITeleControl2.AddDestroyCfg(builder, DestroyCfgOffset);
			ITeleControl2.AddBulletCfg(builder, BulletCfgOffset);
			ITeleControl2.AddSearchTargetCfg(builder, SearchTargetCfgOffset);
			ITeleControl2.AddBaseCfg(builder, BaseCfgOffset);
			ITeleControl2.AddNullMask(builder, NullMask);
			ITeleControl2.AddTriggerCfgType(builder, TriggerCfg_type);
			ITeleControl2.AddDisabled(builder, Disabled);
			return ITeleControl2.EndITeleControl2(builder);
		}

		// Token: 0x060299C6 RID: 170438 RVA: 0x005AE59C File Offset: 0x005AC79C
		public static void StartITeleControl2(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x060299C7 RID: 170439 RVA: 0x005AE5A6 File Offset: 0x005AC7A6
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060299C8 RID: 170440 RVA: 0x005AE5B1 File Offset: 0x005AC7B1
		public static void AddBaseCfg(FlatBufferBuilder builder, Offset<ITeleControlBaseCfg> baseCfgOffset)
		{
			builder.AddOffset(1, baseCfgOffset.Value, 0);
		}

		// Token: 0x060299C9 RID: 170441 RVA: 0x005AE5C1 File Offset: 0x005AC7C1
		public static void AddSearchTargetCfg(FlatBufferBuilder builder, Offset<ISearchTargetCfg> searchTargetCfgOffset)
		{
			builder.AddOffset(2, searchTargetCfgOffset.Value, 0);
		}

		// Token: 0x060299CA RID: 170442 RVA: 0x005AE5D1 File Offset: 0x005AC7D1
		public static void AddBulletCfg(FlatBufferBuilder builder, Offset<IBulletCfg> bulletCfgOffset)
		{
			builder.AddOffset(3, bulletCfgOffset.Value, 0);
		}

		// Token: 0x060299CB RID: 170443 RVA: 0x005AE5E1 File Offset: 0x005AC7E1
		public static void AddDestroyCfg(FlatBufferBuilder builder, Offset<IDestroyCfg> destroyCfgOffset)
		{
			builder.AddOffset(4, destroyCfgOffset.Value, 0);
		}

		// Token: 0x060299CC RID: 170444 RVA: 0x005AE5F1 File Offset: 0x005AC7F1
		public static void AddHoldCfg(FlatBufferBuilder builder, Offset<IHoldCfg> holdCfgOffset)
		{
			builder.AddOffset(5, holdCfgOffset.Value, 0);
		}

		// Token: 0x060299CD RID: 170445 RVA: 0x005AE601 File Offset: 0x005AC801
		public static void AddThrowCfg(FlatBufferBuilder builder, Offset<IThrowCfg> throwCfgOffset)
		{
			builder.AddOffset(6, throwCfgOffset.Value, 0);
		}

		// Token: 0x060299CE RID: 170446 RVA: 0x005AE611 File Offset: 0x005AC811
		public static void AddPlayerStateRestritionId(FlatBufferBuilder builder, int playerStateRestritionId)
		{
			builder.AddInt(7, playerStateRestritionId, 0);
		}

		// Token: 0x060299CF RID: 170447 RVA: 0x005AE61C File Offset: 0x005AC81C
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(8, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x060299D0 RID: 170448 RVA: 0x005AE62C File Offset: 0x005AC82C
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060299D1 RID: 170449 RVA: 0x005AE663 File Offset: 0x005AC863
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x060299D2 RID: 170450 RVA: 0x005AE67D File Offset: 0x005AC87D
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x060299D3 RID: 170451 RVA: 0x005AE69B File Offset: 0x005AC89B
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060299D4 RID: 170452 RVA: 0x005AE6B4 File Offset: 0x005AC8B4
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x060299D5 RID: 170453 RVA: 0x005AE6BF File Offset: 0x005AC8BF
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(9, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x060299D6 RID: 170454 RVA: 0x005AE6D0 File Offset: 0x005AC8D0
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x060299D7 RID: 170455 RVA: 0x005AE707 File Offset: 0x005AC907
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060299D8 RID: 170456 RVA: 0x005AE721 File Offset: 0x005AC921
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x060299D9 RID: 170457 RVA: 0x005AE73F File Offset: 0x005AC93F
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060299DA RID: 170458 RVA: 0x005AE758 File Offset: 0x005AC958
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060299DB RID: 170459 RVA: 0x005AE763 File Offset: 0x005AC963
		public static void AddTriggerCfgType(FlatBufferBuilder builder, TTeleCtrlTriggerConfig triggerCfgType)
		{
			builder.AddByte(10, (byte)triggerCfgType, 0);
		}

		// Token: 0x060299DC RID: 170460 RVA: 0x005AE76F File Offset: 0x005AC96F
		public static void AddTriggerCfg(FlatBufferBuilder builder, int triggerCfgOffset)
		{
			builder.AddOffset(11, triggerCfgOffset, 0);
		}

		// Token: 0x060299DD RID: 170461 RVA: 0x005AE77B File Offset: 0x005AC97B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x060299DE RID: 170462 RVA: 0x005AE787 File Offset: 0x005AC987
		public static Offset<ITeleControl2> EndITeleControl2(FlatBufferBuilder builder)
		{
			return new Offset<ITeleControl2>(builder.EndTable());
		}

		// Token: 0x060299DF RID: 170463 RVA: 0x005AE794 File Offset: 0x005AC994
		public ITeleControl2T UnPack()
		{
			ITeleControl2T teleControl2T = new ITeleControl2T();
			this.UnPackTo(teleControl2T);
			return teleControl2T;
		}

		// Token: 0x060299E0 RID: 170464 RVA: 0x005AE7B0 File Offset: 0x005AC9B0
		public void UnPackTo(ITeleControl2T _o)
		{
			_o.Disabled = this.Disabled;
			_o.BaseCfg = ((this.BaseCfg != null) ? this.BaseCfg.Value.UnPack() : null);
			_o.SearchTargetCfg = ((this.SearchTargetCfg != null) ? this.SearchTargetCfg.Value.UnPack() : null);
			_o.BulletCfg = ((this.BulletCfg != null) ? this.BulletCfg.Value.UnPack() : null);
			_o.DestroyCfg = ((this.DestroyCfg != null) ? this.DestroyCfg.Value.UnPack() : null);
			_o.HoldCfg = ((this.HoldCfg != null) ? this.HoldCfg.Value.UnPack() : null);
			_o.ThrowCfg = ((this.ThrowCfg != null) ? this.ThrowCfg.Value.UnPack() : null);
			_o.PlayerStateRestritionId = this.PlayerStateRestritionId;
			_o.MatchRoleOption = new List<TMatchRoleOptionUnion>();
			for (int i = 0; i < this.MatchRoleOptionLength; i++)
			{
				TMatchRoleOptionUnion tmatchRoleOptionUnion = new TMatchRoleOptionUnion();
				tmatchRoleOptionUnion.Type = this.MatchRoleOptionType(i);
				switch (this.MatchRoleOptionType(i))
				{
				case TMatchRoleOption.IMatchAssistCharacterRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchAssistCharacterRole>(i) != null) ? this.MatchRoleOption<IMatchAssistCharacterRole>(i).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPhantomRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(i) != null) ? this.MatchRoleOption<IMatchPhantomRole>(i).Value.UnPack() : null);
					break;
				case TMatchRoleOption.IMatchPlayerRole:
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(i) != null) ? this.MatchRoleOption<IMatchPlayerRole>(i).Value.UnPack() : null);
					break;
				}
				_o.MatchRoleOption.Add(tmatchRoleOptionUnion);
			}
			_o.TriggerCfg = new TTeleCtrlTriggerConfigUnion();
			_o.TriggerCfg.Type = this.TriggerCfgType;
			TTeleCtrlTriggerConfig triggerCfgType = this.TriggerCfgType;
			if (triggerCfgType != TTeleCtrlTriggerConfig.IMechascoutExplosiveBarrelTriggerConfig)
			{
				if (triggerCfgType == TTeleCtrlTriggerConfig.IMechascoutJavelinTriggerConfig)
				{
					_o.TriggerCfg.Value = ((this.TriggerCfg<IMechascoutJavelinTriggerConfig>() != null) ? this.TriggerCfg<IMechascoutJavelinTriggerConfig>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.TriggerCfg.Value = ((this.TriggerCfg<IMechascoutExplosiveBarrelTriggerConfig>() != null) ? this.TriggerCfg<IMechascoutExplosiveBarrelTriggerConfig>().Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060299E1 RID: 170465 RVA: 0x005AEAC0 File Offset: 0x005ACCC0
		public static Offset<ITeleControl2> Pack(FlatBufferBuilder builder, ITeleControl2T _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleControl2>);
			}
			Offset<ITeleControlBaseCfg> baseCfgOffset = (_o.BaseCfg == null) ? default(Offset<ITeleControlBaseCfg>) : ITeleControlBaseCfg.Pack(builder, _o.BaseCfg);
			Offset<ISearchTargetCfg> searchTargetCfgOffset = (_o.SearchTargetCfg == null) ? default(Offset<ISearchTargetCfg>) : ISearchTargetCfg.Pack(builder, _o.SearchTargetCfg);
			Offset<IBulletCfg> bulletCfgOffset = (_o.BulletCfg == null) ? default(Offset<IBulletCfg>) : IBulletCfg.Pack(builder, _o.BulletCfg);
			Offset<IDestroyCfg> destroyCfgOffset = (_o.DestroyCfg == null) ? default(Offset<IDestroyCfg>) : IDestroyCfg.Pack(builder, _o.DestroyCfg);
			Offset<IHoldCfg> holdCfgOffset = (_o.HoldCfg == null) ? default(Offset<IHoldCfg>) : IHoldCfg.Pack(builder, _o.HoldCfg);
			Offset<IThrowCfg> throwCfgOffset = (_o.ThrowCfg == null) ? default(Offset<IThrowCfg>) : IThrowCfg.Pack(builder, _o.ThrowCfg);
			VectorOffset matchRoleOption_typeOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				TMatchRoleOption[] array = new TMatchRoleOption[_o.MatchRoleOption.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = _o.MatchRoleOption[i].Type;
				}
				matchRoleOption_typeOffset = ITeleControl2.CreateMatchRoleOptionTypeVector(builder, array);
			}
			VectorOffset matchRoleOptionOffset = default(VectorOffset);
			if (_o.MatchRoleOption != null)
			{
				int[] array2 = new int[_o.MatchRoleOption.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = TMatchRoleOptionUnion.Pack(builder, _o.MatchRoleOption[j]);
				}
				matchRoleOptionOffset = ITeleControl2.CreateMatchRoleOptionVector(builder, array2);
			}
			TTeleCtrlTriggerConfig triggerCfg_type = (_o.TriggerCfg == null) ? TTeleCtrlTriggerConfig.NONE : _o.TriggerCfg.Type;
			int triggerCfgOffset = (_o.TriggerCfg == null) ? 0 : TTeleCtrlTriggerConfigUnion.Pack(builder, _o.TriggerCfg);
			return ITeleControl2.CreateITeleControl2(builder, _o.Disabled, baseCfgOffset, searchTargetCfgOffset, bulletCfgOffset, destroyCfgOffset, holdCfgOffset, throwCfgOffset, _o.PlayerStateRestritionId, matchRoleOption_typeOffset, matchRoleOptionOffset, triggerCfg_type, triggerCfgOffset, _o.NullMask);
		}

		// Token: 0x0400FDA2 RID: 64930
		private Table __p;
	}
}
