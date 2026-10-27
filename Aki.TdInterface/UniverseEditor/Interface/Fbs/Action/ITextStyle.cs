using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073D0 RID: 29648
	public struct ITextStyle : IFlatbufferObject
	{
		// Token: 0x1700E12F RID: 57647
		// (get) Token: 0x06035D98 RID: 220568 RVA: 0x0075473E File Offset: 0x0075293E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035D99 RID: 220569 RVA: 0x0075474B File Offset: 0x0075294B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035D9A RID: 220570 RVA: 0x00754754 File Offset: 0x00752954
		public static ITextStyle GetRootAsITextStyle(ByteBuffer _bb)
		{
			return ITextStyle.GetRootAsITextStyle(_bb, default(ITextStyle));
		}

		// Token: 0x06035D9B RID: 220571 RVA: 0x00754770 File Offset: 0x00752970
		public static ITextStyle GetRootAsITextStyle(ByteBuffer _bb, ITextStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035D9C RID: 220572 RVA: 0x0075478D File Offset: 0x0075298D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035D9D RID: 220573 RVA: 0x0075479C File Offset: 0x0075299C
		public ITextStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E130 RID: 57648
		// (get) Token: 0x06035D9E RID: 220574 RVA: 0x007547AC File Offset: 0x007529AC
		public TCenterTextShowAnim ShowAnimType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TCenterTextShowAnim.NONE;
				}
				return (TCenterTextShowAnim)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035D9F RID: 220575 RVA: 0x007547E8 File Offset: 0x007529E8
		public TTable? ShowAnim<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035DA0 RID: 220576 RVA: 0x0075482C File Offset: 0x00752A2C
		public IICenterTextFadeOut ShowAnimAsIICenterTextFadeOut()
		{
			return this.ShowAnim<IICenterTextFadeOut>().Value;
		}

		// Token: 0x06035DA1 RID: 220577 RVA: 0x00754848 File Offset: 0x00752A48
		public IICenterTextShowAll ShowAnimAsIICenterTextShowAll()
		{
			return this.ShowAnim<IICenterTextShowAll>().Value;
		}

		// Token: 0x06035DA2 RID: 220578 RVA: 0x00754864 File Offset: 0x00752A64
		public IICenterTextTypeWriter ShowAnimAsIICenterTextTypeWriter()
		{
			return this.ShowAnim<IICenterTextTypeWriter>().Value;
		}

		// Token: 0x1700E131 RID: 57649
		// (get) Token: 0x06035DA3 RID: 220579 RVA: 0x00754880 File Offset: 0x00752A80
		public EFontSize FontSize
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EFontSize.Small;
				}
				return (EFontSize)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E132 RID: 57650
		// (get) Token: 0x06035DA4 RID: 220580 RVA: 0x007548BC File Offset: 0x00752ABC
		public ETextAlign TextAlign
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return ETextAlign.Top;
				}
				return (ETextAlign)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E133 RID: 57651
		// (get) Token: 0x06035DA5 RID: 220581 RVA: 0x007548FC File Offset: 0x00752AFC
		public ETextHorizontal TextHorizontal
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return ETextHorizontal.Left;
				}
				return (ETextHorizontal)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E134 RID: 57652
		// (get) Token: 0x06035DA6 RID: 220582 RVA: 0x0075493C File Offset: 0x00752B3C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035DA7 RID: 220583 RVA: 0x00754979 File Offset: 0x00752B79
		public static Offset<ITextStyle> CreateITextStyle(FlatBufferBuilder builder, TCenterTextShowAnim ShowAnim_type = TCenterTextShowAnim.NONE, int ShowAnimOffset = 0, EFontSize FontSize = EFontSize.Small, ETextAlign TextAlign = ETextAlign.Top, ETextHorizontal TextHorizontal = ETextHorizontal.Left, byte NullMask = 0)
		{
			builder.StartTable(6);
			ITextStyle.AddShowAnim(builder, ShowAnimOffset);
			ITextStyle.AddNullMask(builder, NullMask);
			ITextStyle.AddTextHorizontal(builder, TextHorizontal);
			ITextStyle.AddTextAlign(builder, TextAlign);
			ITextStyle.AddFontSize(builder, FontSize);
			ITextStyle.AddShowAnimType(builder, ShowAnim_type);
			return ITextStyle.EndITextStyle(builder);
		}

		// Token: 0x06035DA8 RID: 220584 RVA: 0x007549B5 File Offset: 0x00752BB5
		public static void StartITextStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06035DA9 RID: 220585 RVA: 0x007549BE File Offset: 0x00752BBE
		public static void AddShowAnimType(FlatBufferBuilder builder, TCenterTextShowAnim showAnimType)
		{
			builder.AddByte(0, (byte)showAnimType, 0);
		}

		// Token: 0x06035DAA RID: 220586 RVA: 0x007549C9 File Offset: 0x00752BC9
		public static void AddShowAnim(FlatBufferBuilder builder, int showAnimOffset)
		{
			builder.AddOffset(1, showAnimOffset, 0);
		}

		// Token: 0x06035DAB RID: 220587 RVA: 0x007549D4 File Offset: 0x00752BD4
		public static void AddFontSize(FlatBufferBuilder builder, EFontSize fontSize)
		{
			builder.AddByte(2, (byte)fontSize, 0);
		}

		// Token: 0x06035DAC RID: 220588 RVA: 0x007549DF File Offset: 0x00752BDF
		public static void AddTextAlign(FlatBufferBuilder builder, ETextAlign textAlign)
		{
			builder.AddByte(3, (byte)textAlign, 0);
		}

		// Token: 0x06035DAD RID: 220589 RVA: 0x007549EA File Offset: 0x00752BEA
		public static void AddTextHorizontal(FlatBufferBuilder builder, ETextHorizontal textHorizontal)
		{
			builder.AddByte(4, (byte)textHorizontal, 0);
		}

		// Token: 0x06035DAE RID: 220590 RVA: 0x007549F5 File Offset: 0x00752BF5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06035DAF RID: 220591 RVA: 0x00754A00 File Offset: 0x00752C00
		public static Offset<ITextStyle> EndITextStyle(FlatBufferBuilder builder)
		{
			return new Offset<ITextStyle>(builder.EndTable());
		}

		// Token: 0x06035DB0 RID: 220592 RVA: 0x00754A10 File Offset: 0x00752C10
		public ITextStyleT UnPack()
		{
			ITextStyleT textStyleT = new ITextStyleT();
			this.UnPackTo(textStyleT);
			return textStyleT;
		}

		// Token: 0x06035DB1 RID: 220593 RVA: 0x00754A2C File Offset: 0x00752C2C
		public void UnPackTo(ITextStyleT _o)
		{
			_o.ShowAnim = new TCenterTextShowAnimUnion();
			_o.ShowAnim.Type = this.ShowAnimType;
			switch (this.ShowAnimType)
			{
			case TCenterTextShowAnim.IICenterTextFadeOut:
				_o.ShowAnim.Value = ((this.ShowAnim<IICenterTextFadeOut>() != null) ? this.ShowAnim<IICenterTextFadeOut>().Value.UnPack() : null);
				break;
			case TCenterTextShowAnim.IICenterTextShowAll:
				_o.ShowAnim.Value = ((this.ShowAnim<IICenterTextShowAll>() != null) ? this.ShowAnim<IICenterTextShowAll>().Value.UnPack() : null);
				break;
			case TCenterTextShowAnim.IICenterTextTypeWriter:
				_o.ShowAnim.Value = ((this.ShowAnim<IICenterTextTypeWriter>() != null) ? this.ShowAnim<IICenterTextTypeWriter>().Value.UnPack() : null);
				break;
			}
			_o.FontSize = this.FontSize;
			_o.TextAlign = this.TextAlign;
			_o.TextHorizontal = this.TextHorizontal;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035DB2 RID: 220594 RVA: 0x00754B4C File Offset: 0x00752D4C
		public static Offset<ITextStyle> Pack(FlatBufferBuilder builder, ITextStyleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITextStyle>);
			}
			TCenterTextShowAnim showAnim_type = (_o.ShowAnim == null) ? TCenterTextShowAnim.NONE : _o.ShowAnim.Type;
			int showAnimOffset = (_o.ShowAnim == null) ? 0 : TCenterTextShowAnimUnion.Pack(builder, _o.ShowAnim);
			return ITextStyle.CreateITextStyle(builder, showAnim_type, showAnimOffset, _o.FontSize, _o.TextAlign, _o.TextHorizontal, _o.NullMask);
		}

		// Token: 0x04012219 RID: 74265
		private Table __p;
	}
}
