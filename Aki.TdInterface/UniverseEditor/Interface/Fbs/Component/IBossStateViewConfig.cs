using System;
using Aki.UniverseEditor.Interface.Fbs.Match;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F19 RID: 20249
	public struct IBossStateViewConfig : IFlatbufferObject
	{
		// Token: 0x170091D2 RID: 37330
		// (get) Token: 0x0602004A RID: 131146 RVA: 0x00474B07 File Offset: 0x00472D07
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602004B RID: 131147 RVA: 0x00474B14 File Offset: 0x00472D14
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602004C RID: 131148 RVA: 0x00474B1C File Offset: 0x00472D1C
		public static IBossStateViewConfig GetRootAsIBossStateViewConfig(ByteBuffer _bb)
		{
			return IBossStateViewConfig.GetRootAsIBossStateViewConfig(_bb, default(IBossStateViewConfig));
		}

		// Token: 0x0602004D RID: 131149 RVA: 0x00474B38 File Offset: 0x00472D38
		public static IBossStateViewConfig GetRootAsIBossStateViewConfig(ByteBuffer _bb, IBossStateViewConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602004E RID: 131150 RVA: 0x00474B55 File Offset: 0x00472D55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602004F RID: 131151 RVA: 0x00474B64 File Offset: 0x00472D64
		public IBossStateViewConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170091D3 RID: 37331
		// (get) Token: 0x06020050 RID: 131152 RVA: 0x00474B74 File Offset: 0x00472D74
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

		// Token: 0x170091D4 RID: 37332
		// (get) Token: 0x06020051 RID: 131153 RVA: 0x00474BB0 File Offset: 0x00472DB0
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

		// Token: 0x170091D5 RID: 37333
		// (get) Token: 0x06020052 RID: 131154 RVA: 0x00474C10 File Offset: 0x00472E10
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

		// Token: 0x06020053 RID: 131155 RVA: 0x00474C47 File Offset: 0x00472E47
		public Span<byte> GetTidBossSubTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06020054 RID: 131156 RVA: 0x00474C56 File Offset: 0x00472E56
		public byte[] GetTidBossSubTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x170091D6 RID: 37334
		// (get) Token: 0x06020055 RID: 131157 RVA: 0x00474C64 File Offset: 0x00472E64
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

		// Token: 0x170091D7 RID: 37335
		// (get) Token: 0x06020056 RID: 131158 RVA: 0x00474CA4 File Offset: 0x00472EA4
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

		// Token: 0x06020057 RID: 131159 RVA: 0x00474CDC File Offset: 0x00472EDC
		public Span<byte> GetTidLevelTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06020058 RID: 131160 RVA: 0x00474CEC File Offset: 0x00472EEC
		public byte[] GetTidLevelTextArray()
		{
			return this.__p.__vector_as_array<byte>(12);
		}

		// Token: 0x170091D8 RID: 37336
		// (get) Token: 0x06020059 RID: 131161 RVA: 0x00474CFC File Offset: 0x00472EFC
		public bool OnlyShowInBattleState
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170091D9 RID: 37337
		// (get) Token: 0x0602005A RID: 131162 RVA: 0x00474D3C File Offset: 0x00472F3C
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

		// Token: 0x170091DA RID: 37338
		// (get) Token: 0x0602005B RID: 131163 RVA: 0x00474D7C File Offset: 0x00472F7C
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

		// Token: 0x0602005C RID: 131164 RVA: 0x00474DBC File Offset: 0x00472FBC
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

		// Token: 0x0602005D RID: 131165 RVA: 0x00474E13 File Offset: 0x00473013
		public static void StartIBossStateViewConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602005E RID: 131166 RVA: 0x00474E1C File Offset: 0x0047301C
		public static void AddBossStateViewType(FlatBufferBuilder builder, EBossStateViewType bossStateViewType)
		{
			builder.AddByte(0, (byte)bossStateViewType, 0);
		}

		// Token: 0x0602005F RID: 131167 RVA: 0x00474E27 File Offset: 0x00473027
		public static void AddBossStateViewStyle(FlatBufferBuilder builder, Offset<IDoubleViewBossStateViewStyle> bossStateViewStyleOffset)
		{
			builder.AddOffset(1, bossStateViewStyleOffset.Value, 0);
		}

		// Token: 0x06020060 RID: 131168 RVA: 0x00474E37 File Offset: 0x00473037
		public static void AddTidBossSubTitle(FlatBufferBuilder builder, StringOffset tidBossSubTitleOffset)
		{
			builder.AddOffset(2, tidBossSubTitleOffset.Value, 0);
		}

		// Token: 0x06020061 RID: 131169 RVA: 0x00474E47 File Offset: 0x00473047
		public static void AddBossStateInfoShowType(FlatBufferBuilder builder, EBossStateInfoShowType bossStateInfoShowType)
		{
			builder.AddByte(3, (byte)bossStateInfoShowType, 0);
		}

		// Token: 0x06020062 RID: 131170 RVA: 0x00474E52 File Offset: 0x00473052
		public static void AddTidLevelText(FlatBufferBuilder builder, StringOffset tidLevelTextOffset)
		{
			builder.AddOffset(4, tidLevelTextOffset.Value, 0);
		}

		// Token: 0x06020063 RID: 131171 RVA: 0x00474E62 File Offset: 0x00473062
		public static void AddOnlyShowInBattleState(FlatBufferBuilder builder, bool onlyShowInBattleState)
		{
			builder.AddBool(5, onlyShowInBattleState, false);
		}

		// Token: 0x06020064 RID: 131172 RVA: 0x00474E6D File Offset: 0x0047306D
		public static void AddShowDistance(FlatBufferBuilder builder, int showDistance)
		{
			builder.AddInt(6, showDistance, 0);
		}

		// Token: 0x06020065 RID: 131173 RVA: 0x00474E78 File Offset: 0x00473078
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06020066 RID: 131174 RVA: 0x00474E83 File Offset: 0x00473083
		public static Offset<IBossStateViewConfig> EndIBossStateViewConfig(FlatBufferBuilder builder)
		{
			return new Offset<IBossStateViewConfig>(builder.EndTable());
		}

		// Token: 0x06020067 RID: 131175 RVA: 0x00474E90 File Offset: 0x00473090
		public IBossStateViewConfigT UnPack()
		{
			IBossStateViewConfigT bossStateViewConfigT = new IBossStateViewConfigT();
			this.UnPackTo(bossStateViewConfigT);
			return bossStateViewConfigT;
		}

		// Token: 0x06020068 RID: 131176 RVA: 0x00474EAC File Offset: 0x004730AC
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

		// Token: 0x06020069 RID: 131177 RVA: 0x00474F3C File Offset: 0x0047313C
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

		// Token: 0x0400DD68 RID: 56680
		private Table __p;
	}
}
