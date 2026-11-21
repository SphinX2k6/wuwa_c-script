using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078A5 RID: 30885
	public struct IShowCenterTextParams : IFlatbufferObject
	{
		// Token: 0x1700E27F RID: 57983
		// (get) Token: 0x06036561 RID: 222561 RVA: 0x00746813 File Offset: 0x00744A13
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036562 RID: 222562 RVA: 0x00746820 File Offset: 0x00744A20
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036563 RID: 222563 RVA: 0x00746828 File Offset: 0x00744A28
		public static IShowCenterTextParams GetRootAsIShowCenterTextParams(ByteBuffer _bb)
		{
			return IShowCenterTextParams.GetRootAsIShowCenterTextParams(_bb, default(IShowCenterTextParams));
		}

		// Token: 0x06036564 RID: 222564 RVA: 0x00746844 File Offset: 0x00744A44
		public static IShowCenterTextParams GetRootAsIShowCenterTextParams(ByteBuffer _bb, IShowCenterTextParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036565 RID: 222565 RVA: 0x00746861 File Offset: 0x00744A61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036566 RID: 222566 RVA: 0x00746870 File Offset: 0x00744A70
		public IShowCenterTextParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E280 RID: 57984
		// (get) Token: 0x06036567 RID: 222567 RVA: 0x00746880 File Offset: 0x00744A80
		public float TotalTime
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E281 RID: 57985
		// (get) Token: 0x06036568 RID: 222568 RVA: 0x007468C0 File Offset: 0x00744AC0
		public ITextStyle? TextStyle
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITextStyle?(default(ITextStyle).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E282 RID: 57986
		// (get) Token: 0x06036569 RID: 222569 RVA: 0x00746920 File Offset: 0x00744B20
		public string BgImageId
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

		// Token: 0x0603656A RID: 222570 RVA: 0x00746957 File Offset: 0x00744B57
		public Span<byte> GetBgImageIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0603656B RID: 222571 RVA: 0x00746966 File Offset: 0x00744B66
		public byte[] GetBgImageIdArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700E283 RID: 57987
		// (get) Token: 0x0603656C RID: 222572 RVA: 0x00746974 File Offset: 0x00744B74
		public bool IsMulLine
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E284 RID: 57988
		// (get) Token: 0x0603656D RID: 222573 RVA: 0x007469B4 File Offset: 0x00744BB4
		public bool IsManualNext
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E285 RID: 57989
		// (get) Token: 0x0603656E RID: 222574 RVA: 0x007469F4 File Offset: 0x00744BF4
		public bool IsCancelAutoLine
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E286 RID: 57990
		// (get) Token: 0x0603656F RID: 222575 RVA: 0x00746A34 File Offset: 0x00744C34
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036570 RID: 222576 RVA: 0x00746A74 File Offset: 0x00744C74
		public static Offset<IShowCenterTextParams> CreateIShowCenterTextParams(FlatBufferBuilder builder, float TotalTime = 0f, Offset<ITextStyle> TextStyleOffset = default(Offset<ITextStyle>), StringOffset BgImageIdOffset = default(StringOffset), bool IsMulLine = false, bool IsManualNext = false, bool IsCancelAutoLine = false, byte NullMask = 0)
		{
			builder.StartTable(7);
			IShowCenterTextParams.AddBgImageId(builder, BgImageIdOffset);
			IShowCenterTextParams.AddTextStyle(builder, TextStyleOffset);
			IShowCenterTextParams.AddTotalTime(builder, TotalTime);
			IShowCenterTextParams.AddNullMask(builder, NullMask);
			IShowCenterTextParams.AddIsCancelAutoLine(builder, IsCancelAutoLine);
			IShowCenterTextParams.AddIsManualNext(builder, IsManualNext);
			IShowCenterTextParams.AddIsMulLine(builder, IsMulLine);
			return IShowCenterTextParams.EndIShowCenterTextParams(builder);
		}

		// Token: 0x06036571 RID: 222577 RVA: 0x00746AC3 File Offset: 0x00744CC3
		public static void StartIShowCenterTextParams(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06036572 RID: 222578 RVA: 0x00746ACC File Offset: 0x00744CCC
		public static void AddTotalTime(FlatBufferBuilder builder, float totalTime)
		{
			builder.AddFloat(0, totalTime, 0.0);
		}

		// Token: 0x06036573 RID: 222579 RVA: 0x00746ADF File Offset: 0x00744CDF
		public static void AddTextStyle(FlatBufferBuilder builder, Offset<ITextStyle> textStyleOffset)
		{
			builder.AddOffset(1, textStyleOffset.Value, 0);
		}

		// Token: 0x06036574 RID: 222580 RVA: 0x00746AEF File Offset: 0x00744CEF
		public static void AddBgImageId(FlatBufferBuilder builder, StringOffset bgImageIdOffset)
		{
			builder.AddOffset(2, bgImageIdOffset.Value, 0);
		}

		// Token: 0x06036575 RID: 222581 RVA: 0x00746AFF File Offset: 0x00744CFF
		public static void AddIsMulLine(FlatBufferBuilder builder, bool isMulLine)
		{
			builder.AddBool(3, isMulLine, false);
		}

		// Token: 0x06036576 RID: 222582 RVA: 0x00746B0A File Offset: 0x00744D0A
		public static void AddIsManualNext(FlatBufferBuilder builder, bool isManualNext)
		{
			builder.AddBool(4, isManualNext, false);
		}

		// Token: 0x06036577 RID: 222583 RVA: 0x00746B15 File Offset: 0x00744D15
		public static void AddIsCancelAutoLine(FlatBufferBuilder builder, bool isCancelAutoLine)
		{
			builder.AddBool(5, isCancelAutoLine, false);
		}

		// Token: 0x06036578 RID: 222584 RVA: 0x00746B20 File Offset: 0x00744D20
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06036579 RID: 222585 RVA: 0x00746B2B File Offset: 0x00744D2B
		public static Offset<IShowCenterTextParams> EndIShowCenterTextParams(FlatBufferBuilder builder)
		{
			return new Offset<IShowCenterTextParams>(builder.EndTable());
		}

		// Token: 0x0603657A RID: 222586 RVA: 0x00746B38 File Offset: 0x00744D38
		public IShowCenterTextParamsT UnPack()
		{
			IShowCenterTextParamsT showCenterTextParamsT = new IShowCenterTextParamsT();
			this.UnPackTo(showCenterTextParamsT);
			return showCenterTextParamsT;
		}

		// Token: 0x0603657B RID: 222587 RVA: 0x00746B54 File Offset: 0x00744D54
		public void UnPackTo(IShowCenterTextParamsT _o)
		{
			_o.TotalTime = this.TotalTime;
			_o.TextStyle = ((this.TextStyle != null) ? this.TextStyle.Value.UnPack() : null);
			_o.BgImageId = this.BgImageId;
			_o.IsMulLine = this.IsMulLine;
			_o.IsManualNext = this.IsManualNext;
			_o.IsCancelAutoLine = this.IsCancelAutoLine;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603657C RID: 222588 RVA: 0x00746BD8 File Offset: 0x00744DD8
		public static Offset<IShowCenterTextParams> Pack(FlatBufferBuilder builder, IShowCenterTextParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowCenterTextParams>);
			}
			Offset<ITextStyle> textStyleOffset = (_o.TextStyle == null) ? default(Offset<ITextStyle>) : ITextStyle.Pack(builder, _o.TextStyle);
			StringOffset bgImageIdOffset = (_o.BgImageId == null) ? default(StringOffset) : builder.CreateString(_o.BgImageId);
			return IShowCenterTextParams.CreateIShowCenterTextParams(builder, _o.TotalTime, textStyleOffset, bgImageIdOffset, _o.IsMulLine, _o.IsManualNext, _o.IsCancelAutoLine, _o.NullMask);
		}

		// Token: 0x04012B39 RID: 76601
		private Table __p;
	}
}
