using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D5C RID: 27996
	public struct IPlotModeUiStyleLevelD : IFlatbufferObject
	{
		// Token: 0x1700D0C4 RID: 53444
		// (get) Token: 0x060316DC RID: 202460 RVA: 0x006B3B92 File Offset: 0x006B1D92
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060316DD RID: 202461 RVA: 0x006B3B9F File Offset: 0x006B1D9F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060316DE RID: 202462 RVA: 0x006B3BA8 File Offset: 0x006B1DA8
		public static IPlotModeUiStyleLevelD GetRootAsIPlotModeUiStyleLevelD(ByteBuffer _bb)
		{
			return IPlotModeUiStyleLevelD.GetRootAsIPlotModeUiStyleLevelD(_bb, default(IPlotModeUiStyleLevelD));
		}

		// Token: 0x060316DF RID: 202463 RVA: 0x006B3BC4 File Offset: 0x006B1DC4
		public static IPlotModeUiStyleLevelD GetRootAsIPlotModeUiStyleLevelD(ByteBuffer _bb, IPlotModeUiStyleLevelD obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060316E0 RID: 202464 RVA: 0x006B3BE1 File Offset: 0x006B1DE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060316E1 RID: 202465 RVA: 0x006B3BF0 File Offset: 0x006B1DF0
		public IPlotModeUiStyleLevelD __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D0C5 RID: 53445
		// (get) Token: 0x060316E2 RID: 202466 RVA: 0x006B3C00 File Offset: 0x006B1E00
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

		// Token: 0x1700D0C6 RID: 53446
		// (get) Token: 0x060316E3 RID: 202467 RVA: 0x006B3C3C File Offset: 0x006B1E3C
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

		// Token: 0x060316E4 RID: 202468 RVA: 0x006B3C78 File Offset: 0x006B1E78
		public TTable? UiStyle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060316E5 RID: 202469 RVA: 0x006B3CBC File Offset: 0x006B1EBC
		public IUiStyleGiantSubtitleOfLevelD UiStyleAsIUiStyleGiantSubtitleOfLevelD()
		{
			return this.UiStyle<IUiStyleGiantSubtitleOfLevelD>().Value;
		}

		// Token: 0x060316E6 RID: 202470 RVA: 0x006B3CD8 File Offset: 0x006B1ED8
		public IUiStylePlayPianoOfLevelD UiStyleAsIUiStylePlayPianoOfLevelD()
		{
			return this.UiStyle<IUiStylePlayPianoOfLevelD>().Value;
		}

		// Token: 0x060316E7 RID: 202471 RVA: 0x006B3CF3 File Offset: 0x006B1EF3
		public static Offset<IPlotModeUiStyleLevelD> CreateIPlotModeUiStyleLevelD(FlatBufferBuilder builder, EPlotModeUiStyleType Type = EPlotModeUiStyleType.LevelD, TUiStyleOfLevelD UiStyle_type = TUiStyleOfLevelD.NONE, int UiStyleOffset = 0)
		{
			builder.StartTable(3);
			IPlotModeUiStyleLevelD.AddUiStyle(builder, UiStyleOffset);
			IPlotModeUiStyleLevelD.AddUiStyleType(builder, UiStyle_type);
			IPlotModeUiStyleLevelD.AddType(builder, Type);
			return IPlotModeUiStyleLevelD.EndIPlotModeUiStyleLevelD(builder);
		}

		// Token: 0x060316E8 RID: 202472 RVA: 0x006B3D17 File Offset: 0x006B1F17
		public static void StartIPlotModeUiStyleLevelD(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060316E9 RID: 202473 RVA: 0x006B3D20 File Offset: 0x006B1F20
		public static void AddType(FlatBufferBuilder builder, EPlotModeUiStyleType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060316EA RID: 202474 RVA: 0x006B3D2B File Offset: 0x006B1F2B
		public static void AddUiStyleType(FlatBufferBuilder builder, TUiStyleOfLevelD uiStyleType)
		{
			builder.AddByte(1, (byte)uiStyleType, 0);
		}

		// Token: 0x060316EB RID: 202475 RVA: 0x006B3D36 File Offset: 0x006B1F36
		public static void AddUiStyle(FlatBufferBuilder builder, int uiStyleOffset)
		{
			builder.AddOffset(2, uiStyleOffset, 0);
		}

		// Token: 0x060316EC RID: 202476 RVA: 0x006B3D41 File Offset: 0x006B1F41
		public static Offset<IPlotModeUiStyleLevelD> EndIPlotModeUiStyleLevelD(FlatBufferBuilder builder)
		{
			return new Offset<IPlotModeUiStyleLevelD>(builder.EndTable());
		}

		// Token: 0x060316ED RID: 202477 RVA: 0x006B3D50 File Offset: 0x006B1F50
		public IPlotModeUiStyleLevelDT UnPack()
		{
			IPlotModeUiStyleLevelDT plotModeUiStyleLevelDT = new IPlotModeUiStyleLevelDT();
			this.UnPackTo(plotModeUiStyleLevelDT);
			return plotModeUiStyleLevelDT;
		}

		// Token: 0x060316EE RID: 202478 RVA: 0x006B3D6C File Offset: 0x006B1F6C
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

		// Token: 0x060316EF RID: 202479 RVA: 0x006B3E1C File Offset: 0x006B201C
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

		// Token: 0x04011710 RID: 71440
		private Table __p;
	}
}
