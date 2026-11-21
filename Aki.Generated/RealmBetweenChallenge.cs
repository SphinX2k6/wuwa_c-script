using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001080 RID: 4224
	public struct RealmBetweenChallenge : IFlatbufferObject
	{
		// Token: 0x17002D85 RID: 11653
		// (get) Token: 0x0600BF6F RID: 49007 RVA: 0x002F4411 File Offset: 0x002F2611
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BF70 RID: 49008 RVA: 0x002F441E File Offset: 0x002F261E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF71 RID: 49009 RVA: 0x002F4428 File Offset: 0x002F2628
		public static RealmBetweenChallenge GetRootAsRealmBetweenChallenge(ByteBuffer _bb)
		{
			return RealmBetweenChallenge.GetRootAsRealmBetweenChallenge(_bb, default(RealmBetweenChallenge));
		}

		// Token: 0x0600BF72 RID: 49010 RVA: 0x002F4444 File Offset: 0x002F2644
		public static RealmBetweenChallenge GetRootAsRealmBetweenChallenge(ByteBuffer _bb, RealmBetweenChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF73 RID: 49011 RVA: 0x002F4461 File Offset: 0x002F2661
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF74 RID: 49012 RVA: 0x002F4470 File Offset: 0x002F2670
		public RealmBetweenChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D86 RID: 11654
		// (get) Token: 0x0600BF75 RID: 49013 RVA: 0x002F4480 File Offset: 0x002F2680
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

		// Token: 0x17002D87 RID: 11655
		// (get) Token: 0x0600BF76 RID: 49014 RVA: 0x002F44BC File Offset: 0x002F26BC
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

		// Token: 0x17002D88 RID: 11656
		// (get) Token: 0x0600BF77 RID: 49015 RVA: 0x002F44F8 File Offset: 0x002F26F8
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

		// Token: 0x0600BF78 RID: 49016 RVA: 0x002F452F File Offset: 0x002F272F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BF79 RID: 49017 RVA: 0x002F453E File Offset: 0x002F273E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D89 RID: 11657
		// (get) Token: 0x0600BF7A RID: 49018 RVA: 0x002F4558 File Offset: 0x002F2758
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

		// Token: 0x17002D8A RID: 11658
		// (get) Token: 0x0600BF7B RID: 49019 RVA: 0x002F4598 File Offset: 0x002F2798
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

		// Token: 0x17002D8B RID: 11659
		// (get) Token: 0x0600BF7C RID: 49020 RVA: 0x002F45D8 File Offset: 0x002F27D8
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

		// Token: 0x0600BF7D RID: 49021 RVA: 0x002F4610 File Offset: 0x002F2810
		public Span<byte> GetScoreTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600BF7E RID: 49022 RVA: 0x002F4620 File Offset: 0x002F2820
		public byte[] GetScoreTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D8C RID: 11660
		// (get) Token: 0x0600BF7F RID: 49023 RVA: 0x002F4638 File Offset: 0x002F2838
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

		// Token: 0x17002D8D RID: 11661
		// (get) Token: 0x0600BF80 RID: 49024 RVA: 0x002F4678 File Offset: 0x002F2878
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

		// Token: 0x17002D8E RID: 11662
		// (get) Token: 0x0600BF81 RID: 49025 RVA: 0x002F46B8 File Offset: 0x002F28B8
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

		// Token: 0x17002D8F RID: 11663
		// (get) Token: 0x0600BF82 RID: 49026 RVA: 0x002F46F8 File Offset: 0x002F28F8
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

		// Token: 0x0600BF83 RID: 49027 RVA: 0x002F4730 File Offset: 0x002F2930
		public Span<byte> GetLockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600BF84 RID: 49028 RVA: 0x002F4740 File Offset: 0x002F2940
		public byte[] GetLockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D90 RID: 11664
		// (get) Token: 0x0600BF85 RID: 49029 RVA: 0x002F4758 File Offset: 0x002F2958
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

		// Token: 0x04005650 RID: 22096
		private Table __p;
	}
}
