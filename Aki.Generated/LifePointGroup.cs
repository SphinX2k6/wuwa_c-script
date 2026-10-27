using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DC8 RID: 3528
	public struct LifePointGroup : IFlatbufferObject
	{
		// Token: 0x17001CDE RID: 7390
		// (get) Token: 0x06008DEE RID: 36334 RVA: 0x00277679 File Offset: 0x00275879
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008DEF RID: 36335 RVA: 0x00277686 File Offset: 0x00275886
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008DF0 RID: 36336 RVA: 0x00277690 File Offset: 0x00275890
		public static LifePointGroup GetRootAsLifePointGroup(ByteBuffer _bb)
		{
			return LifePointGroup.GetRootAsLifePointGroup(_bb, default(LifePointGroup));
		}

		// Token: 0x06008DF1 RID: 36337 RVA: 0x002776AC File Offset: 0x002758AC
		public static LifePointGroup GetRootAsLifePointGroup(ByteBuffer _bb, LifePointGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008DF2 RID: 36338 RVA: 0x002776C9 File Offset: 0x002758C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008DF3 RID: 36339 RVA: 0x002776D8 File Offset: 0x002758D8
		public LifePointGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001CDF RID: 7391
		// (get) Token: 0x06008DF4 RID: 36340 RVA: 0x002776E8 File Offset: 0x002758E8
		public int GroupId
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

		// Token: 0x06008DF5 RID: 36341 RVA: 0x00277724 File Offset: 0x00275924
		public int ChallengeList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001CE0 RID: 7392
		// (get) Token: 0x06008DF6 RID: 36342 RVA: 0x00277764 File Offset: 0x00275964
		public int ChallengeListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008DF7 RID: 36343 RVA: 0x0027778F File Offset: 0x0027598F
		public Span<int> GetChallengeListBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06008DF8 RID: 36344 RVA: 0x0027779E File Offset: 0x0027599E
		public int[] GetChallengeListArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x17001CE1 RID: 7393
		// (get) Token: 0x06008DF9 RID: 36345 RVA: 0x002777B8 File Offset: 0x002759B8
		public string LockEntracneGroupNumResource
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

		// Token: 0x06008DFA RID: 36346 RVA: 0x002777EF File Offset: 0x002759EF
		public Span<byte> GetLockEntracneGroupNumResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008DFB RID: 36347 RVA: 0x002777FE File Offset: 0x002759FE
		public byte[] GetLockEntracneGroupNumResourceArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CE2 RID: 7394
		// (get) Token: 0x06008DFC RID: 36348 RVA: 0x00277818 File Offset: 0x00275A18
		public string EntracneGroupNumResource
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

		// Token: 0x06008DFD RID: 36349 RVA: 0x00277850 File Offset: 0x00275A50
		public Span<byte> GetEntracneGroupNumResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008DFE RID: 36350 RVA: 0x00277860 File Offset: 0x00275A60
		public byte[] GetEntracneGroupNumResourceArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CE3 RID: 7395
		// (get) Token: 0x06008DFF RID: 36351 RVA: 0x00277878 File Offset: 0x00275A78
		public string HighlightEntranceResource
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

		// Token: 0x06008E00 RID: 36352 RVA: 0x002778B0 File Offset: 0x00275AB0
		public Span<byte> GetHighlightEntranceResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06008E01 RID: 36353 RVA: 0x002778C0 File Offset: 0x00275AC0
		public byte[] GetHighlightEntranceResourceArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CE4 RID: 7396
		// (get) Token: 0x06008E02 RID: 36354 RVA: 0x002778D8 File Offset: 0x00275AD8
		public string LockHighlightEntranceResource
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

		// Token: 0x06008E03 RID: 36355 RVA: 0x00277910 File Offset: 0x00275B10
		public Span<byte> GetLockHighlightEntranceResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008E04 RID: 36356 RVA: 0x00277920 File Offset: 0x00275B20
		public byte[] GetLockHighlightEntranceResourceArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CE5 RID: 7397
		// (get) Token: 0x06008E05 RID: 36357 RVA: 0x00277938 File Offset: 0x00275B38
		public string LevelNumResource
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

		// Token: 0x06008E06 RID: 36358 RVA: 0x00277970 File Offset: 0x00275B70
		public Span<byte> GetLevelNumResourceBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008E07 RID: 36359 RVA: 0x00277980 File Offset: 0x00275B80
		public byte[] GetLevelNumResourceArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001CE6 RID: 7398
		// (get) Token: 0x06008E08 RID: 36360 RVA: 0x00277998 File Offset: 0x00275B98
		public string Name
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

		// Token: 0x06008E09 RID: 36361 RVA: 0x002779D0 File Offset: 0x00275BD0
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008E0A RID: 36362 RVA: 0x002779E0 File Offset: 0x00275BE0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x06008E0B RID: 36363 RVA: 0x002779F8 File Offset: 0x00275BF8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ChallengeListIter()或GetChallengeListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ChallengeList()
		{
			LifePointGroup lifePointGroup = this;
			return lifePointGroup.GetChallengeListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008E0C RID: 36364 RVA: 0x00277A1C File Offset: 0x00275C1C
		[NullableContext(1)]
		public readonly IEnumerable<int> ChallengeListIter()
		{
			LifePointGroup.<ChallengeListIter>d__40 <ChallengeListIter>d__ = new LifePointGroup.<ChallengeListIter>d__40(-2);
			<ChallengeListIter>d__.<>3__<>4__this = this;
			return <ChallengeListIter>d__;
		}

		// Token: 0x04004E5E RID: 20062
		private Table __p;
	}
}
