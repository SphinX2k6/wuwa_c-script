using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D70 RID: 3440
	public struct FishingTag : IFlatbufferObject
	{
		// Token: 0x17001233 RID: 4659
		// (get) Token: 0x06007691 RID: 30353 RVA: 0x00253205 File Offset: 0x00251405
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007692 RID: 30354 RVA: 0x00253212 File Offset: 0x00251412
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007693 RID: 30355 RVA: 0x0025321C File Offset: 0x0025141C
		public static FishingTag GetRootAsFishingTag(ByteBuffer _bb)
		{
			return FishingTag.GetRootAsFishingTag(_bb, default(FishingTag));
		}

		// Token: 0x06007694 RID: 30356 RVA: 0x00253238 File Offset: 0x00251438
		public static FishingTag GetRootAsFishingTag(ByteBuffer _bb, FishingTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007695 RID: 30357 RVA: 0x00253255 File Offset: 0x00251455
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007696 RID: 30358 RVA: 0x00253264 File Offset: 0x00251464
		public FishingTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001234 RID: 4660
		// (get) Token: 0x06007697 RID: 30359 RVA: 0x00253274 File Offset: 0x00251474
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

		// Token: 0x17001235 RID: 4661
		// (get) Token: 0x06007698 RID: 30360 RVA: 0x002532B0 File Offset: 0x002514B0
		public string Name
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

		// Token: 0x06007699 RID: 30361 RVA: 0x002532E7 File Offset: 0x002514E7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600769A RID: 30362 RVA: 0x002532F6 File Offset: 0x002514F6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001236 RID: 4662
		// (get) Token: 0x0600769B RID: 30363 RVA: 0x00253310 File Offset: 0x00251510
		public string Color
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

		// Token: 0x0600769C RID: 30364 RVA: 0x00253347 File Offset: 0x00251547
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600769D RID: 30365 RVA: 0x00253356 File Offset: 0x00251556
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x040052C5 RID: 21189
		private Table __p;
	}
}
