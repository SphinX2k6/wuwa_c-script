using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F3C RID: 3900
	public struct MotorGiftQuality : IFlatbufferObject
	{
		// Token: 0x170021ED RID: 8685
		// (get) Token: 0x0600A077 RID: 41079 RVA: 0x002B0F3E File Offset: 0x002AF13E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A078 RID: 41080 RVA: 0x002B0F4B File Offset: 0x002AF14B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A079 RID: 41081 RVA: 0x002B0F54 File Offset: 0x002AF154
		public static MotorGiftQuality GetRootAsMotorGiftQuality(ByteBuffer _bb)
		{
			return MotorGiftQuality.GetRootAsMotorGiftQuality(_bb, default(MotorGiftQuality));
		}

		// Token: 0x0600A07A RID: 41082 RVA: 0x002B0F70 File Offset: 0x002AF170
		public static MotorGiftQuality GetRootAsMotorGiftQuality(ByteBuffer _bb, MotorGiftQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A07B RID: 41083 RVA: 0x002B0F8D File Offset: 0x002AF18D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A07C RID: 41084 RVA: 0x002B0F9C File Offset: 0x002AF19C
		public MotorGiftQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170021EE RID: 8686
		// (get) Token: 0x0600A07D RID: 41085 RVA: 0x002B0FAC File Offset: 0x002AF1AC
		public int QualityId
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

		// Token: 0x170021EF RID: 8687
		// (get) Token: 0x0600A07E RID: 41086 RVA: 0x002B0FE8 File Offset: 0x002AF1E8
		public string Path
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

		// Token: 0x0600A07F RID: 41087 RVA: 0x002B101F File Offset: 0x002AF21F
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A080 RID: 41088 RVA: 0x002B102E File Offset: 0x002AF22E
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170021F0 RID: 8688
		// (get) Token: 0x0600A081 RID: 41089 RVA: 0x002B1048 File Offset: 0x002AF248
		public string BgA
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

		// Token: 0x0600A082 RID: 41090 RVA: 0x002B107F File Offset: 0x002AF27F
		public Span<byte> GetBgABytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A083 RID: 41091 RVA: 0x002B108E File Offset: 0x002AF28E
		public byte[] GetBgAArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170021F1 RID: 8689
		// (get) Token: 0x0600A084 RID: 41092 RVA: 0x002B10A8 File Offset: 0x002AF2A8
		public string BgType
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

		// Token: 0x0600A085 RID: 41093 RVA: 0x002B10E0 File Offset: 0x002AF2E0
		public Span<byte> GetBgTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A086 RID: 41094 RVA: 0x002B10F0 File Offset: 0x002AF2F0
		public byte[] GetBgTypeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170021F2 RID: 8690
		// (get) Token: 0x0600A087 RID: 41095 RVA: 0x002B1108 File Offset: 0x002AF308
		public string BgC
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

		// Token: 0x0600A088 RID: 41096 RVA: 0x002B1140 File Offset: 0x002AF340
		public Span<byte> GetBgCBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600A089 RID: 41097 RVA: 0x002B1150 File Offset: 0x002AF350
		public byte[] GetBgCArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170021F3 RID: 8691
		// (get) Token: 0x0600A08A RID: 41098 RVA: 0x002B1168 File Offset: 0x002AF368
		public string BgBar
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

		// Token: 0x0600A08B RID: 41099 RVA: 0x002B11A0 File Offset: 0x002AF3A0
		public Span<byte> GetBgBarBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A08C RID: 41100 RVA: 0x002B11B0 File Offset: 0x002AF3B0
		public byte[] GetBgBarArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040054E5 RID: 21733
		private Table __p;
	}
}
