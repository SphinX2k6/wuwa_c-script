using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BB7 RID: 31671
	public struct ITextStyle : IFlatbufferObject
	{
		// Token: 0x1700ED3F RID: 60735
		// (get) Token: 0x06039133 RID: 233779 RVA: 0x007B6C7E File Offset: 0x007B4E7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039134 RID: 233780 RVA: 0x007B6C8B File Offset: 0x007B4E8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039135 RID: 233781 RVA: 0x007B6C94 File Offset: 0x007B4E94
		public static ITextStyle GetRootAsITextStyle(ByteBuffer _bb)
		{
			return ITextStyle.GetRootAsITextStyle(_bb, default(ITextStyle));
		}

		// Token: 0x06039136 RID: 233782 RVA: 0x007B6CB0 File Offset: 0x007B4EB0
		public static ITextStyle GetRootAsITextStyle(ByteBuffer _bb, ITextStyle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039137 RID: 233783 RVA: 0x007B6CCD File Offset: 0x007B4ECD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039138 RID: 233784 RVA: 0x007B6CDC File Offset: 0x007B4EDC
		public ITextStyle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED40 RID: 60736
		// (get) Token: 0x06039139 RID: 233785 RVA: 0x007B6CEC File Offset: 0x007B4EEC
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

		// Token: 0x0603913A RID: 233786 RVA: 0x007B6D28 File Offset: 0x007B4F28
		public TTable? ShowAnim<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0603913B RID: 233787 RVA: 0x007B6D6C File Offset: 0x007B4F6C
		public IICenterTextFadeOut ShowAnimAsIICenterTextFadeOut()
		{
			return this.ShowAnim<IICenterTextFadeOut>().Value;
		}

		// Token: 0x0603913C RID: 233788 RVA: 0x007B6D88 File Offset: 0x007B4F88
		public IICenterTextShowAll ShowAnimAsIICenterTextShowAll()
		{
			return this.ShowAnim<IICenterTextShowAll>().Value;
		}

		// Token: 0x0603913D RID: 233789 RVA: 0x007B6DA4 File Offset: 0x007B4FA4
		public IICenterTextTypeWriter ShowAnimAsIICenterTextTypeWriter()
		{
			return this.ShowAnim<IICenterTextTypeWriter>().Value;
		}

		// Token: 0x1700ED41 RID: 60737
		// (get) Token: 0x0603913E RID: 233790 RVA: 0x007B6DC0 File Offset: 0x007B4FC0
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

		// Token: 0x1700ED42 RID: 60738
		// (get) Token: 0x0603913F RID: 233791 RVA: 0x007B6DFC File Offset: 0x007B4FFC
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

		// Token: 0x1700ED43 RID: 60739
		// (get) Token: 0x06039140 RID: 233792 RVA: 0x007B6E3C File Offset: 0x007B503C
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

		// Token: 0x1700ED44 RID: 60740
		// (get) Token: 0x06039141 RID: 233793 RVA: 0x007B6E7C File Offset: 0x007B507C
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

		// Token: 0x06039142 RID: 233794 RVA: 0x007B6EB9 File Offset: 0x007B50B9
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

		// Token: 0x06039143 RID: 233795 RVA: 0x007B6EF5 File Offset: 0x007B50F5
		public static void StartITextStyle(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06039144 RID: 233796 RVA: 0x007B6EFE File Offset: 0x007B50FE
		public static void AddShowAnimType(FlatBufferBuilder builder, TCenterTextShowAnim showAnimType)
		{
			builder.AddByte(0, (byte)showAnimType, 0);
		}

		// Token: 0x06039145 RID: 233797 RVA: 0x007B6F09 File Offset: 0x007B5109
		public static void AddShowAnim(FlatBufferBuilder builder, int showAnimOffset)
		{
			builder.AddOffset(1, showAnimOffset, 0);
		}

		// Token: 0x06039146 RID: 233798 RVA: 0x007B6F14 File Offset: 0x007B5114
		public static void AddFontSize(FlatBufferBuilder builder, EFontSize fontSize)
		{
			builder.AddByte(2, (byte)fontSize, 0);
		}

		// Token: 0x06039147 RID: 233799 RVA: 0x007B6F1F File Offset: 0x007B511F
		public static void AddTextAlign(FlatBufferBuilder builder, ETextAlign textAlign)
		{
			builder.AddByte(3, (byte)textAlign, 0);
		}

		// Token: 0x06039148 RID: 233800 RVA: 0x007B6F2A File Offset: 0x007B512A
		public static void AddTextHorizontal(FlatBufferBuilder builder, ETextHorizontal textHorizontal)
		{
			builder.AddByte(4, (byte)textHorizontal, 0);
		}

		// Token: 0x06039149 RID: 233801 RVA: 0x007B6F35 File Offset: 0x007B5135
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0603914A RID: 233802 RVA: 0x007B6F40 File Offset: 0x007B5140
		public static Offset<ITextStyle> EndITextStyle(FlatBufferBuilder builder)
		{
			return new Offset<ITextStyle>(builder.EndTable());
		}

		// Token: 0x0603914B RID: 233803 RVA: 0x007B6F50 File Offset: 0x007B5150
		public ITextStyleT UnPack()
		{
			ITextStyleT textStyleT = new ITextStyleT();
			this.UnPackTo(textStyleT);
			return textStyleT;
		}

		// Token: 0x0603914C RID: 233804 RVA: 0x007B6F6C File Offset: 0x007B516C
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

		// Token: 0x0603914D RID: 233805 RVA: 0x007B708C File Offset: 0x007B528C
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

		// Token: 0x04013232 RID: 78386
		private Table __p;
	}
}
