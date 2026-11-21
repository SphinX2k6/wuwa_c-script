using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D5D RID: 3421
	public struct FishingBomb : IFlatbufferObject
	{
		// Token: 0x17001192 RID: 4498
		// (get) Token: 0x060074EB RID: 29931 RVA: 0x0024F0E1 File Offset: 0x0024D2E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060074EC RID: 29932 RVA: 0x0024F0EE File Offset: 0x0024D2EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060074ED RID: 29933 RVA: 0x0024F0F8 File Offset: 0x0024D2F8
		public static FishingBomb GetRootAsFishingBomb(ByteBuffer _bb)
		{
			return FishingBomb.GetRootAsFishingBomb(_bb, default(FishingBomb));
		}

		// Token: 0x060074EE RID: 29934 RVA: 0x0024F114 File Offset: 0x0024D314
		public static FishingBomb GetRootAsFishingBomb(ByteBuffer _bb, FishingBomb obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060074EF RID: 29935 RVA: 0x0024F131 File Offset: 0x0024D331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x0024F140 File Offset: 0x0024D340
		public FishingBomb __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001193 RID: 4499
		// (get) Token: 0x060074F1 RID: 29937 RVA: 0x0024F150 File Offset: 0x0024D350
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

		// Token: 0x17001194 RID: 4500
		// (get) Token: 0x060074F2 RID: 29938 RVA: 0x0024F18C File Offset: 0x0024D38C
		public int ItemId
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

		// Token: 0x17001195 RID: 4501
		// (get) Token: 0x060074F3 RID: 29939 RVA: 0x0024F1C8 File Offset: 0x0024D3C8
		public int ExploreToolId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040052A8 RID: 21160
		private Table __p;
	}
}
