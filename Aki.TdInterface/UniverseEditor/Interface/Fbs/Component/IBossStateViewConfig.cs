using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200544B RID: 21579
	public struct IBossStateViewConfig : IFlatbufferObject
	{
		// Token: 0x17009954 RID: 39252
		// (get) Token: 0x06021DBA RID: 138682 RVA: 0x004AAE9B File Offset: 0x004A909B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021DBB RID: 138683 RVA: 0x004AAEA8 File Offset: 0x004A90A8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021DBC RID: 138684 RVA: 0x004AAEB0 File Offset: 0x004A90B0
		public static IBossStateViewConfig GetRootAsIBossStateViewConfig(ByteBuffer _bb)
		{
			return IBossStateViewConfig.GetRootAsIBossStateViewConfig(_bb, default(IBossStateViewConfig));
		}

		// Token: 0x06021DBD RID: 138685 RVA: 0x004AAECC File Offset: 0x004A90CC
		public static IBossStateViewConfig GetRootAsIBossStateViewConfig(ByteBuffer _bb, IBossStateViewConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021DBE RID: 138686 RVA: 0x004AAEE9 File Offset: 0x004A90E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021DBF RID: 138687 RVA: 0x004AAEF8 File Offset: 0x004A90F8
		public IBossStateViewConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009955 RID: 39253
		// (get) Token: 0x06021DC0 RID: 138688 RVA: 0x004AAF08 File Offset: 0x004A9108
		public EBossStateViewType BossStateViewType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EBossStateViewType.None;
				}
				return (EBossStateViewType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009956 RID: 39254
		// (get) Token: 0x06021DC1 RID: 138689 RVA: 0x004AAF44 File Offset: 0x004A9144
		public IDoubleViewBossStateViewStyle? BossStateViewStyle
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDoubleViewBossStateViewStyle?(default(IDoubleViewBossStateViewStyle).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009957 RID: 39255
		// (get) Token: 0x06021DC2 RID: 138690 RVA: 0x004AAFA4 File Offset: 0x004A91A4
		public string TidBossSubTitle
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

		// Token: 0x06021DC3 RID: 138691 RVA: 0x004AAFDB File Offset: 0x004A91DB
		public Span<byte> GetTidBossSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06021DC4 RID: 138692 RVA: 0x004AAFEA File Offset: 0x004A91EA
		public byte[] GetTidBossSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x17009958 RID: 39256
		// (get) Token: 0x06021DC5 RID: 138693 RVA: 0x004AAFF8 File Offset: 0x004A91F8
		public EBossStateInfoShowType BossStateInfoShowType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return EBossStateInfoShowType.Common;
				}
				return (EBossStateInfoShowType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009959 RID: 39257
		// (get) Token: 0x06021DC6 RID: 138694 RVA: 0x004AB038 File Offset: 0x004A9238
		public string TidLevelText
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021DC7 RID: 138695 RVA: 0x004AB070 File Offset: 0x004A9270
		public Span<byte> GetTidLevelTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06021DC8 RID: 138696 RVA: 0x004AB080 File Offset: 0x004A9280
		public byte[] GetTidLevelTextArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x1700995A RID: 39258
		// (get) Token: 0x06021DC9 RID: 138697 RVA: 0x004AB090 File Offset: 0x004A9290
		public bool OnlyShowInBattleState
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700995B RID: 39259
		// (get) Token: 0x06021DCA RID: 138698 RVA: 0x004AB0D0 File Offset: 0x004A92D0
		public int ShowDistance
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700995C RID: 39260
		// (get) Token: 0x06021DCB RID: 138699 RVA: 0x004AB110 File Offset: 0x004A9310
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021DCC RID: 138700 RVA: 0x004AB150 File Offset: 0x004A9350
		public static Offset<IBossStateViewConfig> CreateIBossStateViewConfig(FlatBufferBuilder builder, EBossStateViewType BossStateViewType = EBossStateViewType.None, Offset<IDoubleViewBossStateViewStyle> BossStateViewStyleOffset = default(Offset<IDoubleViewBossStateViewStyle>), StringOffset TidBossSubTitleOffset = default(StringOffset), EBossStateInfoShowType BossStateInfoShowType = EBossStateInfoShowType.Common, StringOffset TidLevelTextOffset = default(StringOffset), bool OnlyShowInBattleState = false, int ShowDistance = 0, byte NullMask = 0)
		{
			builder.StartTable(8);
			IBossStateViewConfig.AddShowDistance(builder, ShowDistance);
			IBossStateViewConfig.AddTidLevelText(builder, TidLevelTextOffset);
			IBossStateViewConfig.AddTidBossSubTitle(builder, TidBossSubTitleOffset);
			IBossStateViewConfig.AddBossStateViewStyle(builder, BossStateViewStyleOffset);
			IBossStateViewConfig.AddNullMask(builder, NullMask);
			IBossStateViewConfig.AddOnlyShowInBattleState(builder, OnlyShowInBattleState);
			IBossStateViewConfig.AddBossStateInfoShowType(builder, BossStateInfoShowType);
			IBossStateViewConfig.AddBossStateViewType(builder, BossStateViewType);
			return IBossStateViewConfig.EndIBossStateViewConfig(builder);
		}

		// Token: 0x06021DCD RID: 138701 RVA: 0x004AB1A7 File Offset: 0x004A93A7
		public static void StartIBossStateViewConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06021DCE RID: 138702 RVA: 0x004AB1B0 File Offset: 0x004A93B0
		public static void AddBossStateViewType(FlatBufferBuilder builder, EBossStateViewType bossStateViewType)
		{
			builder.AddByte(0, (byte)bossStateViewType, 0);
		}

		// Token: 0x06021DCF RID: 138703 RVA: 0x004AB1BB File Offset: 0x004A93BB
		public static void AddBossStateViewStyle(FlatBufferBuilder builder, Offset<IDoubleViewBossStateViewStyle> bossStateViewStyleOffset)
		{
			builder.AddOffset(1, bossStateViewStyleOffset.Value, 0);
		}

		// Token: 0x06021DD0 RID: 138704 RVA: 0x004AB1CB File Offset: 0x004A93CB
		public static void AddTidBossSubTitle(FlatBufferBuilder builder, StringOffset tidBossSubTitleOffset)
		{
			builder.AddOffset(2, tidBossSubTitleOffset.Value, 0);
		}

		// Token: 0x06021DD1 RID: 138705 RVA: 0x004AB1DB File Offset: 0x004A93DB
		public static void AddBossStateInfoShowType(FlatBufferBuilder builder, EBossStateInfoShowType bossStateInfoShowType)
		{
			builder.AddByte(3, (byte)bossStateInfoShowType, 0);
		}

		// Token: 0x06021DD2 RID: 138706 RVA: 0x004AB1E6 File Offset: 0x004A93E6
		public static void AddTidLevelText(FlatBufferBuilder builder, StringOffset tidLevelTextOffset)
		{
			builder.AddOffset(4, tidLevelTextOffset.Value, 0);
		}

		// Token: 0x06021DD3 RID: 138707 RVA: 0x004AB1F6 File Offset: 0x004A93F6
		public static void AddOnlyShowInBattleState(FlatBufferBuilder builder, bool onlyShowInBattleState)
		{
			builder.AddBool(5, onlyShowInBattleState, false);
		}

		// Token: 0x06021DD4 RID: 138708 RVA: 0x004AB201 File Offset: 0x004A9401
		public static void AddShowDistance(FlatBufferBuilder builder, int showDistance)
		{
			builder.AddInt(6, showDistance, 0);
		}

		// Token: 0x06021DD5 RID: 138709 RVA: 0x004AB20C File Offset: 0x004A940C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06021DD6 RID: 138710 RVA: 0x004AB217 File Offset: 0x004A9417
		public static Offset<IBossStateViewConfig> EndIBossStateViewConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBossStateViewConfig>(builder.EndTable());
		}

		// Token: 0x06021DD7 RID: 138711 RVA: 0x004AB224 File Offset: 0x004A9424
		public IBossStateViewConfigT UnPack()
		{
			IBossStateViewConfigT bossStateViewConfigT = new IBossStateViewConfigT();
			this.UnPackTo(bossStateViewConfigT);
			return bossStateViewConfigT;
		}

		// Token: 0x06021DD8 RID: 138712 RVA: 0x004AB240 File Offset: 0x004A9440
		public void UnPackTo(IBossStateViewConfigT _o)
		{
			_o.BossStateViewType = this.BossStateViewType;
			_o.BossStateViewStyle = ((this.BossStateViewStyle != null) ? this.BossStateViewStyle.Value.UnPack() : null);
			_o.TidBossSubTitle = this.TidBossSubTitle;
			_o.BossStateInfoShowType = this.BossStateInfoShowType;
			_o.TidLevelText = this.TidLevelText;
			_o.OnlyShowInBattleState = this.OnlyShowInBattleState;
			_o.ShowDistance = this.ShowDistance;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021DD9 RID: 138713 RVA: 0x004AB2D0 File Offset: 0x004A94D0
		public static Offset<IBossStateViewConfig> Pack(FlatBufferBuilder builder, IBossStateViewConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBossStateViewConfig>);
			}
			Offset<IDoubleViewBossStateViewStyle> bossStateViewStyleOffset = (_o.BossStateViewStyle == null) ? default(Offset<IDoubleViewBossStateViewStyle>) : IDoubleViewBossStateViewStyle.Pack(builder, _o.BossStateViewStyle);
			StringOffset tidBossSubTitleOffset = (_o.TidBossSubTitle == null) ? default(StringOffset) : builder.CreateString(_o.TidBossSubTitle);
			StringOffset tidLevelTextOffset = (_o.TidLevelText == null) ? default(StringOffset) : builder.CreateString(_o.TidLevelText);
			return IBossStateViewConfig.CreateIBossStateViewConfig(builder, _o.BossStateViewType, bossStateViewStyleOffset, tidBossSubTitleOffset, _o.BossStateInfoShowType, tidLevelTextOffset, _o.OnlyShowInBattleState, _o.ShowDistance, _o.NullMask);
		}

		// Token: 0x0400E917 RID: 59671
		private Table __p;
	}
}
