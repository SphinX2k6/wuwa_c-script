using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011D0 RID: 4560
	public struct SoarChallenge : IFlatbufferObject
	{
		// Token: 0x17003892 RID: 14482
		// (get) Token: 0x0600DEF7 RID: 57079 RVA: 0x0033B358 File Offset: 0x00339558
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DEF8 RID: 57080 RVA: 0x0033B365 File Offset: 0x00339565
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DEF9 RID: 57081 RVA: 0x0033B36C File Offset: 0x0033956C
		public static SoarChallenge GetRootAsSoarChallenge(ByteBuffer _bb)
		{
			return SoarChallenge.GetRootAsSoarChallenge(_bb, default(SoarChallenge));
		}

		// Token: 0x0600DEFA RID: 57082 RVA: 0x0033B388 File Offset: 0x00339588
		public static SoarChallenge GetRootAsSoarChallenge(ByteBuffer _bb, SoarChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DEFB RID: 57083 RVA: 0x0033B3A5 File Offset: 0x003395A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DEFC RID: 57084 RVA: 0x0033B3B4 File Offset: 0x003395B4
		public SoarChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003893 RID: 14483
		// (get) Token: 0x0600DEFD RID: 57085 RVA: 0x0033B3C4 File Offset: 0x003395C4
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

		// Token: 0x17003894 RID: 14484
		// (get) Token: 0x0600DEFE RID: 57086 RVA: 0x0033B400 File Offset: 0x00339600
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

		// Token: 0x17003895 RID: 14485
		// (get) Token: 0x0600DEFF RID: 57087 RVA: 0x0033B43C File Offset: 0x0033963C
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

		// Token: 0x0600DF00 RID: 57088 RVA: 0x0033B473 File Offset: 0x00339673
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DF01 RID: 57089 RVA: 0x0033B482 File Offset: 0x00339682
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003896 RID: 14486
		// (get) Token: 0x0600DF02 RID: 57090 RVA: 0x0033B49C File Offset: 0x0033969C
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

		// Token: 0x17003897 RID: 14487
		// (get) Token: 0x0600DF03 RID: 57091 RVA: 0x0033B4DC File Offset: 0x003396DC
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

		// Token: 0x17003898 RID: 14488
		// (get) Token: 0x0600DF04 RID: 57092 RVA: 0x0033B51C File Offset: 0x0033971C
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

		// Token: 0x0600DF05 RID: 57093 RVA: 0x0033B554 File Offset: 0x00339754
		public Span<byte> GetScoreTextBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DF06 RID: 57094 RVA: 0x0033B564 File Offset: 0x00339764
		public byte[] GetScoreTextArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003899 RID: 14489
		// (get) Token: 0x0600DF07 RID: 57095 RVA: 0x0033B57C File Offset: 0x0033977C
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

		// Token: 0x1700389A RID: 14490
		// (get) Token: 0x0600DF08 RID: 57096 RVA: 0x0033B5BC File Offset: 0x003397BC
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

		// Token: 0x1700389B RID: 14491
		// (get) Token: 0x0600DF09 RID: 57097 RVA: 0x0033B5FC File Offset: 0x003397FC
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

		// Token: 0x1700389C RID: 14492
		// (get) Token: 0x0600DF0A RID: 57098 RVA: 0x0033B63C File Offset: 0x0033983C
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

		// Token: 0x0600DF0B RID: 57099 RVA: 0x0033B674 File Offset: 0x00339874
		public Span<byte> GetLockTipsBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600DF0C RID: 57100 RVA: 0x0033B684 File Offset: 0x00339884
		public byte[] GetLockTipsArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04005807 RID: 22535
		private Table __p;
	}
}
