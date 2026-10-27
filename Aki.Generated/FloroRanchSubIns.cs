using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CB3 RID: 3251
	public struct FloroRanchSubIns : IFlatbufferObject
	{
		// Token: 0x17001327 RID: 4903
		// (get) Token: 0x06007402 RID: 29698 RVA: 0x0023C9E0 File Offset: 0x0023ABE0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007403 RID: 29699 RVA: 0x0023C9ED File Offset: 0x0023ABED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007404 RID: 29700 RVA: 0x0023C9F4 File Offset: 0x0023ABF4
		public static FloroRanchSubIns GetRootAsFloroRanchSubIns(ByteBuffer _bb)
		{
			return FloroRanchSubIns.GetRootAsFloroRanchSubIns(_bb, default(FloroRanchSubIns));
		}

		// Token: 0x06007405 RID: 29701 RVA: 0x0023CA10 File Offset: 0x0023AC10
		public static FloroRanchSubIns GetRootAsFloroRanchSubIns(ByteBuffer _bb, FloroRanchSubIns obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007406 RID: 29702 RVA: 0x0023CA2D File Offset: 0x0023AC2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007407 RID: 29703 RVA: 0x0023CA3C File Offset: 0x0023AC3C
		public FloroRanchSubIns __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001328 RID: 4904
		// (get) Token: 0x06007408 RID: 29704 RVA: 0x0023CA4C File Offset: 0x0023AC4C
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

		// Token: 0x17001329 RID: 4905
		// (get) Token: 0x06007409 RID: 29705 RVA: 0x0023CA88 File Offset: 0x0023AC88
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

		// Token: 0x1700132A RID: 4906
		// (get) Token: 0x0600740A RID: 29706 RVA: 0x0023CAC4 File Offset: 0x0023ACC4
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

		// Token: 0x1700132B RID: 4907
		// (get) Token: 0x0600740B RID: 29707 RVA: 0x0023CB00 File Offset: 0x0023AD00
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

		// Token: 0x0600740C RID: 29708 RVA: 0x0023CB40 File Offset: 0x0023AD40
		public int Race(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700132C RID: 4908
		// (get) Token: 0x0600740D RID: 29709 RVA: 0x0023CB80 File Offset: 0x0023AD80
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

		// Token: 0x0600740E RID: 29710 RVA: 0x0023CBAC File Offset: 0x0023ADAC
		public Span<int> GetRaceBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600740F RID: 29711 RVA: 0x0023CBBC File Offset: 0x0023ADBC
		public int[] GetRaceArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x1700132D RID: 4909
		// (get) Token: 0x06007410 RID: 29712 RVA: 0x0023CBD4 File Offset: 0x0023ADD4
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

		// Token: 0x06007411 RID: 29713 RVA: 0x0023CC14 File Offset: 0x0023AE14
		public int StageDays(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700132E RID: 4910
		// (get) Token: 0x06007412 RID: 29714 RVA: 0x0023CC54 File Offset: 0x0023AE54
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

		// Token: 0x06007413 RID: 29715 RVA: 0x0023CC80 File Offset: 0x0023AE80
		public Span<int> GetStageDaysBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06007414 RID: 29716 RVA: 0x0023CC90 File Offset: 0x0023AE90
		public int[] GetStageDaysArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x06007415 RID: 29717 RVA: 0x0023CCA8 File Offset: 0x0023AEA8
		public int Goal(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700132F RID: 4911
		// (get) Token: 0x06007416 RID: 29718 RVA: 0x0023CCE8 File Offset: 0x0023AEE8
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

		// Token: 0x06007417 RID: 29719 RVA: 0x0023CD14 File Offset: 0x0023AF14
		public Span<int> GetGoalBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x06007418 RID: 29720 RVA: 0x0023CD24 File Offset: 0x0023AF24
		public int[] GetGoalArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17001330 RID: 4912
		// (get) Token: 0x06007419 RID: 29721 RVA: 0x0023CD3C File Offset: 0x0023AF3C
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

		// Token: 0x0600741A RID: 29722 RVA: 0x0023CD7C File Offset: 0x0023AF7C
		public int TechReward(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001331 RID: 4913
		// (get) Token: 0x0600741B RID: 29723 RVA: 0x0023CDBC File Offset: 0x0023AFBC
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

		// Token: 0x0600741C RID: 29724 RVA: 0x0023CDE8 File Offset: 0x0023AFE8
		public Span<int> GetTechRewardBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600741D RID: 29725 RVA: 0x0023CDF8 File Offset: 0x0023AFF8
		public int[] GetTechRewardArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600741E RID: 29726 RVA: 0x0023CE10 File Offset: 0x0023B010
		public int ToyReward(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001332 RID: 4914
		// (get) Token: 0x0600741F RID: 29727 RVA: 0x0023CE50 File Offset: 0x0023B050
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

		// Token: 0x06007420 RID: 29728 RVA: 0x0023CE7C File Offset: 0x0023B07C
		public Span<int> GetToyRewardBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06007421 RID: 29729 RVA: 0x0023CE8C File Offset: 0x0023B08C
		public int[] GetToyRewardArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x06007422 RID: 29730 RVA: 0x0023CEA4 File Offset: 0x0023B0A4
		public DicIntString? FirstWinReward(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001333 RID: 4915
		// (get) Token: 0x06007423 RID: 29731 RVA: 0x0023CF08 File Offset: 0x0023B108
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

		// Token: 0x06007424 RID: 29732 RVA: 0x0023CF34 File Offset: 0x0023B134
		public DicIntInt? Terrain(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06007425 RID: 29733 RVA: 0x0023CF98 File Offset: 0x0023B198
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

		// Token: 0x06007426 RID: 29734 RVA: 0x0023CFC4 File Offset: 0x0023B1C4
		public int CardBase(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06007427 RID: 29735 RVA: 0x0023D004 File Offset: 0x0023B204
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

		// Token: 0x06007428 RID: 29736 RVA: 0x0023D030 File Offset: 0x0023B230
		public Span<int> GetCardBaseBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x0023D040 File Offset: 0x0023B240
		public int[] GetCardBaseArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x0023D058 File Offset: 0x0023B258
		public DicIntInt? Card(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x0600742B RID: 29739 RVA: 0x0023D0BC File Offset: 0x0023B2BC
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

		// Token: 0x0600742C RID: 29740 RVA: 0x0023D0E8 File Offset: 0x0023B2E8
		public int StartToy(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x0600742D RID: 29741 RVA: 0x0023D128 File Offset: 0x0023B328
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

		// Token: 0x0600742E RID: 29742 RVA: 0x0023D154 File Offset: 0x0023B354
		public Span<int> GetStartToyBytes()
		{
			return this.__p.__vector_as_span<int>(34, 4);
		}

		// Token: 0x0600742F RID: 29743 RVA: 0x0023D164 File Offset: 0x0023B364
		public int[] GetStartToyArray()
		{
			return this.__p.__vector_as_array<int>(34) ?? Array.Empty<int>();
		}

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06007430 RID: 29744 RVA: 0x0023D17C File Offset: 0x0023B37C
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

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06007431 RID: 29745 RVA: 0x0023D1BC File Offset: 0x0023B3BC
		public bool EndlessMode
		{
			get
			{
				int num = this.__p.__offset(38);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06007432 RID: 29746 RVA: 0x0023D1FC File Offset: 0x0023B3FC
		public string EnvironmentText(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06007433 RID: 29747 RVA: 0x0023D238 File Offset: 0x0023B438
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

		// Token: 0x06007434 RID: 29748 RVA: 0x0023D264 File Offset: 0x0023B464
		public int RecommendCards(int j)
		{
			int num = this.__p.__offset(42);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x06007435 RID: 29749 RVA: 0x0023D2A4 File Offset: 0x0023B4A4
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

		// Token: 0x06007436 RID: 29750 RVA: 0x0023D2D0 File Offset: 0x0023B4D0
		public Span<int> GetRecommendCardsBytes()
		{
			return this.__p.__vector_as_span<int>(42, 4);
		}

		// Token: 0x06007437 RID: 29751 RVA: 0x0023D2E0 File Offset: 0x0023B4E0
		public int[] GetRecommendCardsArray()
		{
			return this.__p.__vector_as_array<int>(42) ?? Array.Empty<int>();
		}

		// Token: 0x06007438 RID: 29752 RVA: 0x0023D2F8 File Offset: 0x0023B4F8
		public int RecommendToys(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06007439 RID: 29753 RVA: 0x0023D338 File Offset: 0x0023B538
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

		// Token: 0x0600743A RID: 29754 RVA: 0x0023D364 File Offset: 0x0023B564
		public Span<int> GetRecommendToysBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x0600743B RID: 29755 RVA: 0x0023D374 File Offset: 0x0023B574
		public int[] GetRecommendToysArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x0600743C RID: 29756 RVA: 0x0023D38C File Offset: 0x0023B58C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CardFrozenDict()缓存字典，遍历请使用CardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Card()
		{
			return this.CardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600743D RID: 29757 RVA: 0x0023D3E2 File Offset: 0x0023B5E2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> CardIter()
		{
			FloroRanchSubIns.<CardIter>d__82 <CardIter>d__ = new FloroRanchSubIns.<CardIter>d__82(-2);
			<CardIter>d__.<>3__<>4__this = this;
			return <CardIter>d__;
		}

		// Token: 0x0600743E RID: 29758 RVA: 0x0023D3F8 File Offset: 0x0023B5F8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CardBaseIter()或GetCardBaseBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CardBase()
		{
			FloroRanchSubIns floroRanchSubIns = this;
			return floroRanchSubIns.GetCardBaseArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600743F RID: 29759 RVA: 0x0023D41C File Offset: 0x0023B61C
		[NullableContext(1)]
		public readonly IEnumerable<int> CardBaseIter()
		{
			FloroRanchSubIns.<CardBaseIter>d__84 <CardBaseIter>d__ = new FloroRanchSubIns.<CardBaseIter>d__84(-2);
			<CardBaseIter>d__.<>3__<>4__this = this;
			return <CardBaseIter>d__;
		}

		// Token: 0x06007440 RID: 29760 RVA: 0x0023D431 File Offset: 0x0023B631
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EnvironmentTextIter()或GetEnvironmentTextBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EnvironmentText()
		{
			return this.EnvironmentTextIter().ToArray<string>();
		}

		// Token: 0x06007441 RID: 29761 RVA: 0x0023D43E File Offset: 0x0023B63E
		[NullableContext(1)]
		public readonly IEnumerable<string> EnvironmentTextIter()
		{
			FloroRanchSubIns.<EnvironmentTextIter>d__86 <EnvironmentTextIter>d__ = new FloroRanchSubIns.<EnvironmentTextIter>d__86(-2);
			<EnvironmentTextIter>d__.<>3__<>4__this = this;
			return <EnvironmentTextIter>d__;
		}

		// Token: 0x06007442 RID: 29762 RVA: 0x0023D454 File Offset: 0x0023B654
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FirstWinRewardFrozenDict()缓存字典，遍历请使用FirstWinRewardIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> FirstWinReward()
		{
			return this.FirstWinRewardIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06007443 RID: 29763 RVA: 0x0023D4AA File Offset: 0x0023B6AA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> FirstWinRewardIter()
		{
			FloroRanchSubIns.<FirstWinRewardIter>d__88 <FirstWinRewardIter>d__ = new FloroRanchSubIns.<FirstWinRewardIter>d__88(-2);
			<FirstWinRewardIter>d__.<>3__<>4__this = this;
			return <FirstWinRewardIter>d__;
		}

		// Token: 0x06007444 RID: 29764 RVA: 0x0023D4C0 File Offset: 0x0023B6C0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GoalIter()或GetGoalBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Goal()
		{
			FloroRanchSubIns floroRanchSubIns = this;
			return floroRanchSubIns.GetGoalArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007445 RID: 29765 RVA: 0x0023D4E4 File Offset: 0x0023B6E4
		[NullableContext(1)]
		public readonly IEnumerable<int> GoalIter()
		{
			FloroRanchSubIns.<GoalIter>d__90 <GoalIter>d__ = new FloroRanchSubIns.<GoalIter>d__90(-2);
			<GoalIter>d__.<>3__<>4__this = this;
			return <GoalIter>d__;
		}

		// Token: 0x06007446 RID: 29766 RVA: 0x0023D4FC File Offset: 0x0023B6FC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RaceIter()或GetRaceBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] Race()
		{
			FloroRanchSubIns floroRanchSubIns = this;
			return floroRanchSubIns.GetRaceArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007447 RID: 29767 RVA: 0x0023D520 File Offset: 0x0023B720
		[NullableContext(1)]
		public readonly IEnumerable<int> RaceIter()
		{
			FloroRanchSubIns.<RaceIter>d__92 <RaceIter>d__ = new FloroRanchSubIns.<RaceIter>d__92(-2);
			<RaceIter>d__.<>3__<>4__this = this;
			return <RaceIter>d__;
		}

		// Token: 0x06007448 RID: 29768 RVA: 0x0023D538 File Offset: 0x0023B738
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendCardsIter()或GetRecommendCardsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendCards()
		{
			FloroRanchSubIns floroRanchSubIns = this;
			return floroRanchSubIns.GetRecommendCardsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007449 RID: 29769 RVA: 0x0023D55C File Offset: 0x0023B75C
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendCardsIter()
		{
			FloroRanchSubIns.<RecommendCardsIter>d__94 <RecommendCardsIter>d__ = new FloroRanchSubIns.<RecommendCardsIter>d__94(-2);
			<RecommendCardsIter>d__.<>3__<>4__this = this;
			return <RecommendCardsIter>d__;
		}

		// Token: 0x0600744A RID: 29770 RVA: 0x0023D574 File Offset: 0x0023B774
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RecommendToysIter()或GetRecommendToysBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RecommendToys()
		{
			FloroRanchSubIns floroRanchSubIns = this;
			return floroRanchSubIns.GetRecommendToysArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600744B RID: 29771 RVA: 0x0023D598 File Offset: 0x0023B798
		[NullableContext(1)]
		public readonly IEnumerable<int> RecommendToysIter()
		{
			FloroRanchSubIns.<RecommendToysIter>d__96 <RecommendToysIter>d__ = new FloroRanchSubIns.<RecommendToysIter>d__96(-2);
			<RecommendToysIter>d__.<>3__<>4__this = this;
			return <RecommendToysIter>d__;
		}

		// Token: 0x0600744C RID: 29772 RVA: 0x0023D5B0 File Offset: 0x0023B7B0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StageDaysIter()或GetStageDaysBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] StageDays()
		{
			FloroRanchSubIns floroRanchSubIns = this;
			return floroRanchSubIns.GetStageDaysArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600744D RID: 29773 RVA: 0x0023D5D4 File Offset: 0x0023B7D4
		[NullableContext(1)]
		public readonly IEnumerable<int> StageDaysIter()
		{
			FloroRanchSubIns.<StageDaysIter>d__98 <StageDaysIter>d__ = new FloroRanchSubIns.<StageDaysIter>d__98(-2);
			<StageDaysIter>d__.<>3__<>4__this = this;
			return <StageDaysIter>d__;
		}

		// Token: 0x0600744E RID: 29774 RVA: 0x0023D5EC File Offset: 0x0023B7EC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用StartToyIter()或GetStartToyBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] StartToy()
		{
			FloroRanchSubIns floroRanchSubIns = this;
			return floroRanchSubIns.GetStartToyArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600744F RID: 29775 RVA: 0x0023D610 File Offset: 0x0023B810
		[NullableContext(1)]
		public readonly IEnumerable<int> StartToyIter()
		{
			FloroRanchSubIns.<StartToyIter>d__100 <StartToyIter>d__ = new FloroRanchSubIns.<StartToyIter>d__100(-2);
			<StartToyIter>d__.<>3__<>4__this = this;
			return <StartToyIter>d__;
		}

		// Token: 0x06007450 RID: 29776 RVA: 0x0023D628 File Offset: 0x0023B828
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TechRewardIter()或GetTechRewardBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] TechReward()
		{
			FloroRanchSubIns floroRanchSubIns = this;
			return floroRanchSubIns.GetTechRewardArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007451 RID: 29777 RVA: 0x0023D64C File Offset: 0x0023B84C
		[NullableContext(1)]
		public readonly IEnumerable<int> TechRewardIter()
		{
			FloroRanchSubIns.<TechRewardIter>d__102 <TechRewardIter>d__ = new FloroRanchSubIns.<TechRewardIter>d__102(-2);
			<TechRewardIter>d__.<>3__<>4__this = this;
			return <TechRewardIter>d__;
		}

		// Token: 0x06007452 RID: 29778 RVA: 0x0023D664 File Offset: 0x0023B864
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TerrainFrozenDict()缓存字典，遍历请使用TerrainIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Terrain()
		{
			return this.TerrainIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06007453 RID: 29779 RVA: 0x0023D6BA File Offset: 0x0023B8BA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> TerrainIter()
		{
			FloroRanchSubIns.<TerrainIter>d__104 <TerrainIter>d__ = new FloroRanchSubIns.<TerrainIter>d__104(-2);
			<TerrainIter>d__.<>3__<>4__this = this;
			return <TerrainIter>d__;
		}

		// Token: 0x06007454 RID: 29780 RVA: 0x0023D6D0 File Offset: 0x0023B8D0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ToyRewardIter()或GetToyRewardBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ToyReward()
		{
			FloroRanchSubIns floroRanchSubIns = this;
			return floroRanchSubIns.GetToyRewardArray() ?? Array.Empty<int>();
		}

		// Token: 0x06007455 RID: 29781 RVA: 0x0023D6F4 File Offset: 0x0023B8F4
		[NullableContext(1)]
		public readonly IEnumerable<int> ToyRewardIter()
		{
			FloroRanchSubIns.<ToyRewardIter>d__106 <ToyRewardIter>d__ = new FloroRanchSubIns.<ToyRewardIter>d__106(-2);
			<ToyRewardIter>d__.<>3__<>4__this = this;
			return <ToyRewardIter>d__;
		}

		// Token: 0x06007456 RID: 29782 RVA: 0x0023D70C File Offset: 0x0023B90C
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

		// Token: 0x06007457 RID: 29783 RVA: 0x0023D740 File Offset: 0x0023B940
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

		// Token: 0x06007458 RID: 29784 RVA: 0x0023D768 File Offset: 0x0023B968
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

		// Token: 0x06007459 RID: 29785 RVA: 0x0023D79C File Offset: 0x0023B99C
		private void EnsureCardCacheIfNeeded()
		{
			if (this.CardCache != null)
			{
				return;
			}
			this.CardCache = this.CardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600745A RID: 29786 RVA: 0x0023D804 File Offset: 0x0023BA04
		private void EnsureFirstWinRewardCacheIfNeeded()
		{
			if (this.FirstWinRewardCache != null)
			{
				return;
			}
			this.FirstWinRewardCache = this.FirstWinRewardIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600745B RID: 29787 RVA: 0x0023D86C File Offset: 0x0023BA6C
		private void EnsureTerrainCacheIfNeeded()
		{
			if (this.TerrainCache != null)
			{
				return;
			}
			this.TerrainCache = this.TerrainIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600745C RID: 29788 RVA: 0x0023D8D2 File Offset: 0x0023BAD2
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetCardFrozenDict(int key)
		{
			this.EnsureCardCacheIfNeeded();
			return this.CardCache;
		}

		// Token: 0x0600745D RID: 29789 RVA: 0x0023D8E0 File Offset: 0x0023BAE0
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetFirstWinRewardFrozenDict(int key)
		{
			this.EnsureFirstWinRewardCacheIfNeeded();
			return this.FirstWinRewardCache;
		}

		// Token: 0x0600745E RID: 29790 RVA: 0x0023D8EE File Offset: 0x0023BAEE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetTerrainFrozenDict(int key)
		{
			this.EnsureTerrainCacheIfNeeded();
			return this.TerrainCache;
		}

		// Token: 0x04004D1B RID: 19739
		private Table __p;

		// Token: 0x04004D1C RID: 19740
		[Nullable(2)]
		private FrozenDictionary<int, int> CardCache;

		// Token: 0x04004D1D RID: 19741
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> FirstWinRewardCache;

		// Token: 0x04004D1E RID: 19742
		[Nullable(2)]
		private FrozenDictionary<int, int> TerrainCache;
	}
}
