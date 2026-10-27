using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F99 RID: 3993
	public struct RealmBetweenChallenge : IFlatbufferObject
	{
		// Token: 0x17002D0D RID: 11533
		// (get) Token: 0x0600B932 RID: 47410 RVA: 0x002D7BF9 File Offset: 0x002D5DF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B933 RID: 47411 RVA: 0x002D7C06 File Offset: 0x002D5E06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B934 RID: 47412 RVA: 0x002D7C10 File Offset: 0x002D5E10
		public static RealmBetweenChallenge GetRootAsRealmBetweenChallenge(ByteBuffer _bb)
		{
			return RealmBetweenChallenge.GetRootAsRealmBetweenChallenge(_bb, default(RealmBetweenChallenge));
		}

		// Token: 0x0600B935 RID: 47413 RVA: 0x002D7C2C File Offset: 0x002D5E2C
		public static RealmBetweenChallenge GetRootAsRealmBetweenChallenge(ByteBuffer _bb, RealmBetweenChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B936 RID: 47414 RVA: 0x002D7C49 File Offset: 0x002D5E49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B937 RID: 47415 RVA: 0x002D7C58 File Offset: 0x002D5E58
		public RealmBetweenChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D0E RID: 11534
		// (get) Token: 0x0600B938 RID: 47416 RVA: 0x002D7C68 File Offset: 0x002D5E68
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

		// Token: 0x17002D0F RID: 11535
		// (get) Token: 0x0600B939 RID: 47417 RVA: 0x002D7CA4 File Offset: 0x002D5EA4
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

		// Token: 0x17002D10 RID: 11536
		// (get) Token: 0x0600B93A RID: 47418 RVA: 0x002D7CE0 File Offset: 0x002D5EE0
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

		// Token: 0x0600B93B RID: 47419 RVA: 0x002D7D17 File Offset: 0x002D5F17
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B93C RID: 47420 RVA: 0x002D7D26 File Offset: 0x002D5F26
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D11 RID: 11537
		// (get) Token: 0x0600B93D RID: 47421 RVA: 0x002D7D40 File Offset: 0x002D5F40
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

		// Token: 0x17002D12 RID: 11538
		// (get) Token: 0x0600B93E RID: 47422 RVA: 0x002D7D80 File Offset: 0x002D5F80
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

		// Token: 0x17002D13 RID: 11539
		// (get) Token: 0x0600B93F RID: 47423 RVA: 0x002D7DC0 File Offset: 0x002D5FC0
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

		// Token: 0x0600B940 RID: 47424 RVA: 0x002D7DF8 File Offset: 0x002D5FF8
		public Span<byte> GetScoreTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B941 RID: 47425 RVA: 0x002D7E08 File Offset: 0x002D6008
		public byte[] GetScoreTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D14 RID: 11540
		// (get) Token: 0x0600B942 RID: 47426 RVA: 0x002D7E20 File Offset: 0x002D6020
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

		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x0600B943 RID: 47427 RVA: 0x002D7E60 File Offset: 0x002D6060
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

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x0600B944 RID: 47428 RVA: 0x002D7EA0 File Offset: 0x002D60A0
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

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x0600B945 RID: 47429 RVA: 0x002D7EE0 File Offset: 0x002D60E0
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

		// Token: 0x0600B946 RID: 47430 RVA: 0x002D7F18 File Offset: 0x002D6118
		public Span<byte> GetLockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B947 RID: 47431 RVA: 0x002D7F28 File Offset: 0x002D6128
		public byte[] GetLockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D18 RID: 11544
		// (get) Token: 0x0600B948 RID: 47432 RVA: 0x002D7F40 File Offset: 0x002D6140
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

		// Token: 0x04005069 RID: 20585
		private Table __p;
	}
}
