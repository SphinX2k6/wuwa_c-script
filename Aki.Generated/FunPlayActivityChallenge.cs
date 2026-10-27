using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CD5 RID: 3285
	public struct FunPlayActivityChallenge : IFlatbufferObject
	{
		// Token: 0x17001452 RID: 5202
		// (get) Token: 0x06007741 RID: 30529 RVA: 0x00244069 File Offset: 0x00242269
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x00244076 File Offset: 0x00242276
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x00244080 File Offset: 0x00242280
		public static FunPlayActivityChallenge GetRootAsFunPlayActivityChallenge(ByteBuffer _bb)
		{
			return FunPlayActivityChallenge.GetRootAsFunPlayActivityChallenge(_bb, default(FunPlayActivityChallenge));
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x0024409C File Offset: 0x0024229C
		public static FunPlayActivityChallenge GetRootAsFunPlayActivityChallenge(ByteBuffer _bb, FunPlayActivityChallenge obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x002440B9 File Offset: 0x002422B9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x002440C8 File Offset: 0x002422C8
		public FunPlayActivityChallenge __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001453 RID: 5203
		// (get) Token: 0x06007747 RID: 30535 RVA: 0x002440D8 File Offset: 0x002422D8
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

		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x06007748 RID: 30536 RVA: 0x00244114 File Offset: 0x00242314
		public int InstId
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

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x06007749 RID: 30537 RVA: 0x00244150 File Offset: 0x00242350
		public int ActivityId
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

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x0600774A RID: 30538 RVA: 0x0024418C File Offset: 0x0024238C
		public int OpenDay
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

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x0600774B RID: 30539 RVA: 0x002441CC File Offset: 0x002423CC
		public int RewardId
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

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x0600774C RID: 30540 RVA: 0x0024420C File Offset: 0x0024240C
		public string Title
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

		// Token: 0x0600774D RID: 30541 RVA: 0x00244244 File Offset: 0x00242444
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x00244254 File Offset: 0x00242454
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x0600774F RID: 30543 RVA: 0x0024426C File Offset: 0x0024246C
		public string Desc
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

		// Token: 0x06007750 RID: 30544 RVA: 0x002442A4 File Offset: 0x002424A4
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x002442B4 File Offset: 0x002424B4
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700145A RID: 5210
		// (get) Token: 0x06007752 RID: 30546 RVA: 0x002442CC File Offset: 0x002424CC
		public string TabTitle
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x00244304 File Offset: 0x00242504
		public Span<byte> GetTabTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x00244314 File Offset: 0x00242514
		public byte[] GetTabTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700145B RID: 5211
		// (get) Token: 0x06007755 RID: 30549 RVA: 0x0024432C File Offset: 0x0024252C
		public string BackGroundTexture
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x00244364 File Offset: 0x00242564
		public Span<byte> GetBackGroundTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x00244374 File Offset: 0x00242574
		public byte[] GetBackGroundTextureArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x04004D45 RID: 19781
		private Table __p;
	}
}
