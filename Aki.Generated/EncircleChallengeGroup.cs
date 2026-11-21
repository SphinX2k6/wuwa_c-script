using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D11 RID: 3345
	public struct EncircleChallengeGroup : IFlatbufferObject
	{
		// Token: 0x17000F48 RID: 3912
		// (get) Token: 0x06006EC3 RID: 28355 RVA: 0x00241AD1 File Offset: 0x0023FCD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006EC4 RID: 28356 RVA: 0x00241ADE File Offset: 0x0023FCDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006EC5 RID: 28357 RVA: 0x00241AE8 File Offset: 0x0023FCE8
		public static EncircleChallengeGroup GetRootAsEncircleChallengeGroup(ByteBuffer _bb)
		{
			return EncircleChallengeGroup.GetRootAsEncircleChallengeGroup(_bb, default(EncircleChallengeGroup));
		}

		// Token: 0x06006EC6 RID: 28358 RVA: 0x00241B04 File Offset: 0x0023FD04
		public static EncircleChallengeGroup GetRootAsEncircleChallengeGroup(ByteBuffer _bb, EncircleChallengeGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006EC7 RID: 28359 RVA: 0x00241B21 File Offset: 0x0023FD21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006EC8 RID: 28360 RVA: 0x00241B30 File Offset: 0x0023FD30
		public EncircleChallengeGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F49 RID: 3913
		// (get) Token: 0x06006EC9 RID: 28361 RVA: 0x00241B40 File Offset: 0x0023FD40
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

		// Token: 0x17000F4A RID: 3914
		// (get) Token: 0x06006ECA RID: 28362 RVA: 0x00241B7C File Offset: 0x0023FD7C
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

		// Token: 0x06006ECB RID: 28363 RVA: 0x00241BB8 File Offset: 0x0023FDB8
		public int Challenges(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F4B RID: 3915
		// (get) Token: 0x06006ECC RID: 28364 RVA: 0x00241BF8 File Offset: 0x0023FDF8
		public int ChallengesLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006ECD RID: 28365 RVA: 0x00241C23 File Offset: 0x0023FE23
		public Span<int> GetChallengesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06006ECE RID: 28366 RVA: 0x00241C32 File Offset: 0x0023FE32
		public int[] GetChallengesArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000F4C RID: 3916
		// (get) Token: 0x06006ECF RID: 28367 RVA: 0x00241C4C File Offset: 0x0023FE4C
		public int PreviousGroup
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

		// Token: 0x17000F4D RID: 3917
		// (get) Token: 0x06006ED0 RID: 28368 RVA: 0x00241C8C File Offset: 0x0023FE8C
		public int OpenDay
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

		// Token: 0x17000F4E RID: 3918
		// (get) Token: 0x06006ED1 RID: 28369 RVA: 0x00241CCC File Offset: 0x0023FECC
		public string LevelTitle
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

		// Token: 0x06006ED2 RID: 28370 RVA: 0x00241D04 File Offset: 0x0023FF04
		public Span<byte> GetLevelTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06006ED3 RID: 28371 RVA: 0x00241D14 File Offset: 0x0023FF14
		public byte[] GetLevelTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06006ED4 RID: 28372 RVA: 0x00241D2C File Offset: 0x0023FF2C
		public int ReduceDiffCnt(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F4F RID: 3919
		// (get) Token: 0x06006ED5 RID: 28373 RVA: 0x00241D6C File Offset: 0x0023FF6C
		public int ReduceDiffCntLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06006ED6 RID: 28374 RVA: 0x00241D98 File Offset: 0x0023FF98
		public Span<int> GetReduceDiffCntBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06006ED7 RID: 28375 RVA: 0x00241DA8 File Offset: 0x0023FFA8
		public int[] GetReduceDiffCntArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06006ED8 RID: 28376 RVA: 0x00241DC0 File Offset: 0x0023FFC0
		[NullableContext(1)]
		public int[] Challenges()
		{
			return this.GetChallengesArray();
		}

		// Token: 0x06006ED9 RID: 28377 RVA: 0x00241DC8 File Offset: 0x0023FFC8
		[NullableContext(1)]
		public IEnumerable<int> ChallengesIter()
		{
			EncircleChallengeGroup.<ChallengesIter>d__31 <ChallengesIter>d__ = new EncircleChallengeGroup.<ChallengesIter>d__31(-2);
			<ChallengesIter>d__.<>3__<>4__this = this;
			return <ChallengesIter>d__;
		}

		// Token: 0x06006EDA RID: 28378 RVA: 0x00241DDD File Offset: 0x0023FFDD
		[NullableContext(1)]
		public int[] ReduceDiffCnt()
		{
			return this.GetReduceDiffCntArray();
		}

		// Token: 0x06006EDB RID: 28379 RVA: 0x00241DE5 File Offset: 0x0023FFE5
		[NullableContext(1)]
		public IEnumerable<int> ReduceDiffCntIter()
		{
			EncircleChallengeGroup.<ReduceDiffCntIter>d__33 <ReduceDiffCntIter>d__ = new EncircleChallengeGroup.<ReduceDiffCntIter>d__33(-2);
			<ReduceDiffCntIter>d__.<>3__<>4__this = this;
			return <ReduceDiffCntIter>d__;
		}

		// Token: 0x04005251 RID: 21073
		private Table __p;
	}
}
