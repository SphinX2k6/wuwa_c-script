using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078A2 RID: 30882
	public struct IShowCenterText : IFlatbufferObject
	{
		// Token: 0x1700E26A RID: 57962
		// (get) Token: 0x06036525 RID: 222501 RVA: 0x0074604A File Offset: 0x0074424A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036526 RID: 222502 RVA: 0x00746057 File Offset: 0x00744257
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036527 RID: 222503 RVA: 0x00746060 File Offset: 0x00744260
		public static IShowCenterText GetRootAsIShowCenterText(ByteBuffer _bb)
		{
			return IShowCenterText.GetRootAsIShowCenterText(_bb, default(IShowCenterText));
		}

		// Token: 0x06036528 RID: 222504 RVA: 0x0074607C File Offset: 0x0074427C
		public static IShowCenterText GetRootAsIShowCenterText(ByteBuffer _bb, IShowCenterText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036529 RID: 222505 RVA: 0x00746099 File Offset: 0x00744299
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603652A RID: 222506 RVA: 0x007460A8 File Offset: 0x007442A8
		public IShowCenterText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E26B RID: 57963
		// (get) Token: 0x0603652B RID: 222507 RVA: 0x007460B8 File Offset: 0x007442B8
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

		// Token: 0x1700E26C RID: 57964
		// (get) Token: 0x0603652C RID: 222508 RVA: 0x007460F4 File Offset: 0x007442F4
		public string TidCenterText
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

		// Token: 0x0603652D RID: 222509 RVA: 0x0074612B File Offset: 0x0074432B
		public Span<byte> GetTidCenterTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603652E RID: 222510 RVA: 0x0074613A File Offset: 0x0074433A
		public byte[] GetTidCenterTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700E26D RID: 57965
		// (get) Token: 0x0603652F RID: 222511 RVA: 0x00746148 File Offset: 0x00744348
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

		// Token: 0x06036530 RID: 222512 RVA: 0x0074617F File Offset: 0x0074437F
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06036531 RID: 222513 RVA: 0x0074618E File Offset: 0x0074438E
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700E26E RID: 57966
		// (get) Token: 0x06036532 RID: 222514 RVA: 0x0074619C File Offset: 0x0074439C
		public float TotalTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E26F RID: 57967
		// (get) Token: 0x06036533 RID: 222515 RVA: 0x007461E0 File Offset: 0x007443E0
		public ITextStyle? TextStyle
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ITextStyle?(default(ITextStyle).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E270 RID: 57968
		// (get) Token: 0x06036534 RID: 222516 RVA: 0x00746240 File Offset: 0x00744440
		public string BgImageId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036535 RID: 222517 RVA: 0x00746278 File Offset: 0x00744478
		public Span<byte> GetBgImageIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06036536 RID: 222518 RVA: 0x00746288 File Offset: 0x00744488
		public byte[] GetBgImageIdArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700E271 RID: 57969
		// (get) Token: 0x06036537 RID: 222519 RVA: 0x00746298 File Offset: 0x00744498
		public bool IsMulLine
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E272 RID: 57970
		// (get) Token: 0x06036538 RID: 222520 RVA: 0x007462D8 File Offset: 0x007444D8
		public bool IsManualNext
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E273 RID: 57971
		// (get) Token: 0x06036539 RID: 222521 RVA: 0x00746318 File Offset: 0x00744518
		public bool IsCancelAutoLine
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E274 RID: 57972
		// (get) Token: 0x0603653A RID: 222522 RVA: 0x00746358 File Offset: 0x00744558
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603653B RID: 222523 RVA: 0x00746398 File Offset: 0x00744598
		public static Offset<IShowCenterText> CreateIShowCenterText(FlatBufferBuilder builder, int TextId = 0, StringOffset TidCenterTextOffset = default(StringOffset), StringOffset PlotLineKeyOffset = default(StringOffset), float TotalTime = 0f, Offset<ITextStyle> TextStyleOffset = default(Offset<ITextStyle>), StringOffset BgImageIdOffset = default(StringOffset), bool IsMulLine = false, bool IsManualNext = false, bool IsCancelAutoLine = false, byte NullMask = 0)
		{
			builder.StartTable(10);
			IShowCenterText.AddBgImageId(builder, BgImageIdOffset);
			IShowCenterText.AddTextStyle(builder, TextStyleOffset);
			IShowCenterText.AddTotalTime(builder, TotalTime);
			IShowCenterText.AddPlotLineKey(builder, PlotLineKeyOffset);
			IShowCenterText.AddTidCenterText(builder, TidCenterTextOffset);
			IShowCenterText.AddTextId(builder, TextId);
			IShowCenterText.AddNullMask(builder, NullMask);
			IShowCenterText.AddIsCancelAutoLine(builder, IsCancelAutoLine);
			IShowCenterText.AddIsManualNext(builder, IsManualNext);
			IShowCenterText.AddIsMulLine(builder, IsMulLine);
			return IShowCenterText.EndIShowCenterText(builder);
		}

		// Token: 0x0603653C RID: 222524 RVA: 0x00746400 File Offset: 0x00744600
		public static void StartIShowCenterText(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0603653D RID: 222525 RVA: 0x0074640A File Offset: 0x0074460A
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(0, textId, 0);
		}

		// Token: 0x0603653E RID: 222526 RVA: 0x00746415 File Offset: 0x00744615
		public static void AddTidCenterText(FlatBufferBuilder builder, StringOffset tidCenterTextOffset)
		{
			builder.AddOffset(1, tidCenterTextOffset.Value, 0);
		}

		// Token: 0x0603653F RID: 222527 RVA: 0x00746425 File Offset: 0x00744625
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(2, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x06036540 RID: 222528 RVA: 0x00746435 File Offset: 0x00744635
		public static void AddTotalTime(FlatBufferBuilder builder, float totalTime)
		{
			builder.AddFloat(3, totalTime, 0.0);
		}

		// Token: 0x06036541 RID: 222529 RVA: 0x00746448 File Offset: 0x00744648
		public static void AddTextStyle(FlatBufferBuilder builder, Offset<ITextStyle> textStyleOffset)
		{
			builder.AddOffset(4, textStyleOffset.Value, 0);
		}

		// Token: 0x06036542 RID: 222530 RVA: 0x00746458 File Offset: 0x00744658
		public static void AddBgImageId(FlatBufferBuilder builder, StringOffset bgImageIdOffset)
		{
			builder.AddOffset(5, bgImageIdOffset.Value, 0);
		}

		// Token: 0x06036543 RID: 222531 RVA: 0x00746468 File Offset: 0x00744668
		public static void AddIsMulLine(FlatBufferBuilder builder, bool isMulLine)
		{
			builder.AddBool(6, isMulLine, false);
		}

		// Token: 0x06036544 RID: 222532 RVA: 0x00746473 File Offset: 0x00744673
		public static void AddIsManualNext(FlatBufferBuilder builder, bool isManualNext)
		{
			builder.AddBool(7, isManualNext, false);
		}

		// Token: 0x06036545 RID: 222533 RVA: 0x0074647E File Offset: 0x0074467E
		public static void AddIsCancelAutoLine(FlatBufferBuilder builder, bool isCancelAutoLine)
		{
			builder.AddBool(8, isCancelAutoLine, false);
		}

		// Token: 0x06036546 RID: 222534 RVA: 0x00746489 File Offset: 0x00744689
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06036547 RID: 222535 RVA: 0x00746495 File Offset: 0x00744695
		public static Offset<IShowCenterText> EndIShowCenterText(FlatBufferBuilder builder)
		{
			return new Offset<IShowCenterText>(builder.EndTable());
		}

		// Token: 0x06036548 RID: 222536 RVA: 0x007464A4 File Offset: 0x007446A4
		public IShowCenterTextT UnPack()
		{
			IShowCenterTextT showCenterTextT = new IShowCenterTextT();
			this.UnPackTo(showCenterTextT);
			return showCenterTextT;
		}

		// Token: 0x06036549 RID: 222537 RVA: 0x007464C0 File Offset: 0x007446C0
		public void UnPackTo(IShowCenterTextT _o)
		{
			_o.TextId = this.TextId;
			_o.TidCenterText = this.TidCenterText;
			_o.PlotLineKey = this.PlotLineKey;
			_o.TotalTime = this.TotalTime;
			_o.TextStyle = ((this.TextStyle != null) ? this.TextStyle.Value.UnPack() : null);
			_o.BgImageId = this.BgImageId;
			_o.IsMulLine = this.IsMulLine;
			_o.IsManualNext = this.IsManualNext;
			_o.IsCancelAutoLine = this.IsCancelAutoLine;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603654A RID: 222538 RVA: 0x00746568 File Offset: 0x00744768
		public static Offset<IShowCenterText> Pack(FlatBufferBuilder builder, IShowCenterTextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowCenterText>);
			}
			StringOffset tidCenterTextOffset = (_o.TidCenterText == null) ? default(StringOffset) : builder.CreateString(_o.TidCenterText);
			StringOffset plotLineKeyOffset = (_o.PlotLineKey == null) ? default(StringOffset) : builder.CreateString(_o.PlotLineKey);
			Offset<ITextStyle> textStyleOffset = (_o.TextStyle == null) ? default(Offset<ITextStyle>) : ITextStyle.Pack(builder, _o.TextStyle);
			StringOffset bgImageIdOffset = (_o.BgImageId == null) ? default(StringOffset) : builder.CreateString(_o.BgImageId);
			return IShowCenterText.CreateIShowCenterText(builder, _o.TextId, tidCenterTextOffset, plotLineKeyOffset, _o.TotalTime, textStyleOffset, bgImageIdOffset, _o.IsMulLine, _o.IsManualNext, _o.IsCancelAutoLine, _o.NullMask);
		}

		// Token: 0x04012B2E RID: 76590
		private Table __p;
	}
}
