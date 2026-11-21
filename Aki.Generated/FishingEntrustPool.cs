using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D61 RID: 3425
	public struct FishingEntrustPool : IFlatbufferObject
	{
		// Token: 0x170011B0 RID: 4528
		// (get) Token: 0x06007539 RID: 30009 RVA: 0x0024FEB8 File Offset: 0x0024E0B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600753A RID: 30010 RVA: 0x0024FEC5 File Offset: 0x0024E0C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600753B RID: 30011 RVA: 0x0024FECC File Offset: 0x0024E0CC
		public static FishingEntrustPool GetRootAsFishingEntrustPool(ByteBuffer _bb)
		{
			return FishingEntrustPool.GetRootAsFishingEntrustPool(_bb, default(FishingEntrustPool));
		}

		// Token: 0x0600753C RID: 30012 RVA: 0x0024FEE8 File Offset: 0x0024E0E8
		public static FishingEntrustPool GetRootAsFishingEntrustPool(ByteBuffer _bb, FishingEntrustPool obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600753D RID: 30013 RVA: 0x0024FF05 File Offset: 0x0024E105
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600753E RID: 30014 RVA: 0x0024FF14 File Offset: 0x0024E114
		public FishingEntrustPool __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011B1 RID: 4529
		// (get) Token: 0x0600753F RID: 30015 RVA: 0x0024FF24 File Offset: 0x0024E124
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

		// Token: 0x170011B2 RID: 4530
		// (get) Token: 0x06007540 RID: 30016 RVA: 0x0024FF60 File Offset: 0x0024E160
		public int Priority
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

		// Token: 0x170011B3 RID: 4531
		// (get) Token: 0x06007541 RID: 30017 RVA: 0x0024FF9C File Offset: 0x0024E19C
		public int NumLimit
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

		// Token: 0x170011B4 RID: 4532
		// (get) Token: 0x06007542 RID: 30018 RVA: 0x0024FFD8 File Offset: 0x0024E1D8
		public int TotalCount
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170011B5 RID: 4533
		// (get) Token: 0x06007543 RID: 30019 RVA: 0x00250018 File Offset: 0x0024E218
		public string TitleName
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

		// Token: 0x06007544 RID: 30020 RVA: 0x00250050 File Offset: 0x0024E250
		public Span<byte> GetTitleNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007545 RID: 30021 RVA: 0x00250060 File Offset: 0x0024E260
		public byte[] GetTitleNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170011B6 RID: 4534
		// (get) Token: 0x06007546 RID: 30022 RVA: 0x00250078 File Offset: 0x0024E278
		public string TitleSprite
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

		// Token: 0x06007547 RID: 30023 RVA: 0x002500B0 File Offset: 0x0024E2B0
		public Span<byte> GetTitleSpriteBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007548 RID: 30024 RVA: 0x002500C0 File Offset: 0x0024E2C0
		public byte[] GetTitleSpriteArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x040052B0 RID: 21168
		private Table __p;
	}
}
