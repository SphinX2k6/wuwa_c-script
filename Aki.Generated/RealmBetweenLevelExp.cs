using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F9B RID: 3995
	public struct RealmBetweenLevelExp : IFlatbufferObject
	{
		// Token: 0x17002D1E RID: 11550
		// (get) Token: 0x0600B953 RID: 47443 RVA: 0x002D80DD File Offset: 0x002D62DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B954 RID: 47444 RVA: 0x002D80EA File Offset: 0x002D62EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B955 RID: 47445 RVA: 0x002D80F4 File Offset: 0x002D62F4
		public static RealmBetweenLevelExp GetRootAsRealmBetweenLevelExp(ByteBuffer _bb)
		{
			return RealmBetweenLevelExp.GetRootAsRealmBetweenLevelExp(_bb, default(RealmBetweenLevelExp));
		}

		// Token: 0x0600B956 RID: 47446 RVA: 0x002D8110 File Offset: 0x002D6310
		public static RealmBetweenLevelExp GetRootAsRealmBetweenLevelExp(ByteBuffer _bb, RealmBetweenLevelExp obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B957 RID: 47447 RVA: 0x002D812D File Offset: 0x002D632D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B958 RID: 47448 RVA: 0x002D813C File Offset: 0x002D633C
		public RealmBetweenLevelExp __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D1F RID: 11551
		// (get) Token: 0x0600B959 RID: 47449 RVA: 0x002D814C File Offset: 0x002D634C
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

		// Token: 0x17002D20 RID: 11552
		// (get) Token: 0x0600B95A RID: 47450 RVA: 0x002D8188 File Offset: 0x002D6388
		public int ActivityId
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

		// Token: 0x17002D21 RID: 11553
		// (get) Token: 0x0600B95B RID: 47451 RVA: 0x002D81C4 File Offset: 0x002D63C4
		public int Level
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

		// Token: 0x17002D22 RID: 11554
		// (get) Token: 0x0600B95C RID: 47452 RVA: 0x002D8200 File Offset: 0x002D6400
		public int NeedExp
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

		// Token: 0x17002D23 RID: 11555
		// (get) Token: 0x0600B95D RID: 47453 RVA: 0x002D8240 File Offset: 0x002D6440
		public int RewardDropId
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

		// Token: 0x17002D24 RID: 11556
		// (get) Token: 0x0600B95E RID: 47454 RVA: 0x002D8280 File Offset: 0x002D6480
		public string TipsLock
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

		// Token: 0x0600B95F RID: 47455 RVA: 0x002D82B8 File Offset: 0x002D64B8
		public Span<byte> GetTipsLockBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600B960 RID: 47456 RVA: 0x002D82C8 File Offset: 0x002D64C8
		public byte[] GetTipsLockArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002D25 RID: 11557
		// (get) Token: 0x0600B961 RID: 47457 RVA: 0x002D82E0 File Offset: 0x002D64E0
		public string TipsDone
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

		// Token: 0x0600B962 RID: 47458 RVA: 0x002D8318 File Offset: 0x002D6518
		public Span<byte> GetTipsDoneBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600B963 RID: 47459 RVA: 0x002D8328 File Offset: 0x002D6528
		public byte[] GetTipsDoneArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0400506B RID: 20587
		private Table __p;
	}
}
