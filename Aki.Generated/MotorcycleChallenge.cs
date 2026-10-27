using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E30 RID: 3632
	public struct MotorcycleChallenge : IFlatbufferObject
	{
		// Token: 0x17002019 RID: 8217
		// (get) Token: 0x060096CC RID: 38604 RVA: 0x0028B2E3 File Offset: 0x002894E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060096CD RID: 38605 RVA: 0x0028B2F0 File Offset: 0x002894F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060096CE RID: 38606 RVA: 0x0028B2F8 File Offset: 0x002894F8
		public static MotorcycleChallenge GetRootAsMotorcycleChallenge(ByteBuffer _bb)
		{
			return MotorcycleChallenge.GetRootAsMotorcycleChallenge(_bb, default(MotorcycleChallenge));
		}

		// Token: 0x060096CF RID: 38607 RVA: 0x0028B314 File Offset: 0x00289514
		public static MotorcycleChallenge GetRootAsMotorcycleChallenge(ByteBuffer _bb, MotorcycleChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060096D0 RID: 38608 RVA: 0x0028B331 File Offset: 0x00289531
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060096D1 RID: 38609 RVA: 0x0028B340 File Offset: 0x00289540
		public MotorcycleChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700201A RID: 8218
		// (get) Token: 0x060096D2 RID: 38610 RVA: 0x0028B350 File Offset: 0x00289550
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

		// Token: 0x1700201B RID: 8219
		// (get) Token: 0x060096D3 RID: 38611 RVA: 0x0028B38C File Offset: 0x0028958C
		public int LevelPlayId
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

		// Token: 0x1700201C RID: 8220
		// (get) Token: 0x060096D4 RID: 38612 RVA: 0x0028B3C8 File Offset: 0x002895C8
		public string Name
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

		// Token: 0x060096D5 RID: 38613 RVA: 0x0028B3FF File Offset: 0x002895FF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060096D6 RID: 38614 RVA: 0x0028B40E File Offset: 0x0028960E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700201D RID: 8221
		// (get) Token: 0x060096D7 RID: 38615 RVA: 0x0028B428 File Offset: 0x00289628
		public int NeedScore
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

		// Token: 0x1700201E RID: 8222
		// (get) Token: 0x060096D8 RID: 38616 RVA: 0x0028B468 File Offset: 0x00289668
		public int Reward
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700201F RID: 8223
		// (get) Token: 0x060096D9 RID: 38617 RVA: 0x0028B4A8 File Offset: 0x002896A8
		public string ScoreText
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

		// Token: 0x060096DA RID: 38618 RVA: 0x0028B4E0 File Offset: 0x002896E0
		public Span<byte> GetScoreTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060096DB RID: 38619 RVA: 0x0028B4F0 File Offset: 0x002896F0
		public byte[] GetScoreTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002020 RID: 8224
		// (get) Token: 0x060096DC RID: 38620 RVA: 0x0028B508 File Offset: 0x00289708
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002021 RID: 8225
		// (get) Token: 0x060096DD RID: 38621 RVA: 0x0028B548 File Offset: 0x00289748
		public int UnlockTravelLevel
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

		// Token: 0x17002022 RID: 8226
		// (get) Token: 0x060096DE RID: 38622 RVA: 0x0028B588 File Offset: 0x00289788
		public int UnlockQuestId
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

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x060096DF RID: 38623 RVA: 0x0028B5C8 File Offset: 0x002897C8
		public string LockTips
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060096E0 RID: 38624 RVA: 0x0028B600 File Offset: 0x00289800
		public Span<byte> GetLockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x060096E1 RID: 38625 RVA: 0x0028B610 File Offset: 0x00289810
		public byte[] GetLockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x060096E2 RID: 38626 RVA: 0x0028B628 File Offset: 0x00289828
		public int ClassificationId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004ED5 RID: 20181
		private Table __p;
	}
}
