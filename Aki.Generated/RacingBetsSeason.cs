using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001079 RID: 4217
	public struct RacingBetsSeason : IFlatbufferObject
	{
		// Token: 0x17002D53 RID: 11603
		// (get) Token: 0x0600BEFE RID: 48894 RVA: 0x002F3404 File Offset: 0x002F1604
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BEFF RID: 48895 RVA: 0x002F3411 File Offset: 0x002F1611
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BF00 RID: 48896 RVA: 0x002F3418 File Offset: 0x002F1618
		public static RacingBetsSeason GetRootAsRacingBetsSeason(ByteBuffer _bb)
		{
			return RacingBetsSeason.GetRootAsRacingBetsSeason(_bb, default(RacingBetsSeason));
		}

		// Token: 0x0600BF01 RID: 48897 RVA: 0x002F3434 File Offset: 0x002F1634
		public static RacingBetsSeason GetRootAsRacingBetsSeason(ByteBuffer _bb, RacingBetsSeason obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BF02 RID: 48898 RVA: 0x002F3451 File Offset: 0x002F1651
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BF03 RID: 48899 RVA: 0x002F3460 File Offset: 0x002F1660
		public RacingBetsSeason __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002D54 RID: 11604
		// (get) Token: 0x0600BF04 RID: 48900 RVA: 0x002F3470 File Offset: 0x002F1670
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

		// Token: 0x17002D55 RID: 11605
		// (get) Token: 0x0600BF05 RID: 48901 RVA: 0x002F34AC File Offset: 0x002F16AC
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

		// Token: 0x17002D56 RID: 11606
		// (get) Token: 0x0600BF06 RID: 48902 RVA: 0x002F34E8 File Offset: 0x002F16E8
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

		// Token: 0x17002D57 RID: 11607
		// (get) Token: 0x0600BF07 RID: 48903 RVA: 0x002F3524 File Offset: 0x002F1724
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

		// Token: 0x0600BF08 RID: 48904 RVA: 0x002F3564 File Offset: 0x002F1764
		public int GroupMatches(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D58 RID: 11608
		// (get) Token: 0x0600BF09 RID: 48905 RVA: 0x002F35A4 File Offset: 0x002F17A4
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

		// Token: 0x0600BF0A RID: 48906 RVA: 0x002F35D0 File Offset: 0x002F17D0
		public Span<int> GetGroupMatchesBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x0600BF0B RID: 48907 RVA: 0x002F35E0 File Offset: 0x002F17E0
		public int[] GetGroupMatchesArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x0600BF0C RID: 48908 RVA: 0x002F35F8 File Offset: 0x002F17F8
		public int EliminateMatches(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D59 RID: 11609
		// (get) Token: 0x0600BF0D RID: 48909 RVA: 0x002F3638 File Offset: 0x002F1838
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

		// Token: 0x0600BF0E RID: 48910 RVA: 0x002F3664 File Offset: 0x002F1864
		public Span<int> GetEliminateMatchesBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x0600BF0F RID: 48911 RVA: 0x002F3674 File Offset: 0x002F1874
		public int[] GetEliminateMatchesArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x0600BF10 RID: 48912 RVA: 0x002F368C File Offset: 0x002F188C
		public int EliminateMatchesSecond(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D5A RID: 11610
		// (get) Token: 0x0600BF11 RID: 48913 RVA: 0x002F36CC File Offset: 0x002F18CC
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

		// Token: 0x0600BF12 RID: 48914 RVA: 0x002F36F8 File Offset: 0x002F18F8
		public Span<int> GetEliminateMatchesSecondBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600BF13 RID: 48915 RVA: 0x002F3708 File Offset: 0x002F1908
		public int[] GetEliminateMatchesSecondArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17002D5B RID: 11611
		// (get) Token: 0x0600BF14 RID: 48916 RVA: 0x002F3720 File Offset: 0x002F1920
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

		// Token: 0x17002D5C RID: 11612
		// (get) Token: 0x0600BF15 RID: 48917 RVA: 0x002F3760 File Offset: 0x002F1960
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

		// Token: 0x17002D5D RID: 11613
		// (get) Token: 0x0600BF16 RID: 48918 RVA: 0x002F37A0 File Offset: 0x002F19A0
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

		// Token: 0x0600BF17 RID: 48919 RVA: 0x002F37E0 File Offset: 0x002F19E0
		public int OddsUpdate(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17002D5E RID: 11614
		// (get) Token: 0x0600BF18 RID: 48920 RVA: 0x002F3820 File Offset: 0x002F1A20
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

		// Token: 0x0600BF19 RID: 48921 RVA: 0x002F384C File Offset: 0x002F1A4C
		public Span<int> GetOddsUpdateBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600BF1A RID: 48922 RVA: 0x002F385C File Offset: 0x002F1A5C
		public int[] GetOddsUpdateArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x17002D5F RID: 11615
		// (get) Token: 0x0600BF1B RID: 48923 RVA: 0x002F3874 File Offset: 0x002F1A74
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

		// Token: 0x17002D60 RID: 11616
		// (get) Token: 0x0600BF1C RID: 48924 RVA: 0x002F38B4 File Offset: 0x002F1AB4
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

		// Token: 0x17002D61 RID: 11617
		// (get) Token: 0x0600BF1D RID: 48925 RVA: 0x002F38F4 File Offset: 0x002F1AF4
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

		// Token: 0x17002D62 RID: 11618
		// (get) Token: 0x0600BF1E RID: 48926 RVA: 0x002F3934 File Offset: 0x002F1B34
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

		// Token: 0x17002D63 RID: 11619
		// (get) Token: 0x0600BF1F RID: 48927 RVA: 0x002F3974 File Offset: 0x002F1B74
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

		// Token: 0x17002D64 RID: 11620
		// (get) Token: 0x0600BF20 RID: 48928 RVA: 0x002F39B4 File Offset: 0x002F1BB4
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

		// Token: 0x17002D65 RID: 11621
		// (get) Token: 0x0600BF21 RID: 48929 RVA: 0x002F39F4 File Offset: 0x002F1BF4
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

		// Token: 0x17002D66 RID: 11622
		// (get) Token: 0x0600BF22 RID: 48930 RVA: 0x002F3A34 File Offset: 0x002F1C34
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

		// Token: 0x0600BF23 RID: 48931 RVA: 0x002F3A71 File Offset: 0x002F1C71
		[NullableContext(1)]
		public int[] EliminateMatches()
		{
			return this.GetEliminateMatchesArray();
		}

		// Token: 0x0600BF24 RID: 48932 RVA: 0x002F3A79 File Offset: 0x002F1C79
		[NullableContext(1)]
		public IEnumerable<int> EliminateMatchesIter()
		{
			RacingBetsSeason.<EliminateMatchesIter>d__59 <EliminateMatchesIter>d__ = new RacingBetsSeason.<EliminateMatchesIter>d__59(-2);
			<EliminateMatchesIter>d__.<>3__<>4__this = this;
			return <EliminateMatchesIter>d__;
		}

		// Token: 0x0600BF25 RID: 48933 RVA: 0x002F3A8E File Offset: 0x002F1C8E
		[NullableContext(1)]
		public int[] EliminateMatchesSecond()
		{
			return this.GetEliminateMatchesSecondArray();
		}

		// Token: 0x0600BF26 RID: 48934 RVA: 0x002F3A96 File Offset: 0x002F1C96
		[NullableContext(1)]
		public IEnumerable<int> EliminateMatchesSecondIter()
		{
			RacingBetsSeason.<EliminateMatchesSecondIter>d__61 <EliminateMatchesSecondIter>d__ = new RacingBetsSeason.<EliminateMatchesSecondIter>d__61(-2);
			<EliminateMatchesSecondIter>d__.<>3__<>4__this = this;
			return <EliminateMatchesSecondIter>d__;
		}

		// Token: 0x0600BF27 RID: 48935 RVA: 0x002F3AAB File Offset: 0x002F1CAB
		[NullableContext(1)]
		public int[] GroupMatches()
		{
			return this.GetGroupMatchesArray();
		}

		// Token: 0x0600BF28 RID: 48936 RVA: 0x002F3AB3 File Offset: 0x002F1CB3
		[NullableContext(1)]
		public IEnumerable<int> GroupMatchesIter()
		{
			RacingBetsSeason.<GroupMatchesIter>d__63 <GroupMatchesIter>d__ = new RacingBetsSeason.<GroupMatchesIter>d__63(-2);
			<GroupMatchesIter>d__.<>3__<>4__this = this;
			return <GroupMatchesIter>d__;
		}

		// Token: 0x0600BF29 RID: 48937 RVA: 0x002F3AC8 File Offset: 0x002F1CC8
		[NullableContext(1)]
		public int[] OddsUpdate()
		{
			return this.GetOddsUpdateArray();
		}

		// Token: 0x0600BF2A RID: 48938 RVA: 0x002F3AD0 File Offset: 0x002F1CD0
		[NullableContext(1)]
		public IEnumerable<int> OddsUpdateIter()
		{
			RacingBetsSeason.<OddsUpdateIter>d__65 <OddsUpdateIter>d__ = new RacingBetsSeason.<OddsUpdateIter>d__65(-2);
			<OddsUpdateIter>d__.<>3__<>4__this = this;
			return <OddsUpdateIter>d__;
		}

		// Token: 0x04005649 RID: 22089
		private Table __p;
	}
}
