using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A3A RID: 23098
	public struct ITeleControl2 : IFlatbufferObject
	{
		// Token: 0x1700ADB3 RID: 44467
		// (get) Token: 0x06027434 RID: 160820 RVA: 0x00566FD0 File Offset: 0x005651D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027435 RID: 160821 RVA: 0x00566FDD File Offset: 0x005651DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027436 RID: 160822 RVA: 0x00566FE4 File Offset: 0x005651E4
		public static ITeleControl2 GetRootAsITeleControl2(ByteBuffer _bb)
		{
			return ITeleControl2.GetRootAsITeleControl2(_bb, default(ITeleControl2));
		}

		// Token: 0x06027437 RID: 160823 RVA: 0x00567000 File Offset: 0x00565200
		public static ITeleControl2 GetRootAsITeleControl2(ByteBuffer _bb, ITeleControl2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027438 RID: 160824 RVA: 0x0056701D File Offset: 0x0056521D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027439 RID: 160825 RVA: 0x0056702C File Offset: 0x0056522C
		public ITeleControl2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADB4 RID: 44468
		// (get) Token: 0x0602743A RID: 160826 RVA: 0x0056703C File Offset: 0x0056523C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ADB5 RID: 44469
		// (get) Token: 0x0602743B RID: 160827 RVA: 0x0056707C File Offset: 0x0056527C
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

		// Token: 0x1700ADB6 RID: 44470
		// (get) Token: 0x0602743C RID: 160828 RVA: 0x005670DC File Offset: 0x005652DC
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

		// Token: 0x1700ADB7 RID: 44471
		// (get) Token: 0x0602743D RID: 160829 RVA: 0x0056713C File Offset: 0x0056533C
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

		// Token: 0x1700ADB8 RID: 44472
		// (get) Token: 0x0602743E RID: 160830 RVA: 0x0056719C File Offset: 0x0056539C
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

		// Token: 0x1700ADB9 RID: 44473
		// (get) Token: 0x0602743F RID: 160831 RVA: 0x005671FC File Offset: 0x005653FC
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

		// Token: 0x1700ADBA RID: 44474
		// (get) Token: 0x06027440 RID: 160832 RVA: 0x0056725C File Offset: 0x0056545C
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

		// Token: 0x1700ADBB RID: 44475
		// (get) Token: 0x06027441 RID: 160833 RVA: 0x005672BC File Offset: 0x005654BC
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

		// Token: 0x06027442 RID: 160834 RVA: 0x005672FC File Offset: 0x005654FC
		public TMatchRoleOption MatchRoleOptionType(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return TMatchRoleOption.NONE;
			}
			return (TMatchRoleOption)this.__p.bb.Get(this.__p.__vector(num) + j);
		}

		// Token: 0x1700ADBC RID: 44476
		// (get) Token: 0x06027443 RID: 160835 RVA: 0x0056733C File Offset: 0x0056553C
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

		// Token: 0x06027444 RID: 160836 RVA: 0x00567368 File Offset: 0x00565568
		public Span<TMatchRoleOption> GetMatchRoleOptionTypeBytes()
		{
			return this.__p.__vector_as_span<TMatchRoleOption>(20, 1);
		}

		// Token: 0x06027445 RID: 160837 RVA: 0x00567378 File Offset: 0x00565578
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

		// Token: 0x06027446 RID: 160838 RVA: 0x005673E4 File Offset: 0x005655E4
		public TTable? MatchRoleOption<TTable>(int j) where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(this.__p.__vector(num) + j * 4));
		}

		// Token: 0x1700ADBD RID: 44477
		// (get) Token: 0x06027447 RID: 160839 RVA: 0x0056742C File Offset: 0x0056562C
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

		// Token: 0x1700ADBE RID: 44478
		// (get) Token: 0x06027448 RID: 160840 RVA: 0x00567458 File Offset: 0x00565658
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

		// Token: 0x06027449 RID: 160841 RVA: 0x00567498 File Offset: 0x00565698
		public TTable? TriggerCfg<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602744A RID: 160842 RVA: 0x005674E0 File Offset: 0x005656E0
		public IMechascoutExplosiveBarrelTriggerConfig TriggerCfgAsIMechascoutExplosiveBarrelTriggerConfig()
		{
			return this.TriggerCfg<IMechascoutExplosiveBarrelTriggerConfig>().Value;
		}

		// Token: 0x0602744B RID: 160843 RVA: 0x005674FC File Offset: 0x005656FC
		public IMechascoutJavelinTriggerConfig TriggerCfgAsIMechascoutJavelinTriggerConfig()
		{
			return this.TriggerCfg<IMechascoutJavelinTriggerConfig>().Value;
		}

		// Token: 0x1700ADBF RID: 44479
		// (get) Token: 0x0602744C RID: 160844 RVA: 0x00567518 File Offset: 0x00565718
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

		// Token: 0x0602744D RID: 160845 RVA: 0x00567558 File Offset: 0x00565758
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

		// Token: 0x0602744E RID: 160846 RVA: 0x005675D8 File Offset: 0x005657D8
		public static void StartITeleControl2(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x0602744F RID: 160847 RVA: 0x005675E2 File Offset: 0x005657E2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027450 RID: 160848 RVA: 0x005675ED File Offset: 0x005657ED
		public static void AddBaseCfg(FlatBufferBuilder builder, Offset<ITeleControlBaseCfg> baseCfgOffset)
		{
			builder.AddOffset(1, baseCfgOffset.Value, 0);
		}

		// Token: 0x06027451 RID: 160849 RVA: 0x005675FD File Offset: 0x005657FD
		public static void AddSearchTargetCfg(FlatBufferBuilder builder, Offset<ISearchTargetCfg> searchTargetCfgOffset)
		{
			builder.AddOffset(2, searchTargetCfgOffset.Value, 0);
		}

		// Token: 0x06027452 RID: 160850 RVA: 0x0056760D File Offset: 0x0056580D
		public static void AddBulletCfg(FlatBufferBuilder builder, Offset<IBulletCfg> bulletCfgOffset)
		{
			builder.AddOffset(3, bulletCfgOffset.Value, 0);
		}

		// Token: 0x06027453 RID: 160851 RVA: 0x0056761D File Offset: 0x0056581D
		public static void AddDestroyCfg(FlatBufferBuilder builder, Offset<IDestroyCfg> destroyCfgOffset)
		{
			builder.AddOffset(4, destroyCfgOffset.Value, 0);
		}

		// Token: 0x06027454 RID: 160852 RVA: 0x0056762D File Offset: 0x0056582D
		public static void AddHoldCfg(FlatBufferBuilder builder, Offset<IHoldCfg> holdCfgOffset)
		{
			builder.AddOffset(5, holdCfgOffset.Value, 0);
		}

		// Token: 0x06027455 RID: 160853 RVA: 0x0056763D File Offset: 0x0056583D
		public static void AddThrowCfg(FlatBufferBuilder builder, Offset<IThrowCfg> throwCfgOffset)
		{
			builder.AddOffset(6, throwCfgOffset.Value, 0);
		}

		// Token: 0x06027456 RID: 160854 RVA: 0x0056764D File Offset: 0x0056584D
		public static void AddPlayerStateRestritionId(FlatBufferBuilder builder, int playerStateRestritionId)
		{
			builder.AddInt(7, playerStateRestritionId, 0);
		}

		// Token: 0x06027457 RID: 160855 RVA: 0x00567658 File Offset: 0x00565858
		public static void AddMatchRoleOptionType(FlatBufferBuilder builder, VectorOffset matchRoleOptionTypeOffset)
		{
			builder.AddOffset(8, matchRoleOptionTypeOffset.Value, 0);
		}

		// Token: 0x06027458 RID: 160856 RVA: 0x00567668 File Offset: 0x00565868
		public static VectorOffset CreateMatchRoleOptionTypeVector(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddByte((byte)data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06027459 RID: 160857 RVA: 0x0056769F File Offset: 0x0056589F
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, TMatchRoleOption[] data)
		{
			builder.StartVector(1, data.Length, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x0602745A RID: 160858 RVA: 0x005676B9 File Offset: 0x005658B9
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, ArraySegment<TMatchRoleOption> data)
		{
			builder.StartVector(1, data.Count, 1);
			builder.Add<TMatchRoleOption>(data);
			return builder.EndVector();
		}

		// Token: 0x0602745B RID: 160859 RVA: 0x005676D7 File Offset: 0x005658D7
		public static VectorOffset CreateMatchRoleOptionTypeVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<TMatchRoleOption>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602745C RID: 160860 RVA: 0x005676F0 File Offset: 0x005658F0
		public static void StartMatchRoleOptionTypeVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(1, numElems, 1);
		}

		// Token: 0x0602745D RID: 160861 RVA: 0x005676FB File Offset: 0x005658FB
		public static void AddMatchRoleOption(FlatBufferBuilder builder, VectorOffset matchRoleOptionOffset)
		{
			builder.AddOffset(9, matchRoleOptionOffset.Value, 0);
		}

		// Token: 0x0602745E RID: 160862 RVA: 0x0056770C File Offset: 0x0056590C
		public static VectorOffset CreateMatchRoleOptionVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0602745F RID: 160863 RVA: 0x00567743 File Offset: 0x00565943
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027460 RID: 160864 RVA: 0x0056775D File Offset: 0x0056595D
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06027461 RID: 160865 RVA: 0x0056777B File Offset: 0x0056597B
		public static VectorOffset CreateMatchRoleOptionVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06027462 RID: 160866 RVA: 0x00567794 File Offset: 0x00565994
		public static void StartMatchRoleOptionVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06027463 RID: 160867 RVA: 0x0056779F File Offset: 0x0056599F
		public static void AddTriggerCfgType(FlatBufferBuilder builder, TTeleCtrlTriggerConfig triggerCfgType)
		{
			builder.AddByte(10, (byte)triggerCfgType, 0);
		}

		// Token: 0x06027464 RID: 160868 RVA: 0x005677AB File Offset: 0x005659AB
		public static void AddTriggerCfg(FlatBufferBuilder builder, int triggerCfgOffset)
		{
			builder.AddOffset(11, triggerCfgOffset, 0);
		}

		// Token: 0x06027465 RID: 160869 RVA: 0x005677B7 File Offset: 0x005659B7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x06027466 RID: 160870 RVA: 0x005677C3 File Offset: 0x005659C3
		public static Offset<ITeleControl2> EndITeleControl2(FlatBufferBuilder builder)
		{
			return new Offset<ITeleControl2>(builder.EndTable());
		}

		// Token: 0x06027467 RID: 160871 RVA: 0x005677D0 File Offset: 0x005659D0
		public ITeleControl2T UnPack()
		{
			ITeleControl2T teleControl2T = new ITeleControl2T();
			this.UnPackTo(teleControl2T);
			return teleControl2T;
		}

		// Token: 0x06027468 RID: 160872 RVA: 0x005677EC File Offset: 0x005659EC
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
				TMatchRoleOption tmatchRoleOption = this.MatchRoleOptionType(i);
				if (tmatchRoleOption != TMatchRoleOption.IMatchPhantomRole)
				{
					if (tmatchRoleOption == TMatchRoleOption.IMatchPlayerRole)
					{
						tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPlayerRole>(i) != null) ? this.MatchRoleOption<IMatchPlayerRole>(i).Value.UnPack() : null);
					}
				}
				else
				{
					tmatchRoleOptionUnion.Value = ((this.MatchRoleOption<IMatchPhantomRole>(i) != null) ? this.MatchRoleOption<IMatchPhantomRole>(i).Value.UnPack() : null);
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

		// Token: 0x06027469 RID: 160873 RVA: 0x00567AB4 File Offset: 0x00565CB4
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

		// Token: 0x0400F0AB RID: 61611
		private Table __p;
	}
}
