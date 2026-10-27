using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D6 RID: 28886
	public struct IShowCenterText : IFlatbufferObject
	{
		// Token: 0x1700D687 RID: 54919
		// (get) Token: 0x06033283 RID: 209539 RVA: 0x006E5A3E File Offset: 0x006E3C3E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033284 RID: 209540 RVA: 0x006E5A4B File Offset: 0x006E3C4B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033285 RID: 209541 RVA: 0x006E5A54 File Offset: 0x006E3C54
		public static IShowCenterText GetRootAsIShowCenterText(ByteBuffer _bb)
		{
			return IShowCenterText.GetRootAsIShowCenterText(_bb, default(IShowCenterText));
		}

		// Token: 0x06033286 RID: 209542 RVA: 0x006E5A70 File Offset: 0x006E3C70
		public static IShowCenterText GetRootAsIShowCenterText(ByteBuffer _bb, IShowCenterText obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033287 RID: 209543 RVA: 0x006E5A8D File Offset: 0x006E3C8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033288 RID: 209544 RVA: 0x006E5A9C File Offset: 0x006E3C9C
		public IShowCenterText __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D688 RID: 54920
		// (get) Token: 0x06033289 RID: 209545 RVA: 0x006E5AAC File Offset: 0x006E3CAC
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

		// Token: 0x1700D689 RID: 54921
		// (get) Token: 0x0603328A RID: 209546 RVA: 0x006E5AE8 File Offset: 0x006E3CE8
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

		// Token: 0x0603328B RID: 209547 RVA: 0x006E5B1F File Offset: 0x006E3D1F
		public Span<byte> GetTidCenterTextBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603328C RID: 209548 RVA: 0x006E5B2E File Offset: 0x006E3D2E
		public byte[] GetTidCenterTextArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700D68A RID: 54922
		// (get) Token: 0x0603328D RID: 209549 RVA: 0x006E5B3C File Offset: 0x006E3D3C
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

		// Token: 0x0603328E RID: 209550 RVA: 0x006E5B73 File Offset: 0x006E3D73
		public Span<byte> GetPlotLineKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0603328F RID: 209551 RVA: 0x006E5B82 File Offset: 0x006E3D82
		public byte[] GetPlotLineKeyArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700D68B RID: 54923
		// (get) Token: 0x06033290 RID: 209552 RVA: 0x006E5B90 File Offset: 0x006E3D90
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

		// Token: 0x1700D68C RID: 54924
		// (get) Token: 0x06033291 RID: 209553 RVA: 0x006E5BD4 File Offset: 0x006E3DD4
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

		// Token: 0x1700D68D RID: 54925
		// (get) Token: 0x06033292 RID: 209554 RVA: 0x006E5C34 File Offset: 0x006E3E34
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

		// Token: 0x06033293 RID: 209555 RVA: 0x006E5C6C File Offset: 0x006E3E6C
		public Span<byte> GetBgImageIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06033294 RID: 209556 RVA: 0x006E5C7C File Offset: 0x006E3E7C
		public byte[] GetBgImageIdArray()
		{
			return this.__p.__vector_as_array<byte>(14);
		}

		// Token: 0x1700D68E RID: 54926
		// (get) Token: 0x06033295 RID: 209557 RVA: 0x006E5C8C File Offset: 0x006E3E8C
		public bool IsMulLine
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D68F RID: 54927
		// (get) Token: 0x06033296 RID: 209558 RVA: 0x006E5CCC File Offset: 0x006E3ECC
		public bool IsManualNext
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D690 RID: 54928
		// (get) Token: 0x06033297 RID: 209559 RVA: 0x006E5D0C File Offset: 0x006E3F0C
		public bool IsCancelAutoLine
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D691 RID: 54929
		// (get) Token: 0x06033298 RID: 209560 RVA: 0x006E5D4C File Offset: 0x006E3F4C
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

		// Token: 0x06033299 RID: 209561 RVA: 0x006E5D8C File Offset: 0x006E3F8C
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

		// Token: 0x0603329A RID: 209562 RVA: 0x006E5DF4 File Offset: 0x006E3FF4
		public static void StartIShowCenterText(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0603329B RID: 209563 RVA: 0x006E5DFE File Offset: 0x006E3FFE
		public static void AddTextId(FlatBufferBuilder builder, int textId)
		{
			builder.AddInt(0, textId, 0);
		}

		// Token: 0x0603329C RID: 209564 RVA: 0x006E5E09 File Offset: 0x006E4009
		public static void AddTidCenterText(FlatBufferBuilder builder, StringOffset tidCenterTextOffset)
		{
			builder.AddOffset(1, tidCenterTextOffset.Value, 0);
		}

		// Token: 0x0603329D RID: 209565 RVA: 0x006E5E19 File Offset: 0x006E4019
		public static void AddPlotLineKey(FlatBufferBuilder builder, StringOffset plotLineKeyOffset)
		{
			builder.AddOffset(2, plotLineKeyOffset.Value, 0);
		}

		// Token: 0x0603329E RID: 209566 RVA: 0x006E5E29 File Offset: 0x006E4029
		public static void AddTotalTime(FlatBufferBuilder builder, float totalTime)
		{
			builder.AddFloat(3, totalTime, 0.0);
		}

		// Token: 0x0603329F RID: 209567 RVA: 0x006E5E3C File Offset: 0x006E403C
		public static void AddTextStyle(FlatBufferBuilder builder, Offset<ITextStyle> textStyleOffset)
		{
			builder.AddOffset(4, textStyleOffset.Value, 0);
		}

		// Token: 0x060332A0 RID: 209568 RVA: 0x006E5E4C File Offset: 0x006E404C
		public static void AddBgImageId(FlatBufferBuilder builder, StringOffset bgImageIdOffset)
		{
			builder.AddOffset(5, bgImageIdOffset.Value, 0);
		}

		// Token: 0x060332A1 RID: 209569 RVA: 0x006E5E5C File Offset: 0x006E405C
		public static void AddIsMulLine(FlatBufferBuilder builder, bool isMulLine)
		{
			builder.AddBool(6, isMulLine, false);
		}

		// Token: 0x060332A2 RID: 209570 RVA: 0x006E5E67 File Offset: 0x006E4067
		public static void AddIsManualNext(FlatBufferBuilder builder, bool isManualNext)
		{
			builder.AddBool(7, isManualNext, false);
		}

		// Token: 0x060332A3 RID: 209571 RVA: 0x006E5E72 File Offset: 0x006E4072
		public static void AddIsCancelAutoLine(FlatBufferBuilder builder, bool isCancelAutoLine)
		{
			builder.AddBool(8, isCancelAutoLine, false);
		}

		// Token: 0x060332A4 RID: 209572 RVA: 0x006E5E7D File Offset: 0x006E407D
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x060332A5 RID: 209573 RVA: 0x006E5E89 File Offset: 0x006E4089
		public static Offset<IShowCenterText> EndIShowCenterText(FlatBufferBuilder builder)
		{
			return new Offset<IShowCenterText>(builder.EndTable());
		}

		// Token: 0x060332A6 RID: 209574 RVA: 0x006E5E98 File Offset: 0x006E4098
		public IShowCenterTextT UnPack()
		{
			IShowCenterTextT showCenterTextT = new IShowCenterTextT();
			this.UnPackTo(showCenterTextT);
			return showCenterTextT;
		}

		// Token: 0x060332A7 RID: 209575 RVA: 0x006E5EB4 File Offset: 0x006E40B4
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

		// Token: 0x060332A8 RID: 209576 RVA: 0x006E5F5C File Offset: 0x006E415C
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

		// Token: 0x04011B40 RID: 72512
		private Table __p;
	}
}
