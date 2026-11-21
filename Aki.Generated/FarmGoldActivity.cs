using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D3E RID: 3390
	public struct FarmGoldActivity : IFlatbufferObject
	{
		// Token: 0x17001096 RID: 4246
		// (get) Token: 0x06007282 RID: 29314 RVA: 0x00249DFC File Offset: 0x00247FFC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007283 RID: 29315 RVA: 0x00249E09 File Offset: 0x00248009
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007284 RID: 29316 RVA: 0x00249E10 File Offset: 0x00248010
		public static FarmGoldActivity GetRootAsFarmGoldActivity(ByteBuffer _bb)
		{
			return FarmGoldActivity.GetRootAsFarmGoldActivity(_bb, default(FarmGoldActivity));
		}

		// Token: 0x06007285 RID: 29317 RVA: 0x00249E2C File Offset: 0x0024802C
		public static FarmGoldActivity GetRootAsFarmGoldActivity(ByteBuffer _bb, FarmGoldActivity obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007286 RID: 29318 RVA: 0x00249E49 File Offset: 0x00248049
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007287 RID: 29319 RVA: 0x00249E58 File Offset: 0x00248058
		public FarmGoldActivity __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001097 RID: 4247
		// (get) Token: 0x06007288 RID: 29320 RVA: 0x00249E68 File Offset: 0x00248068
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

		// Token: 0x17001098 RID: 4248
		// (get) Token: 0x06007289 RID: 29321 RVA: 0x00249EA4 File Offset: 0x002480A4
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

		// Token: 0x17001099 RID: 4249
		// (get) Token: 0x0600728A RID: 29322 RVA: 0x00249EE0 File Offset: 0x002480E0
		public int InstId
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

		// Token: 0x1700109A RID: 4250
		// (get) Token: 0x0600728B RID: 29323 RVA: 0x00249F1C File Offset: 0x0024811C
		public int EntranceId
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

		// Token: 0x1700109B RID: 4251
		// (get) Token: 0x0600728C RID: 29324 RVA: 0x00249F5C File Offset: 0x0024815C
		public int GroupId
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

		// Token: 0x1700109C RID: 4252
		// (get) Token: 0x0600728D RID: 29325 RVA: 0x00249F9C File Offset: 0x0024819C
		public int SortId
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

		// Token: 0x1700109D RID: 4253
		// (get) Token: 0x0600728E RID: 29326 RVA: 0x00249FDC File Offset: 0x002481DC
		public int PassScore
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

		// Token: 0x1700109E RID: 4254
		// (get) Token: 0x0600728F RID: 29327 RVA: 0x0024A01C File Offset: 0x0024821C
		public string LevelRewardDesc
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

		// Token: 0x06007290 RID: 29328 RVA: 0x0024A054 File Offset: 0x00248254
		public Span<byte> GetLevelRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06007291 RID: 29329 RVA: 0x0024A064 File Offset: 0x00248264
		public byte[] GetLevelRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x1700109F RID: 4255
		// (get) Token: 0x06007292 RID: 29330 RVA: 0x0024A07C File Offset: 0x0024827C
		public int RewardId
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

		// Token: 0x170010A0 RID: 4256
		// (get) Token: 0x06007293 RID: 29331 RVA: 0x0024A0BC File Offset: 0x002482BC
		public int OpenDay
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170010A1 RID: 4257
		// (get) Token: 0x06007294 RID: 29332 RVA: 0x0024A0FC File Offset: 0x002482FC
		public int PreLevel
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

		// Token: 0x170010A2 RID: 4258
		// (get) Token: 0x06007295 RID: 29333 RVA: 0x0024A13C File Offset: 0x0024833C
		public int RecommendLevel
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06007296 RID: 29334 RVA: 0x0024A17C File Offset: 0x0024837C
		public int DifficultyOptions(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170010A3 RID: 4259
		// (get) Token: 0x06007297 RID: 29335 RVA: 0x0024A1BC File Offset: 0x002483BC
		public int DifficultyOptionsLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007298 RID: 29336 RVA: 0x0024A1E8 File Offset: 0x002483E8
		public Span<int> GetDifficultyOptionsBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x06007299 RID: 29337 RVA: 0x0024A1F8 File Offset: 0x002483F8
		public int[] GetDifficultyOptionsArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x0600729A RID: 29338 RVA: 0x0024A210 File Offset: 0x00248410
		public int RecommendTagIds(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170010A4 RID: 4260
		// (get) Token: 0x0600729B RID: 29339 RVA: 0x0024A250 File Offset: 0x00248450
		public int RecommendTagIdsLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600729C RID: 29340 RVA: 0x0024A27C File Offset: 0x0024847C
		public Span<int> GetRecommendTagIdsBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x0600729D RID: 29341 RVA: 0x0024A28C File Offset: 0x0024848C
		public int[] GetRecommendTagIdsArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x0600729E RID: 29342 RVA: 0x0024A2A4 File Offset: 0x002484A4
		[NullableContext(1)]
		public int[] DifficultyOptions()
		{
			return this.GetDifficultyOptionsArray();
		}

		// Token: 0x0600729F RID: 29343 RVA: 0x0024A2AC File Offset: 0x002484AC
		[NullableContext(1)]
		public IEnumerable<int> DifficultyOptionsIter()
		{
			FarmGoldActivity.<DifficultyOptionsIter>d__45 <DifficultyOptionsIter>d__ = new FarmGoldActivity.<DifficultyOptionsIter>d__45(-2);
			<DifficultyOptionsIter>d__.<>3__<>4__this = this;
			return <DifficultyOptionsIter>d__;
		}

		// Token: 0x060072A0 RID: 29344 RVA: 0x0024A2C1 File Offset: 0x002484C1
		[NullableContext(1)]
		public int[] RecommendTagIds()
		{
			return this.GetRecommendTagIdsArray();
		}

		// Token: 0x060072A1 RID: 29345 RVA: 0x0024A2C9 File Offset: 0x002484C9
		[NullableContext(1)]
		public IEnumerable<int> RecommendTagIdsIter()
		{
			FarmGoldActivity.<RecommendTagIdsIter>d__47 <RecommendTagIdsIter>d__ = new FarmGoldActivity.<RecommendTagIdsIter>d__47(-2);
			<RecommendTagIdsIter>d__.<>3__<>4__this = this;
			return <RecommendTagIdsIter>d__;
		}

		// Token: 0x04005289 RID: 21129
		private Table __p;
	}
}
