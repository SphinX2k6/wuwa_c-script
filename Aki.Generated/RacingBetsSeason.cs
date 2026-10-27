using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F92 RID: 3986
	public struct RacingBetsSeason : IFlatbufferObject
	{
		// Token: 0x17002CDB RID: 11483
		// (get) Token: 0x0600B8C1 RID: 47297 RVA: 0x002D6B54 File Offset: 0x002D4D54
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B8C2 RID: 47298 RVA: 0x002D6B61 File Offset: 0x002D4D61
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B8C3 RID: 47299 RVA: 0x002D6B68 File Offset: 0x002D4D68
		public static RacingBetsSeason GetRootAsRacingBetsSeason(ByteBuffer _bb)
		{
			return RacingBetsSeason.GetRootAsRacingBetsSeason(_bb, default(RacingBetsSeason));
		}

		// Token: 0x0600B8C4 RID: 47300 RVA: 0x002D6B84 File Offset: 0x002D4D84
		public static RacingBetsSeason GetRootAsRacingBetsSeason(ByteBuffer _bb, RacingBetsSeason obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B8C5 RID: 47301 RVA: 0x002D6BA1 File Offset: 0x002D4DA1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B8C6 RID: 47302 RVA: 0x002D6BB0 File Offset: 0x002D4DB0
		public RacingBetsSeason __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002CDC RID: 11484
		// (get) Token: 0x0600B8C7 RID: 47303 RVA: 0x002D6BC0 File Offset: 0x002D4DC0
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

		// Token: 0x17002CDD RID: 11485
		// (get) Token: 0x0600B8C8 RID: 47304 RVA: 0x002D6BFC File Offset: 0x002D4DFC
		public int MoneyId
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

		// Token: 0x17002CDE RID: 11486
		// (get) Token: 0x0600B8C9 RID: 47305 RVA: 0x002D6C38 File Offset: 0x002D4E38
		public int MoneyUpperLimitCount
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

		// Token: 0x17002CDF RID: 11487
		// (get) Token: 0x0600B8CA RID: 47306 RVA: 0x002D6C74 File Offset: 0x002D4E74
		public int EndReward
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

		// Token: 0x0600B8CB RID: 47307 RVA: 0x002D6CB4 File Offset: 0x002D4EB4
		public int GroupMatches(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CE0 RID: 11488
		// (get) Token: 0x0600B8CC RID: 47308 RVA: 0x002D6CF4 File Offset: 0x002D4EF4
		public int GroupMatchesLength
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

		// Token: 0x0600B8CD RID: 47309 RVA: 0x002D6D20 File Offset: 0x002D4F20
		public Span<int> GetGroupMatchesBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600B8CE RID: 47310 RVA: 0x002D6D30 File Offset: 0x002D4F30
		public int[] GetGroupMatchesArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600B8CF RID: 47311 RVA: 0x002D6D48 File Offset: 0x002D4F48
		public int EliminateMatches(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CE1 RID: 11489
		// (get) Token: 0x0600B8D0 RID: 47312 RVA: 0x002D6D88 File Offset: 0x002D4F88
		public int EliminateMatchesLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B8D1 RID: 47313 RVA: 0x002D6DB4 File Offset: 0x002D4FB4
		public Span<int> GetEliminateMatchesBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600B8D2 RID: 47314 RVA: 0x002D6DC4 File Offset: 0x002D4FC4
		public int[] GetEliminateMatchesArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600B8D3 RID: 47315 RVA: 0x002D6DDC File Offset: 0x002D4FDC
		public int EliminateMatchesSecond(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CE2 RID: 11490
		// (get) Token: 0x0600B8D4 RID: 47316 RVA: 0x002D6E1C File Offset: 0x002D501C
		public int EliminateMatchesSecondLength
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

		// Token: 0x0600B8D5 RID: 47317 RVA: 0x002D6E48 File Offset: 0x002D5048
		public Span<int> GetEliminateMatchesSecondBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600B8D6 RID: 47318 RVA: 0x002D6E58 File Offset: 0x002D5058
		public int[] GetEliminateMatchesSecondArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17002CE3 RID: 11491
		// (get) Token: 0x0600B8D7 RID: 47319 RVA: 0x002D6E70 File Offset: 0x002D5070
		public int FinalMatches
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

		// Token: 0x17002CE4 RID: 11492
		// (get) Token: 0x0600B8D8 RID: 47320 RVA: 0x002D6EB0 File Offset: 0x002D50B0
		public int FinalCurtainGroupMatch
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

		// Token: 0x17002CE5 RID: 11493
		// (get) Token: 0x0600B8D9 RID: 47321 RVA: 0x002D6EF0 File Offset: 0x002D50F0
		public int FinalCurtainEliminateMatch
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

		// Token: 0x0600B8DA RID: 47322 RVA: 0x002D6F30 File Offset: 0x002D5130
		public int OddsUpdate(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002CE6 RID: 11494
		// (get) Token: 0x0600B8DB RID: 47323 RVA: 0x002D6F70 File Offset: 0x002D5170
		public int OddsUpdateLength
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

		// Token: 0x0600B8DC RID: 47324 RVA: 0x002D6F9C File Offset: 0x002D519C
		public Span<int> GetOddsUpdateBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600B8DD RID: 47325 RVA: 0x002D6FAC File Offset: 0x002D51AC
		public int[] GetOddsUpdateArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17002CE7 RID: 11495
		// (get) Token: 0x0600B8DE RID: 47326 RVA: 0x002D6FC4 File Offset: 0x002D51C4
		public int GearNum
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

		// Token: 0x17002CE8 RID: 11496
		// (get) Token: 0x0600B8DF RID: 47327 RVA: 0x002D7004 File Offset: 0x002D5204
		public int LegMatchRoundMinTime
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CE9 RID: 11497
		// (get) Token: 0x0600B8E0 RID: 47328 RVA: 0x002D7044 File Offset: 0x002D5244
		public int DungeonInstanceId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CEA RID: 11498
		// (get) Token: 0x0600B8E1 RID: 47329 RVA: 0x002D7084 File Offset: 0x002D5284
		public int DungeonEntranceId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CEB RID: 11499
		// (get) Token: 0x0600B8E2 RID: 47330 RVA: 0x002D70C4 File Offset: 0x002D52C4
		public int ButtleScreenCD
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CEC RID: 11500
		// (get) Token: 0x0600B8E3 RID: 47331 RVA: 0x002D7104 File Offset: 0x002D5304
		public int RandomSeedIndex
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

		// Token: 0x17002CED RID: 11501
		// (get) Token: 0x0600B8E4 RID: 47332 RVA: 0x002D7144 File Offset: 0x002D5344
		public int EndMailId
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002CEE RID: 11502
		// (get) Token: 0x0600B8E5 RID: 47333 RVA: 0x002D7184 File Offset: 0x002D5384
		public int CalcRankDelay
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B8E6 RID: 47334 RVA: 0x002D71C4 File Offset: 0x002D53C4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EliminateMatchesIter()或GetEliminateMatchesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EliminateMatches()
		{
			RacingBetsSeason racingBetsSeason = this;
			return racingBetsSeason.GetEliminateMatchesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B8E7 RID: 47335 RVA: 0x002D71E8 File Offset: 0x002D53E8
		[NullableContext(1)]
		public readonly IEnumerable<int> EliminateMatchesIter()
		{
			RacingBetsSeason.<EliminateMatchesIter>d__59 <EliminateMatchesIter>d__ = new RacingBetsSeason.<EliminateMatchesIter>d__59(-2);
			<EliminateMatchesIter>d__.<>3__<>4__this = this;
			return <EliminateMatchesIter>d__;
		}

		// Token: 0x0600B8E8 RID: 47336 RVA: 0x002D7200 File Offset: 0x002D5400
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EliminateMatchesSecondIter()或GetEliminateMatchesSecondBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EliminateMatchesSecond()
		{
			RacingBetsSeason racingBetsSeason = this;
			return racingBetsSeason.GetEliminateMatchesSecondArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B8E9 RID: 47337 RVA: 0x002D7224 File Offset: 0x002D5424
		[NullableContext(1)]
		public readonly IEnumerable<int> EliminateMatchesSecondIter()
		{
			RacingBetsSeason.<EliminateMatchesSecondIter>d__61 <EliminateMatchesSecondIter>d__ = new RacingBetsSeason.<EliminateMatchesSecondIter>d__61(-2);
			<EliminateMatchesSecondIter>d__.<>3__<>4__this = this;
			return <EliminateMatchesSecondIter>d__;
		}

		// Token: 0x0600B8EA RID: 47338 RVA: 0x002D723C File Offset: 0x002D543C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GroupMatchesIter()或GetGroupMatchesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GroupMatches()
		{
			RacingBetsSeason racingBetsSeason = this;
			return racingBetsSeason.GetGroupMatchesArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B8EB RID: 47339 RVA: 0x002D7260 File Offset: 0x002D5460
		[NullableContext(1)]
		public readonly IEnumerable<int> GroupMatchesIter()
		{
			RacingBetsSeason.<GroupMatchesIter>d__63 <GroupMatchesIter>d__ = new RacingBetsSeason.<GroupMatchesIter>d__63(-2);
			<GroupMatchesIter>d__.<>3__<>4__this = this;
			return <GroupMatchesIter>d__;
		}

		// Token: 0x0600B8EC RID: 47340 RVA: 0x002D7278 File Offset: 0x002D5478
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OddsUpdateIter()或GetOddsUpdateBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] OddsUpdate()
		{
			RacingBetsSeason racingBetsSeason = this;
			return racingBetsSeason.GetOddsUpdateArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600B8ED RID: 47341 RVA: 0x002D729C File Offset: 0x002D549C
		[NullableContext(1)]
		public readonly IEnumerable<int> OddsUpdateIter()
		{
			RacingBetsSeason.<OddsUpdateIter>d__65 <OddsUpdateIter>d__ = new RacingBetsSeason.<OddsUpdateIter>d__65(-2);
			<OddsUpdateIter>d__.<>3__<>4__this = this;
			return <OddsUpdateIter>d__;
		}

		// Token: 0x04005062 RID: 20578
		private Table __p;
	}
}
