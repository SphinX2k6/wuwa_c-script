using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074D7 RID: 29911
	public struct IPlotModeUiStyleLevelD : IFlatbufferObject
	{
		// Token: 0x1700DC0C RID: 56332
		// (get) Token: 0x060346D8 RID: 214744 RVA: 0x0070F27A File Offset: 0x0070D47A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060346D9 RID: 214745 RVA: 0x0070F287 File Offset: 0x0070D487
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060346DA RID: 214746 RVA: 0x0070F290 File Offset: 0x0070D490
		public static IPlotModeUiStyleLevelD GetRootAsIPlotModeUiStyleLevelD(ByteBuffer _bb)
		{
			return IPlotModeUiStyleLevelD.GetRootAsIPlotModeUiStyleLevelD(_bb, default(IPlotModeUiStyleLevelD));
		}

		// Token: 0x060346DB RID: 214747 RVA: 0x0070F2AC File Offset: 0x0070D4AC
		public static IPlotModeUiStyleLevelD GetRootAsIPlotModeUiStyleLevelD(ByteBuffer _bb, IPlotModeUiStyleLevelD obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060346DC RID: 214748 RVA: 0x0070F2C9 File Offset: 0x0070D4C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060346DD RID: 214749 RVA: 0x0070F2D8 File Offset: 0x0070D4D8
		public IPlotModeUiStyleLevelD __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DC0D RID: 56333
		// (get) Token: 0x060346DE RID: 214750 RVA: 0x0070F2E8 File Offset: 0x0070D4E8
		public EPlotModeUiStyleType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPlotModeUiStyleType.LevelD;
				}
				return (EPlotModeUiStyleType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DC0E RID: 56334
		// (get) Token: 0x060346DF RID: 214751 RVA: 0x0070F324 File Offset: 0x0070D524
		public TUiStyleOfLevelD UiStyleType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TUiStyleOfLevelD.NONE;
				}
				return (TUiStyleOfLevelD)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060346E0 RID: 214752 RVA: 0x0070F360 File Offset: 0x0070D560
		public TTable? UiStyle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060346E1 RID: 214753 RVA: 0x0070F3A4 File Offset: 0x0070D5A4
		public IUiStyleGiantSubtitleOfLevelD UiStyleAsIUiStyleGiantSubtitleOfLevelD()
		{
			return this.UiStyle<IUiStyleGiantSubtitleOfLevelD>().Value;
		}

		// Token: 0x060346E2 RID: 214754 RVA: 0x0070F3C0 File Offset: 0x0070D5C0
		public IUiStylePlayPianoOfLevelD UiStyleAsIUiStylePlayPianoOfLevelD()
		{
			return this.UiStyle<IUiStylePlayPianoOfLevelD>().Value;
		}

		// Token: 0x060346E3 RID: 214755 RVA: 0x0070F3DB File Offset: 0x0070D5DB
		public static Offset<IPlotModeUiStyleLevelD> CreateIPlotModeUiStyleLevelD(FlatBufferBuilder builder, EPlotModeUiStyleType Type = EPlotModeUiStyleType.LevelD, TUiStyleOfLevelD UiStyle_type = TUiStyleOfLevelD.NONE, int UiStyleOffset = 0)
		{
			builder.StartTable(3);
			IPlotModeUiStyleLevelD.AddUiStyle(builder, UiStyleOffset);
			IPlotModeUiStyleLevelD.AddUiStyleType(builder, UiStyle_type);
			IPlotModeUiStyleLevelD.AddType(builder, Type);
			return IPlotModeUiStyleLevelD.EndIPlotModeUiStyleLevelD(builder);
		}

		// Token: 0x060346E4 RID: 214756 RVA: 0x0070F3FF File Offset: 0x0070D5FF
		public static void StartIPlotModeUiStyleLevelD(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060346E5 RID: 214757 RVA: 0x0070F408 File Offset: 0x0070D608
		public static void AddType(FlatBufferBuilder builder, EPlotModeUiStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060346E6 RID: 214758 RVA: 0x0070F413 File Offset: 0x0070D613
		public static void AddUiStyleType(FlatBufferBuilder builder, TUiStyleOfLevelD uiStyleType)
		{
			builder.AddByte(1, (byte)uiStyleType, 0);
		}

		// Token: 0x060346E7 RID: 214759 RVA: 0x0070F41E File Offset: 0x0070D61E
		public static void AddUiStyle(FlatBufferBuilder builder, int uiStyleOffset)
		{
			builder.AddOffset(2, uiStyleOffset, 0);
		}

		// Token: 0x060346E8 RID: 214760 RVA: 0x0070F429 File Offset: 0x0070D629
		public static Offset<IPlotModeUiStyleLevelD> EndIPlotModeUiStyleLevelD(FlatBufferBuilder builder)
		{
			return new Offset<IPlotModeUiStyleLevelD>(builder.EndTable());
		}

		// Token: 0x060346E9 RID: 214761 RVA: 0x0070F438 File Offset: 0x0070D638
		public IPlotModeUiStyleLevelDT UnPack()
		{
			IPlotModeUiStyleLevelDT plotModeUiStyleLevelDT = new IPlotModeUiStyleLevelDT();
			this.UnPackTo(plotModeUiStyleLevelDT);
			return plotModeUiStyleLevelDT;
		}

		// Token: 0x060346EA RID: 214762 RVA: 0x0070F454 File Offset: 0x0070D654
		public void UnPackTo(IPlotModeUiStyleLevelDT _o)
		{
			_o.Type = this.Type;
			_o.UiStyle = new TUiStyleOfLevelDUnion();
			_o.UiStyle.Type = this.UiStyleType;
			TUiStyleOfLevelD uiStyleType = this.UiStyleType;
			if (uiStyleType == TUiStyleOfLevelD.IUiStyleGiantSubtitleOfLevelD)
			{
				_o.UiStyle.Value = ((this.UiStyle<IUiStyleGiantSubtitleOfLevelD>() != null) ? this.UiStyle<IUiStyleGiantSubtitleOfLevelD>().Value.UnPack() : null);
				return;
			}
			if (uiStyleType != TUiStyleOfLevelD.IUiStylePlayPianoOfLevelD)
			{
				return;
			}
			_o.UiStyle.Value = ((this.UiStyle<IUiStylePlayPianoOfLevelD>() != null) ? this.UiStyle<IUiStylePlayPianoOfLevelD>().Value.UnPack() : null);
		}

		// Token: 0x060346EB RID: 214763 RVA: 0x0070F504 File Offset: 0x0070D704
		public static Offset<IPlotModeUiStyleLevelD> Pack(FlatBufferBuilder builder, IPlotModeUiStyleLevelDT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlotModeUiStyleLevelD>);
			}
			TUiStyleOfLevelD uiStyle_type = (_o.UiStyle == null) ? TUiStyleOfLevelD.NONE : _o.UiStyle.Type;
			int uiStyleOffset = (_o.UiStyle == null) ? 0 : TUiStyleOfLevelDUnion.Pack(builder, _o.UiStyle);
			return IPlotModeUiStyleLevelD.CreateIPlotModeUiStyleLevelD(builder, _o.Type, uiStyle_type, uiStyleOffset);
		}

		// Token: 0x0401268C RID: 75404
		private Table __p;
	}
}
