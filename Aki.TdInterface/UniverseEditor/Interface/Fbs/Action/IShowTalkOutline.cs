using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078CC RID: 30924
	public struct IShowTalkOutline : IFlatbufferObject
	{
		// Token: 0x1700E2EE RID: 58094
		// (get) Token: 0x06036711 RID: 222993 RVA: 0x0074A446 File Offset: 0x00748646
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036712 RID: 222994 RVA: 0x0074A453 File Offset: 0x00748653
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036713 RID: 222995 RVA: 0x0074A45C File Offset: 0x0074865C
		public static IShowTalkOutline GetRootAsIShowTalkOutline(ByteBuffer _bb)
		{
			return IShowTalkOutline.GetRootAsIShowTalkOutline(_bb, default(IShowTalkOutline));
		}

		// Token: 0x06036714 RID: 222996 RVA: 0x0074A478 File Offset: 0x00748678
		public static IShowTalkOutline GetRootAsIShowTalkOutline(ByteBuffer _bb, IShowTalkOutline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036715 RID: 222997 RVA: 0x0074A495 File Offset: 0x00748695
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036716 RID: 222998 RVA: 0x0074A4A4 File Offset: 0x007486A4
		public IShowTalkOutline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E2EF RID: 58095
		// (get) Token: 0x06036717 RID: 222999 RVA: 0x0074A4B4 File Offset: 0x007486B4
		public int TextId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E2F0 RID: 58096
		// (get) Token: 0x06036718 RID: 223000 RVA: 0x0074A4F0 File Offset: 0x007486F0
		public string TidOutline
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

		// Token: 0x06036719 RID: 223001 RVA: 0x0074A527 File Offset: 0x00748727
		public Span<byte> GetTidOutlineBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603671A RID: 223002 RVA: 0x0074A536 File Offset: 0x00748736
		public byte[] GetTidOutlineArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E2F1 RID: 58097
		// (get) Token: 0x0603671B RID: 223003 RVA: 0x0074A544 File Offset: 0x00748744
		public string PlotLineKey
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

		// Token: 0x0603671C RID: 223004 RVA: 0x0074A57B File Offset: 0x0074877B
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0603671D RID: 223005 RVA: 0x0074A58A File Offset: 0x0074878A
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x0603671E RID: 223006 RVA: 0x0074A598 File Offset: 0x00748798
		public static Offset<IShowTalkOutline> CreateIShowTalkOutline(FlatBufferBuilder builder, int TextId = 0, StringOffset TidOutlineOffset = default(StringOffset), StringOffset PlotLineKeyOffset = default(StringOffset))
		{
			builder.StartTable(3);
			IShowTalkOutline.AddPlotLineKey(builder, PlotLineKeyOffset);
			IShowTalkOutline.AddTidOutline(builder, TidOutlineOffset);
			IShowTalkOutline.AddTextId(builder, TextId);
			return IShowTalkOutline.EndIShowTalkOutline(builder);
		}

		// Token: 0x0603671F RID: 223007 RVA: 0x0074A5BC File Offset: 0x007487BC
		public static void StartIShowTalkOutline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036720 RID: 223008 RVA: 0x0074A5C5 File Offset: 0x007487C5
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(0, textId, 0);
		}

		// Token: 0x06036721 RID: 223009 RVA: 0x0074A5D0 File Offset: 0x007487D0
		public static void AddTidOutline(FlatBufferBuilder builder, StringOffset tidOutlineOffset)
		{
			builder.AddOffset(1, tidOutlineOffset.Value, 0);
		}

		// Token: 0x06036722 RID: 223010 RVA: 0x0074A5E0 File Offset: 0x007487E0
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(2, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x06036723 RID: 223011 RVA: 0x0074A5F0 File Offset: 0x007487F0
		public static Offset<IShowTalkOutline> EndIShowTalkOutline(FlatBufferBuilder builder)
		{
			return new Offset<IShowTalkOutline>(builder.EndTable());
		}

		// Token: 0x06036724 RID: 223012 RVA: 0x0074A600 File Offset: 0x00748800
		public IShowTalkOutlineT UnPack()
		{
			IShowTalkOutlineT showTalkOutlineT = new IShowTalkOutlineT();
			this.UnPackTo(showTalkOutlineT);
			return showTalkOutlineT;
		}

		// Token: 0x06036725 RID: 223013 RVA: 0x0074A61B File Offset: 0x0074881B
		public void UnPackTo(IShowTalkOutlineT _o)
		{
			_o.TextId = this.TextId;
			_o.TidOutline = this.TidOutline;
			_o.PlotLineKey = this.PlotLineKey;
		}

		// Token: 0x06036726 RID: 223014 RVA: 0x0074A644 File Offset: 0x00748844
		public static Offset<IShowTalkOutline> Pack(FlatBufferBuilder builder, IShowTalkOutlineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTalkOutline>);
			}
			StringOffset tidOutlineOffset = (_o.TidOutline == null) ? default(StringOffset) : builder.CreateString(_o.TidOutline);
			StringOffset plotLineKeyOffset = (_o.PlotLineKey == null) ? default(StringOffset) : builder.CreateString(_o.PlotLineKey);
			return IShowTalkOutline.CreateIShowTalkOutline(builder, _o.TextId, tidOutlineOffset, plotLineKeyOffset);
		}

		// Token: 0x04012B7C RID: 76668
		private Table __p;
	}
}
