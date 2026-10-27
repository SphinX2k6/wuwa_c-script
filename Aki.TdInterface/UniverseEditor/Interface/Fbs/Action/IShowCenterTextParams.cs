using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D9 RID: 28889
	public struct IShowCenterTextParams : IFlatbufferObject
	{
		// Token: 0x1700D69C RID: 54940
		// (get) Token: 0x060332BF RID: 209599 RVA: 0x006E6207 File Offset: 0x006E4407
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060332C0 RID: 209600 RVA: 0x006E6214 File Offset: 0x006E4414
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060332C1 RID: 209601 RVA: 0x006E621C File Offset: 0x006E441C
		public static IShowCenterTextParams GetRootAsIShowCenterTextParams(ByteBuffer _bb)
		{
			return IShowCenterTextParams.GetRootAsIShowCenterTextParams(_bb, default(IShowCenterTextParams));
		}

		// Token: 0x060332C2 RID: 209602 RVA: 0x006E6238 File Offset: 0x006E4438
		public static IShowCenterTextParams GetRootAsIShowCenterTextParams(ByteBuffer _bb, IShowCenterTextParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060332C3 RID: 209603 RVA: 0x006E6255 File Offset: 0x006E4455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060332C4 RID: 209604 RVA: 0x006E6264 File Offset: 0x006E4464
		public IShowCenterTextParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D69D RID: 54941
		// (get) Token: 0x060332C5 RID: 209605 RVA: 0x006E6274 File Offset: 0x006E4474
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

		// Token: 0x1700D69E RID: 54942
		// (get) Token: 0x060332C6 RID: 209606 RVA: 0x006E62B4 File Offset: 0x006E44B4
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

		// Token: 0x1700D69F RID: 54943
		// (get) Token: 0x060332C7 RID: 209607 RVA: 0x006E6314 File Offset: 0x006E4514
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

		// Token: 0x060332C8 RID: 209608 RVA: 0x006E634B File Offset: 0x006E454B
		public Span<byte> GetBgImageIdBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060332C9 RID: 209609 RVA: 0x006E635A File Offset: 0x006E455A
		public byte[] GetBgImageIdArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700D6A0 RID: 54944
		// (get) Token: 0x060332CA RID: 209610 RVA: 0x006E6368 File Offset: 0x006E4568
		public bool IsMulLine
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D6A1 RID: 54945
		// (get) Token: 0x060332CB RID: 209611 RVA: 0x006E63A8 File Offset: 0x006E45A8
		public bool IsManualNext
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D6A2 RID: 54946
		// (get) Token: 0x060332CC RID: 209612 RVA: 0x006E63E8 File Offset: 0x006E45E8
		public bool IsCancelAutoLine
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700D6A3 RID: 54947
		// (get) Token: 0x060332CD RID: 209613 RVA: 0x006E6428 File Offset: 0x006E4628
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

		// Token: 0x060332CE RID: 209614 RVA: 0x006E6468 File Offset: 0x006E4668
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

		// Token: 0x060332CF RID: 209615 RVA: 0x006E64B7 File Offset: 0x006E46B7
		public static void StartIShowCenterTextParams(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060332D0 RID: 209616 RVA: 0x006E64C0 File Offset: 0x006E46C0
		public static void AddTotalTime(FlatBufferBuilder builder, float totalTime)
		{
			builder.AddFloat(0, totalTime, 0.0);
		}

		// Token: 0x060332D1 RID: 209617 RVA: 0x006E64D3 File Offset: 0x006E46D3
		public static void AddTextStyle(FlatBufferBuilder builder, Offset<ITextStyle> textStyleOffset)
		{
			builder.AddOffset(1, textStyleOffset.Value, 0);
		}

		// Token: 0x060332D2 RID: 209618 RVA: 0x006E64E3 File Offset: 0x006E46E3
		public static void AddBgImageId(FlatBufferBuilder builder, StringOffset bgImageIdOffset)
		{
			builder.AddOffset(2, bgImageIdOffset.Value, 0);
		}

		// Token: 0x060332D3 RID: 209619 RVA: 0x006E64F3 File Offset: 0x006E46F3
		public static void AddIsMulLine(FlatBufferBuilder builder, bool isMulLine)
		{
			builder.AddBool(3, isMulLine, false);
		}

		// Token: 0x060332D4 RID: 209620 RVA: 0x006E64FE File Offset: 0x006E46FE
		public static void AddIsManualNext(FlatBufferBuilder builder, bool isManualNext)
		{
			builder.AddBool(4, isManualNext, false);
		}

		// Token: 0x060332D5 RID: 209621 RVA: 0x006E6509 File Offset: 0x006E4709
		public static void AddIsCancelAutoLine(FlatBufferBuilder builder, bool isCancelAutoLine)
		{
			builder.AddBool(5, isCancelAutoLine, false);
		}

		// Token: 0x060332D6 RID: 209622 RVA: 0x006E6514 File Offset: 0x006E4714
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060332D7 RID: 209623 RVA: 0x006E651F File Offset: 0x006E471F
		public static Offset<IShowCenterTextParams> EndIShowCenterTextParams(FlatBufferBuilder builder)
		{
			return new Offset<IShowCenterTextParams>(builder.EndTable());
		}

		// Token: 0x060332D8 RID: 209624 RVA: 0x006E652C File Offset: 0x006E472C
		public IShowCenterTextParamsT UnPack()
		{
			IShowCenterTextParamsT showCenterTextParamsT = new IShowCenterTextParamsT();
			this.UnPackTo(showCenterTextParamsT);
			return showCenterTextParamsT;
		}

		// Token: 0x060332D9 RID: 209625 RVA: 0x006E6548 File Offset: 0x006E4748
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

		// Token: 0x060332DA RID: 209626 RVA: 0x006E65CC File Offset: 0x006E47CC
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

		// Token: 0x04011B4B RID: 72523
		private Table __p;
	}
}
