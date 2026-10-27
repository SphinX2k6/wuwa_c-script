using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200715A RID: 29018
	public struct ISlopeSlidePerformStart : IFlatbufferObject
	{
		// Token: 0x1700D7A3 RID: 55203
		// (get) Token: 0x06033734 RID: 210740 RVA: 0x006EEAD9 File Offset: 0x006ECCD9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033735 RID: 210741 RVA: 0x006EEAE6 File Offset: 0x006ECCE6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033736 RID: 210742 RVA: 0x006EEAF0 File Offset: 0x006ECCF0
		public static ISlopeSlidePerformStart GetRootAsISlopeSlidePerformStart(ByteBuffer _bb)
		{
			return ISlopeSlidePerformStart.GetRootAsISlopeSlidePerformStart(_bb, default(ISlopeSlidePerformStart));
		}

		// Token: 0x06033737 RID: 210743 RVA: 0x006EEB0C File Offset: 0x006ECD0C
		public static ISlopeSlidePerformStart GetRootAsISlopeSlidePerformStart(ByteBuffer _bb, ISlopeSlidePerformStart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033738 RID: 210744 RVA: 0x006EEB29 File Offset: 0x006ECD29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033739 RID: 210745 RVA: 0x006EEB38 File Offset: 0x006ECD38
		public ISlopeSlidePerformStart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7A4 RID: 55204
		// (get) Token: 0x0603373A RID: 210746 RVA: 0x006EEB48 File Offset: 0x006ECD48
		public ESlidePerformType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESlidePerformType.SlopeSlide;
				}
				return (ESlidePerformType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D7A5 RID: 55205
		// (get) Token: 0x0603373B RID: 210747 RVA: 0x006EEB84 File Offset: 0x006ECD84
		public string SlopeSlidePerformDaPath
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

		// Token: 0x0603373C RID: 210748 RVA: 0x006EEBBB File Offset: 0x006ECDBB
		public Span<byte> GetSlopeSlidePerformDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0603373D RID: 210749 RVA: 0x006EEBCA File Offset: 0x006ECDCA
		public byte[] GetSlopeSlidePerformDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0603373E RID: 210750 RVA: 0x006EEBD8 File Offset: 0x006ECDD8
		public static Offset<ISlopeSlidePerformStart> CreateISlopeSlidePerformStart(FlatBufferBuilder builder, ESlidePerformType Type = ESlidePerformType.SlopeSlide, StringOffset SlopeSlidePerformDaPathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISlopeSlidePerformStart.AddSlopeSlidePerformDaPath(builder, SlopeSlidePerformDaPathOffset);
			ISlopeSlidePerformStart.AddType(builder, Type);
			return ISlopeSlidePerformStart.EndISlopeSlidePerformStart(builder);
		}

		// Token: 0x0603373F RID: 210751 RVA: 0x006EEBF5 File Offset: 0x006ECDF5
		public static void StartISlopeSlidePerformStart(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033740 RID: 210752 RVA: 0x006EEBFE File Offset: 0x006ECDFE
		public static void AddType(FlatBufferBuilder builder, ESlidePerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033741 RID: 210753 RVA: 0x006EEC09 File Offset: 0x006ECE09
		public static void AddSlopeSlidePerformDaPath(FlatBufferBuilder builder, StringOffset slopeSlidePerformDaPathOffset)
		{
			builder.AddOffset(1, slopeSlidePerformDaPathOffset.Value, 0);
		}

		// Token: 0x06033742 RID: 210754 RVA: 0x006EEC19 File Offset: 0x006ECE19
		public static Offset<ISlopeSlidePerformStart> EndISlopeSlidePerformStart(FlatBufferBuilder builder)
		{
			return new Offset<ISlopeSlidePerformStart>(builder.EndTable());
		}

		// Token: 0x06033743 RID: 210755 RVA: 0x006EEC28 File Offset: 0x006ECE28
		public ISlopeSlidePerformStartT UnPack()
		{
			ISlopeSlidePerformStartT slopeSlidePerformStartT = new ISlopeSlidePerformStartT();
			this.UnPackTo(slopeSlidePerformStartT);
			return slopeSlidePerformStartT;
		}

		// Token: 0x06033744 RID: 210756 RVA: 0x006EEC43 File Offset: 0x006ECE43
		public void UnPackTo(ISlopeSlidePerformStartT _o)
		{
			_o.Type = this.Type;
			_o.SlopeSlidePerformDaPath = this.SlopeSlidePerformDaPath;
		}

		// Token: 0x06033745 RID: 210757 RVA: 0x006EEC60 File Offset: 0x006ECE60
		public static Offset<ISlopeSlidePerformStart> Pack(FlatBufferBuilder builder, ISlopeSlidePerformStartT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlopeSlidePerformStart>);
			}
			StringOffset slopeSlidePerformDaPathOffset = (_o.SlopeSlidePerformDaPath == null) ? default(StringOffset) : builder.CreateString(_o.SlopeSlidePerformDaPath);
			return ISlopeSlidePerformStart.CreateISlopeSlidePerformStart(builder, _o.Type, slopeSlidePerformDaPathOffset);
		}

		// Token: 0x04011C00 RID: 72704
		private Table __p;
	}
}
