using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E78 RID: 3704
	public struct MusicalInstrumentQteConfig : IFlatbufferObject
	{
		// Token: 0x170022BD RID: 8893
		// (get) Token: 0x06009DB9 RID: 40377 RVA: 0x0029ABF1 File Offset: 0x00298DF1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009DBA RID: 40378 RVA: 0x0029ABFE File Offset: 0x00298DFE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009DBB RID: 40379 RVA: 0x0029AC08 File Offset: 0x00298E08
		public static MusicalInstrumentQteConfig GetRootAsMusicalInstrumentQteConfig(ByteBuffer _bb)
		{
			return MusicalInstrumentQteConfig.GetRootAsMusicalInstrumentQteConfig(_bb, default(MusicalInstrumentQteConfig));
		}

		// Token: 0x06009DBC RID: 40380 RVA: 0x0029AC24 File Offset: 0x00298E24
		public static MusicalInstrumentQteConfig GetRootAsMusicalInstrumentQteConfig(ByteBuffer _bb, MusicalInstrumentQteConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009DBD RID: 40381 RVA: 0x0029AC41 File Offset: 0x00298E41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009DBE RID: 40382 RVA: 0x0029AC50 File Offset: 0x00298E50
		public MusicalInstrumentQteConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022BE RID: 8894
		// (get) Token: 0x06009DBF RID: 40383 RVA: 0x0029AC60 File Offset: 0x00298E60
		public int Id
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

		// Token: 0x170022BF RID: 8895
		// (get) Token: 0x06009DC0 RID: 40384 RVA: 0x0029AC9C File Offset: 0x00298E9C
		public int InstrumentType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170022C0 RID: 8896
		// (get) Token: 0x06009DC1 RID: 40385 RVA: 0x0029ACD8 File Offset: 0x00298ED8
		public string Description
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

		// Token: 0x06009DC2 RID: 40386 RVA: 0x0029AD0F File Offset: 0x00298F0F
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009DC3 RID: 40387 RVA: 0x0029AD1E File Offset: 0x00298F1E
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170022C1 RID: 8897
		// (get) Token: 0x06009DC4 RID: 40388 RVA: 0x0029AD38 File Offset: 0x00298F38
		public string QteSequence
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009DC5 RID: 40389 RVA: 0x0029AD70 File Offset: 0x00298F70
		public Span<byte> GetQteSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009DC6 RID: 40390 RVA: 0x0029AD80 File Offset: 0x00298F80
		public byte[] GetQteSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170022C2 RID: 8898
		// (get) Token: 0x06009DC7 RID: 40391 RVA: 0x0029AD98 File Offset: 0x00298F98
		public string PreludeAsset
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009DC8 RID: 40392 RVA: 0x0029ADD0 File Offset: 0x00298FD0
		public Span<byte> GetPreludeAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06009DC9 RID: 40393 RVA: 0x0029ADE0 File Offset: 0x00298FE0
		public byte[] GetPreludeAssetArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F26 RID: 20262
		private Table __p;
	}
}
