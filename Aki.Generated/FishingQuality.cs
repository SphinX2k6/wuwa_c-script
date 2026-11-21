using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D6D RID: 3437
	public struct FishingQuality : IFlatbufferObject
	{
		// Token: 0x1700121E RID: 4638
		// (get) Token: 0x06007657 RID: 30295 RVA: 0x00252AF4 File Offset: 0x00250CF4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007658 RID: 30296 RVA: 0x00252B01 File Offset: 0x00250D01
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007659 RID: 30297 RVA: 0x00252B08 File Offset: 0x00250D08
		public static FishingQuality GetRootAsFishingQuality(ByteBuffer _bb)
		{
			return FishingQuality.GetRootAsFishingQuality(_bb, default(FishingQuality));
		}

		// Token: 0x0600765A RID: 30298 RVA: 0x00252B24 File Offset: 0x00250D24
		public static FishingQuality GetRootAsFishingQuality(ByteBuffer _bb, FishingQuality obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600765B RID: 30299 RVA: 0x00252B41 File Offset: 0x00250D41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600765C RID: 30300 RVA: 0x00252B50 File Offset: 0x00250D50
		public FishingQuality __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700121F RID: 4639
		// (get) Token: 0x0600765D RID: 30301 RVA: 0x00252B60 File Offset: 0x00250D60
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

		// Token: 0x17001220 RID: 4640
		// (get) Token: 0x0600765E RID: 30302 RVA: 0x00252B9C File Offset: 0x00250D9C
		public string TxtColor
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

		// Token: 0x0600765F RID: 30303 RVA: 0x00252BD3 File Offset: 0x00250DD3
		public Span<byte> GetTxtColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007660 RID: 30304 RVA: 0x00252BE2 File Offset: 0x00250DE2
		public byte[] GetTxtColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001221 RID: 4641
		// (get) Token: 0x06007661 RID: 30305 RVA: 0x00252BFC File Offset: 0x00250DFC
		public string TexBg
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

		// Token: 0x06007662 RID: 30306 RVA: 0x00252C33 File Offset: 0x00250E33
		public Span<byte> GetTexBgBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007663 RID: 30307 RVA: 0x00252C42 File Offset: 0x00250E42
		public byte[] GetTexBgArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001222 RID: 4642
		// (get) Token: 0x06007664 RID: 30308 RVA: 0x00252C5C File Offset: 0x00250E5C
		public string GridColor
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

		// Token: 0x06007665 RID: 30309 RVA: 0x00252C94 File Offset: 0x00250E94
		public Span<byte> GetGridColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007666 RID: 30310 RVA: 0x00252CA4 File Offset: 0x00250EA4
		public byte[] GetGridColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001223 RID: 4643
		// (get) Token: 0x06007667 RID: 30311 RVA: 0x00252CBC File Offset: 0x00250EBC
		public string GridSprite
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

		// Token: 0x06007668 RID: 30312 RVA: 0x00252CF4 File Offset: 0x00250EF4
		public Span<byte> GetGridSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007669 RID: 30313 RVA: 0x00252D04 File Offset: 0x00250F04
		public byte[] GetGridSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040052C2 RID: 21186
		private Table __p;
	}
}
