using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D97 RID: 3479
	[NullableContext(1)]
	[Nullable(0)]
	public struct FloroRanchSubIns : IFlatbufferObject
	{
		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x06007A0D RID: 31245 RVA: 0x0025B85C File Offset: 0x00259A5C
		[Nullable(0)]
		public ByteBuffer ByteBuffer
		{
			[NullableContext(0)]
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A0E RID: 31246 RVA: 0x0025B869 File Offset: 0x00259A69
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A0F RID: 31247 RVA: 0x0025B870 File Offset: 0x00259A70
		[NullableContext(0)]
		public static FloroRanchSubIns GetRootAsFloroRanchSubIns(ByteBuffer _bb)
		{
			return FloroRanchSubIns.GetRootAsFloroRanchSubIns(_bb, default(FloroRanchSubIns));
		}

		// Token: 0x06007A10 RID: 31248 RVA: 0x0025B88C File Offset: 0x00259A8C
		[NullableContext(0)]
		public static FloroRanchSubIns GetRootAsFloroRanchSubIns(ByteBuffer _bb, FloroRanchSubIns obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007A11 RID: 31249 RVA: 0x0025B8A9 File Offset: 0x00259AA9
		[NullableContext(0)]
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007A12 RID: 31250 RVA: 0x0025B8B8 File Offset: 0x00259AB8
		[NullableContext(0)]
		public FloroRanchSubIns __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x06007A13 RID: 31251 RVA: 0x0025B8C8 File Offset: 0x00259AC8
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

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x06007A14 RID: 31252 RVA: 0x0025B904 File Offset: 0x00259B04
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

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x06007A15 RID: 31253 RVA: 0x0025B940 File Offset: 0x00259B40
		public int Difficulty
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

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x06007A16 RID: 31254 RVA: 0x0025B97C File Offset: 0x00259B7C
		public int Tag
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

		// Token: 0x06007A17 RID: 31255 RVA: 0x0025B9BC File Offset: 0x00259BBC
		public int Race(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06007A18 RID: 31256 RVA: 0x0025B9FC File Offset: 0x00259BFC
		public int RaceLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007A19 RID: 31257 RVA: 0x0025BA28 File Offset: 0x00259C28
		[NullableContext(0)]
		public Span<int> GetRaceBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06007A1A RID: 31258 RVA: 0x0025BA38 File Offset: 0x00259C38
		[NullableContext(0)]
		public int[] GetRaceArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06007A1B RID: 31259 RVA: 0x0025BA50 File Offset: 0x00259C50
		public int Stage
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

		// Token: 0x06007A1C RID: 31260 RVA: 0x0025BA90 File Offset: 0x00259C90
		public int StageDays(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06007A1D RID: 31261 RVA: 0x0025BAD0 File Offset: 0x00259CD0
		public int StageDaysLength
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

		// Token: 0x06007A1E RID: 31262 RVA: 0x0025BAFC File Offset: 0x00259CFC
		[NullableContext(0)]
		public Span<int> GetStageDaysBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06007A1F RID: 31263 RVA: 0x0025BB0C File Offset: 0x00259D0C
		[NullableContext(0)]
		public int[] GetStageDaysArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06007A20 RID: 31264 RVA: 0x0025BB24 File Offset: 0x00259D24
		public int Goal(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x06007A21 RID: 31265 RVA: 0x0025BB64 File Offset: 0x00259D64
		public int GoalLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007A22 RID: 31266 RVA: 0x0025BB90 File Offset: 0x00259D90
		[NullableContext(0)]
		public Span<int> GetGoalBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06007A23 RID: 31267 RVA: 0x0025BBA0 File Offset: 0x00259DA0
		[NullableContext(0)]
		public int[] GetGoalArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06007A24 RID: 31268 RVA: 0x0025BBB8 File Offset: 0x00259DB8
		public int FirstTechReward
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

		// Token: 0x06007A25 RID: 31269 RVA: 0x0025BBF8 File Offset: 0x00259DF8
		public int TechReward(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06007A26 RID: 31270 RVA: 0x0025BC38 File Offset: 0x00259E38
		public int TechRewardLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007A27 RID: 31271 RVA: 0x0025BC64 File Offset: 0x00259E64
		[NullableContext(0)]
		public Span<int> GetTechRewardBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x06007A28 RID: 31272 RVA: 0x0025BC74 File Offset: 0x00259E74
		[NullableContext(0)]
		public int[] GetTechRewardArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x06007A29 RID: 31273 RVA: 0x0025BC8C File Offset: 0x00259E8C
		public int ToyReward(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06007A2A RID: 31274 RVA: 0x0025BCCC File Offset: 0x00259ECC
		public int ToyRewardLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007A2B RID: 31275 RVA: 0x0025BCF8 File Offset: 0x00259EF8
		[NullableContext(0)]
		public Span<int> GetToyRewardBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06007A2C RID: 31276 RVA: 0x0025BD08 File Offset: 0x00259F08
		[NullableContext(0)]
		public int[] GetToyRewardArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06007A2D RID: 31277 RVA: 0x0025BD20 File Offset: 0x00259F20
		public DicIntString? FirstWinReward(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06007A2E RID: 31278 RVA: 0x0025BD84 File Offset: 0x00259F84
		public int FirstWinRewardLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007A2F RID: 31279 RVA: 0x0025BDB0 File Offset: 0x00259FB0
		public DicIntInt? Terrain(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06007A30 RID: 31280 RVA: 0x0025BE14 File Offset: 0x0025A014
		public int TerrainLength
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

		// Token: 0x06007A31 RID: 31281 RVA: 0x0025BE40 File Offset: 0x0025A040
		public int CardBase(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06007A32 RID: 31282 RVA: 0x0025BE80 File Offset: 0x0025A080
		public int CardBaseLength
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

		// Token: 0x06007A33 RID: 31283 RVA: 0x0025BEAC File Offset: 0x0025A0AC
		[NullableContext(0)]
		public Span<int> GetCardBaseBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x06007A34 RID: 31284 RVA: 0x0025BEBC File Offset: 0x0025A0BC
		[NullableContext(0)]
		public int[] GetCardBaseArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x06007A35 RID: 31285 RVA: 0x0025BED4 File Offset: 0x0025A0D4
		public DicIntInt? Card(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06007A36 RID: 31286 RVA: 0x0025BF38 File Offset: 0x0025A138
		public int CardLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007A37 RID: 31287 RVA: 0x0025BF64 File Offset: 0x0025A164
		public int StartToy(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06007A38 RID: 31288 RVA: 0x0025BFA4 File Offset: 0x0025A1A4
		public int StartToyLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007A39 RID: 31289 RVA: 0x0025BFD0 File Offset: 0x0025A1D0
		[NullableContext(0)]
		public Span<int> GetStartToyBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x06007A3A RID: 31290 RVA: 0x0025BFE0 File Offset: 0x0025A1E0
		[NullableContext(0)]
		public int[] GetStartToyArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06007A3B RID: 31291 RVA: 0x0025BFF8 File Offset: 0x0025A1F8
		public int EventGroup
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x06007A3C RID: 31292 RVA: 0x0025C038 File Offset: 0x0025A238
		public bool EndlessMode
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x0025C078 File Offset: 0x0025A278
		[NullableContext(0)]
		public string EnvironmentText(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06007A3E RID: 31294 RVA: 0x0025C0B4 File Offset: 0x0025A2B4
		public int EnvironmentTextLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007A3F RID: 31295 RVA: 0x0025C0E0 File Offset: 0x0025A2E0
		public int RecommendCards(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06007A40 RID: 31296 RVA: 0x0025C120 File Offset: 0x0025A320
		public int RecommendCardsLength
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007A41 RID: 31297 RVA: 0x0025C14C File Offset: 0x0025A34C
		[NullableContext(0)]
		public Span<int> GetRecommendCardsBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06007A42 RID: 31298 RVA: 0x0025C15C File Offset: 0x0025A35C
		[NullableContext(0)]
		public int[] GetRecommendCardsArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x06007A43 RID: 31299 RVA: 0x0025C174 File Offset: 0x0025A374
		public int RecommendToys(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06007A44 RID: 31300 RVA: 0x0025C1B4 File Offset: 0x0025A3B4
		public int RecommendToysLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06007A45 RID: 31301 RVA: 0x0025C1E0 File Offset: 0x0025A3E0
		[NullableContext(0)]
		public Span<int> GetRecommendToysBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x06007A46 RID: 31302 RVA: 0x0025C1F0 File Offset: 0x0025A3F0
		[NullableContext(0)]
		public int[] GetRecommendToysArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x06007A47 RID: 31303 RVA: 0x0025C208 File Offset: 0x0025A408
		public Dictionary<int, int> Card()
		{
			return this.CardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007A48 RID: 31304 RVA: 0x0025C25E File Offset: 0x0025A45E
		public IEnumerable<DicIntInt> CardIter()
		{
			FloroRanchSubIns.<CardIter>d__82 <CardIter>d__ = new FloroRanchSubIns.<CardIter>d__82(-2);
			<CardIter>d__.<>3__<>4__this = this;
			return <CardIter>d__;
		}

		// Token: 0x06007A49 RID: 31305 RVA: 0x0025C273 File Offset: 0x0025A473
		public int[] CardBase()
		{
			return this.GetCardBaseArray();
		}

		// Token: 0x06007A4A RID: 31306 RVA: 0x0025C27B File Offset: 0x0025A47B
		public IEnumerable<int> CardBaseIter()
		{
			FloroRanchSubIns.<CardBaseIter>d__84 <CardBaseIter>d__ = new FloroRanchSubIns.<CardBaseIter>d__84(-2);
			<CardBaseIter>d__.<>3__<>4__this = this;
			return <CardBaseIter>d__;
		}

		// Token: 0x06007A4B RID: 31307 RVA: 0x0025C290 File Offset: 0x0025A490
		public string[] EnvironmentText()
		{
			return this.EnvironmentTextIter().ToArray<string>();
		}

		// Token: 0x06007A4C RID: 31308 RVA: 0x0025C29D File Offset: 0x0025A49D
		public IEnumerable<string> EnvironmentTextIter()
		{
			FloroRanchSubIns.<EnvironmentTextIter>d__86 <EnvironmentTextIter>d__ = new FloroRanchSubIns.<EnvironmentTextIter>d__86(-2);
			<EnvironmentTextIter>d__.<>3__<>4__this = this;
			return <EnvironmentTextIter>d__;
		}

		// Token: 0x06007A4D RID: 31309 RVA: 0x0025C2B4 File Offset: 0x0025A4B4
		public Dictionary<int, string> FirstWinReward()
		{
			return this.FirstWinRewardIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06007A4E RID: 31310 RVA: 0x0025C30A File Offset: 0x0025A50A
		public IEnumerable<DicIntString> FirstWinRewardIter()
		{
			FloroRanchSubIns.<FirstWinRewardIter>d__88 <FirstWinRewardIter>d__ = new FloroRanchSubIns.<FirstWinRewardIter>d__88(-2);
			<FirstWinRewardIter>d__.<>3__<>4__this = this;
			return <FirstWinRewardIter>d__;
		}

		// Token: 0x06007A4F RID: 31311 RVA: 0x0025C31F File Offset: 0x0025A51F
		public int[] Goal()
		{
			return this.GetGoalArray();
		}

		// Token: 0x06007A50 RID: 31312 RVA: 0x0025C327 File Offset: 0x0025A527
		public IEnumerable<int> GoalIter()
		{
			FloroRanchSubIns.<GoalIter>d__90 <GoalIter>d__ = new FloroRanchSubIns.<GoalIter>d__90(-2);
			<GoalIter>d__.<>3__<>4__this = this;
			return <GoalIter>d__;
		}

		// Token: 0x06007A51 RID: 31313 RVA: 0x0025C33C File Offset: 0x0025A53C
		public int[] Race()
		{
			return this.GetRaceArray();
		}

		// Token: 0x06007A52 RID: 31314 RVA: 0x0025C344 File Offset: 0x0025A544
		public IEnumerable<int> RaceIter()
		{
			FloroRanchSubIns.<RaceIter>d__92 <RaceIter>d__ = new FloroRanchSubIns.<RaceIter>d__92(-2);
			<RaceIter>d__.<>3__<>4__this = this;
			return <RaceIter>d__;
		}

		// Token: 0x06007A53 RID: 31315 RVA: 0x0025C359 File Offset: 0x0025A559
		public int[] RecommendCards()
		{
			return this.GetRecommendCardsArray();
		}

		// Token: 0x06007A54 RID: 31316 RVA: 0x0025C361 File Offset: 0x0025A561
		public IEnumerable<int> RecommendCardsIter()
		{
			FloroRanchSubIns.<RecommendCardsIter>d__94 <RecommendCardsIter>d__ = new FloroRanchSubIns.<RecommendCardsIter>d__94(-2);
			<RecommendCardsIter>d__.<>3__<>4__this = this;
			return <RecommendCardsIter>d__;
		}

		// Token: 0x06007A55 RID: 31317 RVA: 0x0025C376 File Offset: 0x0025A576
		public int[] RecommendToys()
		{
			return this.GetRecommendToysArray();
		}

		// Token: 0x06007A56 RID: 31318 RVA: 0x0025C37E File Offset: 0x0025A57E
		public IEnumerable<int> RecommendToysIter()
		{
			FloroRanchSubIns.<RecommendToysIter>d__96 <RecommendToysIter>d__ = new FloroRanchSubIns.<RecommendToysIter>d__96(-2);
			<RecommendToysIter>d__.<>3__<>4__this = this;
			return <RecommendToysIter>d__;
		}

		// Token: 0x06007A57 RID: 31319 RVA: 0x0025C393 File Offset: 0x0025A593
		public int[] StageDays()
		{
			return this.GetStageDaysArray();
		}

		// Token: 0x06007A58 RID: 31320 RVA: 0x0025C39B File Offset: 0x0025A59B
		public IEnumerable<int> StageDaysIter()
		{
			FloroRanchSubIns.<StageDaysIter>d__98 <StageDaysIter>d__ = new FloroRanchSubIns.<StageDaysIter>d__98(-2);
			<StageDaysIter>d__.<>3__<>4__this = this;
			return <StageDaysIter>d__;
		}

		// Token: 0x06007A59 RID: 31321 RVA: 0x0025C3B0 File Offset: 0x0025A5B0
		public int[] StartToy()
		{
			return this.GetStartToyArray();
		}

		// Token: 0x06007A5A RID: 31322 RVA: 0x0025C3B8 File Offset: 0x0025A5B8
		public IEnumerable<int> StartToyIter()
		{
			FloroRanchSubIns.<StartToyIter>d__100 <StartToyIter>d__ = new FloroRanchSubIns.<StartToyIter>d__100(-2);
			<StartToyIter>d__.<>3__<>4__this = this;
			return <StartToyIter>d__;
		}

		// Token: 0x06007A5B RID: 31323 RVA: 0x0025C3CD File Offset: 0x0025A5CD
		public int[] TechReward()
		{
			return this.GetTechRewardArray();
		}

		// Token: 0x06007A5C RID: 31324 RVA: 0x0025C3D5 File Offset: 0x0025A5D5
		public IEnumerable<int> TechRewardIter()
		{
			FloroRanchSubIns.<TechRewardIter>d__102 <TechRewardIter>d__ = new FloroRanchSubIns.<TechRewardIter>d__102(-2);
			<TechRewardIter>d__.<>3__<>4__this = this;
			return <TechRewardIter>d__;
		}

		// Token: 0x06007A5D RID: 31325 RVA: 0x0025C3EC File Offset: 0x0025A5EC
		public Dictionary<int, int> Terrain()
		{
			return this.TerrainIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007A5E RID: 31326 RVA: 0x0025C442 File Offset: 0x0025A642
		public IEnumerable<DicIntInt> TerrainIter()
		{
			FloroRanchSubIns.<TerrainIter>d__104 <TerrainIter>d__ = new FloroRanchSubIns.<TerrainIter>d__104(-2);
			<TerrainIter>d__.<>3__<>4__this = this;
			return <TerrainIter>d__;
		}

		// Token: 0x06007A5F RID: 31327 RVA: 0x0025C457 File Offset: 0x0025A657
		public int[] ToyReward()
		{
			return this.GetToyRewardArray();
		}

		// Token: 0x06007A60 RID: 31328 RVA: 0x0025C45F File Offset: 0x0025A65F
		public IEnumerable<int> ToyRewardIter()
		{
			FloroRanchSubIns.<ToyRewardIter>d__106 <ToyRewardIter>d__ = new FloroRanchSubIns.<ToyRewardIter>d__106(-2);
			<ToyRewardIter>d__.<>3__<>4__this = this;
			return <ToyRewardIter>d__;
		}

		// Token: 0x06007A61 RID: 31329 RVA: 0x0025C474 File Offset: 0x0025A674
		public int? GetCard(int key)
		{
			this.EnsureCardCacheIfNeeded();
			int value;
			if (!this.CardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007A62 RID: 31330 RVA: 0x0025C4A8 File Offset: 0x0025A6A8
		[NullableContext(2)]
		public string GetFirstWinReward(int key)
		{
			this.EnsureFirstWinRewardCacheIfNeeded();
			string result;
			if (!this.FirstWinRewardCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06007A63 RID: 31331 RVA: 0x0025C4D0 File Offset: 0x0025A6D0
		public int? GetTerrain(int key)
		{
			this.EnsureTerrainCacheIfNeeded();
			int value;
			if (!this.TerrainCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06007A64 RID: 31332 RVA: 0x0025C504 File Offset: 0x0025A704
		private void EnsureCardCacheIfNeeded()
		{
			if (this.CardCache != null)
			{
				return;
			}
			this.CardCache = this.CardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007A65 RID: 31333 RVA: 0x0025C56C File Offset: 0x0025A76C
		private void EnsureFirstWinRewardCacheIfNeeded()
		{
			if (this.FirstWinRewardCache != null)
			{
				return;
			}
			this.FirstWinRewardCache = this.FirstWinRewardIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06007A66 RID: 31334 RVA: 0x0025C5D4 File Offset: 0x0025A7D4
		private void EnsureTerrainCacheIfNeeded()
		{
			if (this.TerrainCache != null)
			{
				return;
			}
			this.TerrainCache = this.TerrainIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06007A67 RID: 31335 RVA: 0x0025C63A File Offset: 0x0025A83A
		public FrozenDictionary<int, int> GetCardFrozenDict()
		{
			this.EnsureCardCacheIfNeeded();
			return this.CardCache;
		}

		// Token: 0x06007A68 RID: 31336 RVA: 0x0025C648 File Offset: 0x0025A848
		public FrozenDictionary<int, string> GetFirstWinRewardFrozenDict()
		{
			this.EnsureFirstWinRewardCacheIfNeeded();
			return this.FirstWinRewardCache;
		}

		// Token: 0x06007A69 RID: 31337 RVA: 0x0025C656 File Offset: 0x0025A856
		public FrozenDictionary<int, int> GetTerrainFrozenDict()
		{
			this.EnsureTerrainCacheIfNeeded();
			return this.TerrainCache;
		}

		// Token: 0x040052FF RID: 21247
		private Table __p;

		// Token: 0x04005300 RID: 21248
		[Nullable(2)]
		private FrozenDictionary<int, int> CardCache;

		// Token: 0x04005301 RID: 21249
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> FirstWinRewardCache;

		// Token: 0x04005302 RID: 21250
		[Nullable(2)]
		private FrozenDictionary<int, int> TerrainCache;
	}
}
