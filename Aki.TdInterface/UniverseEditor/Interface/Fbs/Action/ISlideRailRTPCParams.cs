using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007151 RID: 29009
	public struct ISlideRailRTPCParams : IFlatbufferObject
	{
		// Token: 0x1700D782 RID: 55170
		// (get) Token: 0x060336CA RID: 210634 RVA: 0x006EDDE9 File Offset: 0x006EBFE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060336CB RID: 210635 RVA: 0x006EDDF6 File Offset: 0x006EBFF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060336CC RID: 210636 RVA: 0x006EDE00 File Offset: 0x006EC000
		public static ISlideRailRTPCParams GetRootAsISlideRailRTPCParams(ByteBuffer _bb)
		{
			return ISlideRailRTPCParams.GetRootAsISlideRailRTPCParams(_bb, default(ISlideRailRTPCParams));
		}

		// Token: 0x060336CD RID: 210637 RVA: 0x006EDE1C File Offset: 0x006EC01C
		public static ISlideRailRTPCParams GetRootAsISlideRailRTPCParams(ByteBuffer _bb, ISlideRailRTPCParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060336CE RID: 210638 RVA: 0x006EDE39 File Offset: 0x006EC039
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060336CF RID: 210639 RVA: 0x006EDE48 File Offset: 0x006EC048
		public ISlideRailRTPCParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D783 RID: 55171
		// (get) Token: 0x060336D0 RID: 210640 RVA: 0x006EDE58 File Offset: 0x006EC058
		public string RTPCName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060336D1 RID: 210641 RVA: 0x006EDE8F File Offset: 0x006EC08F
		public Span<byte> GetRTPCNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060336D2 RID: 210642 RVA: 0x006EDE9E File Offset: 0x006EC09E
		public byte[] GetRTPCNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x060336D3 RID: 210643 RVA: 0x006EDEAC File Offset: 0x006EC0AC
		public static Offset<ISlideRailRTPCParams> CreateISlideRailRTPCParams(FlatBufferBuilder builder, StringOffset RTPCNameOffset = default(StringOffset))
		{
			builder.StartTable(1);
			ISlideRailRTPCParams.AddRTPCName(builder, RTPCNameOffset);
			return ISlideRailRTPCParams.EndISlideRailRTPCParams(builder);
		}

		// Token: 0x060336D4 RID: 210644 RVA: 0x006EDEC2 File Offset: 0x006EC0C2
		public static void StartISlideRailRTPCParams(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060336D5 RID: 210645 RVA: 0x006EDECB File Offset: 0x006EC0CB
		public static void AddRTPCName(FlatBufferBuilder builder, StringOffset rTPCNameOffset)
		{
			builder.AddOffset(0, rTPCNameOffset.Value, 0);
		}

		// Token: 0x060336D6 RID: 210646 RVA: 0x006EDEDB File Offset: 0x006EC0DB
		public static Offset<ISlideRailRTPCParams> EndISlideRailRTPCParams(FlatBufferBuilder builder)
		{
			return new Offset<ISlideRailRTPCParams>(builder.EndTable());
		}

		// Token: 0x060336D7 RID: 210647 RVA: 0x006EDEE8 File Offset: 0x006EC0E8
		public ISlideRailRTPCParamsT UnPack()
		{
			ISlideRailRTPCParamsT slideRailRTPCParamsT = new ISlideRailRTPCParamsT();
			this.UnPackTo(slideRailRTPCParamsT);
			return slideRailRTPCParamsT;
		}

		// Token: 0x060336D8 RID: 210648 RVA: 0x006EDF03 File Offset: 0x006EC103
		public void UnPackTo(ISlideRailRTPCParamsT _o)
		{
			_o.RTPCName = this.RTPCName;
		}

		// Token: 0x060336D9 RID: 210649 RVA: 0x006EDF14 File Offset: 0x006EC114
		public static Offset<ISlideRailRTPCParams> Pack(FlatBufferBuilder builder, ISlideRailRTPCParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlideRailRTPCParams>);
			}
			StringOffset rtpcnameOffset = (_o.RTPCName == null) ? default(StringOffset) : builder.CreateString(_o.RTPCName);
			return ISlideRailRTPCParams.CreateISlideRailRTPCParams(builder, rtpcnameOffset);
		}

		// Token: 0x04011BEE RID: 72686
		private Table __p;
	}
}
