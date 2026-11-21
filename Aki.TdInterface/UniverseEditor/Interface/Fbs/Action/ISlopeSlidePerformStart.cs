using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007926 RID: 31014
	public struct ISlopeSlidePerformStart : IFlatbufferObject
	{
		// Token: 0x1700E388 RID: 58248
		// (get) Token: 0x060369DE RID: 223710 RVA: 0x0074F2E5 File Offset: 0x0074D4E5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060369DF RID: 223711 RVA: 0x0074F2F2 File Offset: 0x0074D4F2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060369E0 RID: 223712 RVA: 0x0074F2FC File Offset: 0x0074D4FC
		public static ISlopeSlidePerformStart GetRootAsISlopeSlidePerformStart(ByteBuffer _bb)
		{
			return ISlopeSlidePerformStart.GetRootAsISlopeSlidePerformStart(_bb, default(ISlopeSlidePerformStart));
		}

		// Token: 0x060369E1 RID: 223713 RVA: 0x0074F318 File Offset: 0x0074D518
		public static ISlopeSlidePerformStart GetRootAsISlopeSlidePerformStart(ByteBuffer _bb, ISlopeSlidePerformStart obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060369E2 RID: 223714 RVA: 0x0074F335 File Offset: 0x0074D535
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060369E3 RID: 223715 RVA: 0x0074F344 File Offset: 0x0074D544
		public ISlopeSlidePerformStart __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E389 RID: 58249
		// (get) Token: 0x060369E4 RID: 223716 RVA: 0x0074F354 File Offset: 0x0074D554
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

		// Token: 0x1700E38A RID: 58250
		// (get) Token: 0x060369E5 RID: 223717 RVA: 0x0074F390 File Offset: 0x0074D590
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

		// Token: 0x060369E6 RID: 223718 RVA: 0x0074F3C7 File Offset: 0x0074D5C7
		public Span<byte> GetSlopeSlidePerformDaPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060369E7 RID: 223719 RVA: 0x0074F3D6 File Offset: 0x0074D5D6
		public byte[] GetSlopeSlidePerformDaPathArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x060369E8 RID: 223720 RVA: 0x0074F3E4 File Offset: 0x0074D5E4
		public static Offset<ISlopeSlidePerformStart> CreateISlopeSlidePerformStart(FlatBufferBuilder builder, ESlidePerformType Type = ESlidePerformType.SlopeSlide, StringOffset SlopeSlidePerformDaPathOffset = default(StringOffset))
		{
			builder.StartTable(2);
			ISlopeSlidePerformStart.AddSlopeSlidePerformDaPath(builder, SlopeSlidePerformDaPathOffset);
			ISlopeSlidePerformStart.AddType(builder, Type);
			return ISlopeSlidePerformStart.EndISlopeSlidePerformStart(builder);
		}

		// Token: 0x060369E9 RID: 223721 RVA: 0x0074F401 File Offset: 0x0074D601
		public static void StartISlopeSlidePerformStart(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060369EA RID: 223722 RVA: 0x0074F40A File Offset: 0x0074D60A
		public static void AddType(FlatBufferBuilder builder, ESlidePerformType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060369EB RID: 223723 RVA: 0x0074F415 File Offset: 0x0074D615
		public static void AddSlopeSlidePerformDaPath(FlatBufferBuilder builder, StringOffset slopeSlidePerformDaPathOffset)
		{
			builder.AddOffset(1, slopeSlidePerformDaPathOffset.Value, 0);
		}

		// Token: 0x060369EC RID: 223724 RVA: 0x0074F425 File Offset: 0x0074D625
		public static Offset<ISlopeSlidePerformStart> EndISlopeSlidePerformStart(FlatBufferBuilder builder)
		{
			return new Offset<ISlopeSlidePerformStart>(builder.EndTable());
		}

		// Token: 0x060369ED RID: 223725 RVA: 0x0074F434 File Offset: 0x0074D634
		public ISlopeSlidePerformStartT UnPack()
		{
			ISlopeSlidePerformStartT slopeSlidePerformStartT = new ISlopeSlidePerformStartT();
			this.UnPackTo(slopeSlidePerformStartT);
			return slopeSlidePerformStartT;
		}

		// Token: 0x060369EE RID: 223726 RVA: 0x0074F44F File Offset: 0x0074D64F
		public void UnPackTo(ISlopeSlidePerformStartT _o)
		{
			_o.Type = this.Type;
			_o.SlopeSlidePerformDaPath = this.SlopeSlidePerformDaPath;
		}

		// Token: 0x060369EF RID: 223727 RVA: 0x0074F46C File Offset: 0x0074D66C
		public static Offset<ISlopeSlidePerformStart> Pack(FlatBufferBuilder builder, ISlopeSlidePerformStartT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISlopeSlidePerformStart>);
			}
			StringOffset slopeSlidePerformDaPathOffset = (_o.SlopeSlidePerformDaPath == null) ? default(StringOffset) : builder.CreateString(_o.SlopeSlidePerformDaPath);
			return ISlopeSlidePerformStart.CreateISlopeSlidePerformStart(builder, _o.Type, slopeSlidePerformDaPathOffset);
		}

		// Token: 0x04012BEF RID: 76783
		private Table __p;
	}
}
