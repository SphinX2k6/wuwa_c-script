using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C2E RID: 3118
	public struct EncircleChallengeGroup : IFlatbufferObject
	{
		// Token: 0x17000EEF RID: 3823
		// (get) Token: 0x060068C1 RID: 26817 RVA: 0x002225C1 File Offset: 0x002207C1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060068C2 RID: 26818 RVA: 0x002225CE File Offset: 0x002207CE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060068C3 RID: 26819 RVA: 0x002225D8 File Offset: 0x002207D8
		public static EncircleChallengeGroup GetRootAsEncircleChallengeGroup(ByteBuffer _bb)
		{
			return EncircleChallengeGroup.GetRootAsEncircleChallengeGroup(_bb, default(EncircleChallengeGroup));
		}

		// Token: 0x060068C4 RID: 26820 RVA: 0x002225F4 File Offset: 0x002207F4
		public static EncircleChallengeGroup GetRootAsEncircleChallengeGroup(ByteBuffer _bb, EncircleChallengeGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060068C5 RID: 26821 RVA: 0x00222611 File Offset: 0x00220811
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060068C6 RID: 26822 RVA: 0x00222620 File Offset: 0x00220820
		public EncircleChallengeGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000EF0 RID: 3824
		// (get) Token: 0x060068C7 RID: 26823 RVA: 0x00222630 File Offset: 0x00220830
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

		// Token: 0x17000EF1 RID: 3825
		// (get) Token: 0x060068C8 RID: 26824 RVA: 0x0022266C File Offset: 0x0022086C
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

		// Token: 0x060068C9 RID: 26825 RVA: 0x002226A8 File Offset: 0x002208A8
		public int Challenges(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EF2 RID: 3826
		// (get) Token: 0x060068CA RID: 26826 RVA: 0x002226E8 File Offset: 0x002208E8
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

		// Token: 0x060068CB RID: 26827 RVA: 0x00222713 File Offset: 0x00220913
		public Span<int> GetChallengesBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x060068CC RID: 26828 RVA: 0x00222722 File Offset: 0x00220922
		public int[] GetChallengesArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17000EF3 RID: 3827
		// (get) Token: 0x060068CD RID: 26829 RVA: 0x0022273C File Offset: 0x0022093C
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

		// Token: 0x17000EF4 RID: 3828
		// (get) Token: 0x060068CE RID: 26830 RVA: 0x0022277C File Offset: 0x0022097C
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

		// Token: 0x17000EF5 RID: 3829
		// (get) Token: 0x060068CF RID: 26831 RVA: 0x002227BC File Offset: 0x002209BC
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

		// Token: 0x060068D0 RID: 26832 RVA: 0x002227F4 File Offset: 0x002209F4
		public Span<byte> GetLevelTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060068D1 RID: 26833 RVA: 0x00222804 File Offset: 0x00220A04
		public byte[] GetLevelTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x060068D2 RID: 26834 RVA: 0x0022281C File Offset: 0x00220A1C
		public int ReduceDiffCnt(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x060068D3 RID: 26835 RVA: 0x0022285C File Offset: 0x00220A5C
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

		// Token: 0x060068D4 RID: 26836 RVA: 0x00222888 File Offset: 0x00220A88
		public Span<int> GetReduceDiffCntBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x060068D5 RID: 26837 RVA: 0x00222898 File Offset: 0x00220A98
		public int[] GetReduceDiffCntArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x060068D6 RID: 26838 RVA: 0x002228B0 File Offset: 0x00220AB0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ChallengesIter()或GetChallengesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Challenges()
		{
			EncircleChallengeGroup encircleChallengeGroup = this;
			return encircleChallengeGroup.GetChallengesArray() ?? Array.Empty<int>();
		}

		// Token: 0x060068D7 RID: 26839 RVA: 0x002228D4 File Offset: 0x00220AD4
		[NullableContext(1)]
		public readonly IEnumerable<int> ChallengesIter()
		{
			EncircleChallengeGroup.<ChallengesIter>d__31 <ChallengesIter>d__ = new EncircleChallengeGroup.<ChallengesIter>d__31(-2);
			<ChallengesIter>d__.<>3__<>4__this = this;
			return <ChallengesIter>d__;
		}

		// Token: 0x060068D8 RID: 26840 RVA: 0x002228EC File Offset: 0x00220AEC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ReduceDiffCntIter()或GetReduceDiffCntBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ReduceDiffCnt()
		{
			EncircleChallengeGroup encircleChallengeGroup = this;
			return encircleChallengeGroup.GetReduceDiffCntArray() ?? Array.Empty<int>();
		}

		// Token: 0x060068D9 RID: 26841 RVA: 0x00222910 File Offset: 0x00220B10
		[NullableContext(1)]
		public readonly IEnumerable<int> ReduceDiffCntIter()
		{
			EncircleChallengeGroup.<ReduceDiffCntIter>d__33 <ReduceDiffCntIter>d__ = new EncircleChallengeGroup.<ReduceDiffCntIter>d__33(-2);
			<ReduceDiffCntIter>d__.<>3__<>4__this = this;
			return <ReduceDiffCntIter>d__;
		}

		// Token: 0x04004C6E RID: 19566
		private Table __p;
	}
}
