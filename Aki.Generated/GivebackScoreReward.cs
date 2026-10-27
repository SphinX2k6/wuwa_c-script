using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D02 RID: 3330
	public struct GivebackScoreReward : IFlatbufferObject
	{
		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06007AE0 RID: 31456 RVA: 0x0024C1E8 File Offset: 0x0024A3E8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007AE1 RID: 31457 RVA: 0x0024C1F5 File Offset: 0x0024A3F5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007AE2 RID: 31458 RVA: 0x0024C1FC File Offset: 0x0024A3FC
		public static GivebackScoreReward GetRootAsGivebackScoreReward(ByteBuffer _bb)
		{
			return GivebackScoreReward.GetRootAsGivebackScoreReward(_bb, default(GivebackScoreReward));
		}

		// Token: 0x06007AE3 RID: 31459 RVA: 0x0024C218 File Offset: 0x0024A418
		public static GivebackScoreReward GetRootAsGivebackScoreReward(ByteBuffer _bb, GivebackScoreReward obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007AE4 RID: 31460 RVA: 0x0024C235 File Offset: 0x0024A435
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007AE5 RID: 31461 RVA: 0x0024C244 File Offset: 0x0024A444
		public GivebackScoreReward __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06007AE6 RID: 31462 RVA: 0x0024C254 File Offset: 0x0024A454
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

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06007AE7 RID: 31463 RVA: 0x0024C290 File Offset: 0x0024A490
		public int Target
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

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06007AE8 RID: 31464 RVA: 0x0024C2CC File Offset: 0x0024A4CC
		public int DropId
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

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06007AE9 RID: 31465 RVA: 0x0024C308 File Offset: 0x0024A508
		public string Name
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

		// Token: 0x06007AEA RID: 31466 RVA: 0x0024C340 File Offset: 0x0024A540
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007AEB RID: 31467 RVA: 0x0024C350 File Offset: 0x0024A550
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x06007AEC RID: 31468 RVA: 0x0024C368 File Offset: 0x0024A568
		public string DesText
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

		// Token: 0x06007AED RID: 31469 RVA: 0x0024C3A0 File Offset: 0x0024A5A0
		public Span<byte> GetDesTextBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007AEE RID: 31470 RVA: 0x0024C3B0 File Offset: 0x0024A5B0
		public byte[] GetDesTextArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x06007AEF RID: 31471 RVA: 0x0024C3C8 File Offset: 0x0024A5C8
		public int ShowType
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x06007AF0 RID: 31472 RVA: 0x0024C408 File Offset: 0x0024A608
		public string IconLarge
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007AF1 RID: 31473 RVA: 0x0024C440 File Offset: 0x0024A640
		public Span<byte> GetIconLargeBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007AF2 RID: 31474 RVA: 0x0024C450 File Offset: 0x0024A650
		public byte[] GetIconLargeArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170015C3 RID: 5571
		// (get) Token: 0x06007AF3 RID: 31475 RVA: 0x0024C468 File Offset: 0x0024A668
		public int PlayerTitleId
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170015C4 RID: 5572
		// (get) Token: 0x06007AF4 RID: 31476 RVA: 0x0024C4A8 File Offset: 0x0024A6A8
		public int SkipParam
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004D78 RID: 19832
		private Table __p;
	}
}
