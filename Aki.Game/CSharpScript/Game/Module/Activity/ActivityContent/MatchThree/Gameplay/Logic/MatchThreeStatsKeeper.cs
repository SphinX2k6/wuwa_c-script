using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x020064F6 RID: 25846
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeStatsKeeper : ISolvedSequencesConsumer
	{
		// Token: 0x170094F6 RID: 38134
		// (get) Token: 0x06040E23 RID: 265763 RVA: 0x00FB9CE8 File Offset: 0x00FB7EE8
		// (set) Token: 0x06040E24 RID: 265764 RVA: 0x00FB9CF0 File Offset: 0x00FB7EF0
		public int BigSkillCount { get; private set; }

		// Token: 0x170094F7 RID: 38135
		// (get) Token: 0x06040E25 RID: 265765 RVA: 0x00FB9CF9 File Offset: 0x00FB7EF9
		// (set) Token: 0x06040E26 RID: 265766 RVA: 0x00FB9D01 File Offset: 0x00FB7F01
		public int SmallSkillCount { get; private set; }

		// Token: 0x170094F8 RID: 38136
		// (get) Token: 0x06040E27 RID: 265767 RVA: 0x00FB9D0A File Offset: 0x00FB7F0A
		// (set) Token: 0x06040E28 RID: 265768 RVA: 0x00FB9D12 File Offset: 0x00FB7F12
		public int GeneratedBombCount { get; private set; }

		// Token: 0x170094F9 RID: 38137
		// (get) Token: 0x06040E29 RID: 265769 RVA: 0x00FB9D1B File Offset: 0x00FB7F1B
		// (set) Token: 0x06040E2A RID: 265770 RVA: 0x00FB9D23 File Offset: 0x00FB7F23
		public int GeneratedCrossCount { get; private set; }

		// Token: 0x170094FA RID: 38138
		// (get) Token: 0x06040E2B RID: 265771 RVA: 0x00FB9D2C File Offset: 0x00FB7F2C
		// (set) Token: 0x06040E2C RID: 265772 RVA: 0x00FB9D34 File Offset: 0x00FB7F34
		public int GeneratedUltimateCount { get; private set; }

		// Token: 0x170094FB RID: 38139
		// (get) Token: 0x06040E2D RID: 265773 RVA: 0x00FB9D3D File Offset: 0x00FB7F3D
		// (set) Token: 0x06040E2E RID: 265774 RVA: 0x00FB9D45 File Offset: 0x00FB7F45
		public int ClearedBombCount { get; private set; }

		// Token: 0x170094FC RID: 38140
		// (get) Token: 0x06040E2F RID: 265775 RVA: 0x00FB9D4E File Offset: 0x00FB7F4E
		// (set) Token: 0x06040E30 RID: 265776 RVA: 0x00FB9D56 File Offset: 0x00FB7F56
		public int ClearedCrossCount { get; private set; }

		// Token: 0x170094FD RID: 38141
		// (get) Token: 0x06040E31 RID: 265777 RVA: 0x00FB9D5F File Offset: 0x00FB7F5F
		// (set) Token: 0x06040E32 RID: 265778 RVA: 0x00FB9D67 File Offset: 0x00FB7F67
		public int ClearedUltimateCount { get; private set; }

		// Token: 0x170094FE RID: 38142
		// (get) Token: 0x06040E33 RID: 265779 RVA: 0x00FB9D70 File Offset: 0x00FB7F70
		// (set) Token: 0x06040E34 RID: 265780 RVA: 0x00FB9D78 File Offset: 0x00FB7F78
		public int MaxSegmentScore { get; private set; }

		// Token: 0x170094FF RID: 38143
		// (get) Token: 0x06040E35 RID: 265781 RVA: 0x00FB9D81 File Offset: 0x00FB7F81
		// (set) Token: 0x06040E36 RID: 265782 RVA: 0x00FB9D89 File Offset: 0x00FB7F89
		public int HourglassTurnGain { get; private set; }

		// Token: 0x17009500 RID: 38144
		// (get) Token: 0x06040E37 RID: 265783 RVA: 0x00FB9D92 File Offset: 0x00FB7F92
		public IReadOnlyList<int> RoundCountByGrade
		{
			get
			{
				return this.EnsureGradeRoundCounts();
			}
		}

		// Token: 0x06040E38 RID: 265784 RVA: 0x00FB9D9C File Offset: 0x00FB7F9C
		public void AddSkillCast(bool isUltimate)
		{
			int num;
			if (isUltimate)
			{
				num = this.BigSkillCount;
				this.BigSkillCount = num + 1;
				return;
			}
			num = this.SmallSkillCount;
			this.SmallSkillCount = num + 1;
		}

		// Token: 0x06040E39 RID: 265785 RVA: 0x00FB9DD0 File Offset: 0x00FB7FD0
		public void AddGeneratedBomb()
		{
			int generatedBombCount = this.GeneratedBombCount;
			this.GeneratedBombCount = generatedBombCount + 1;
		}

		// Token: 0x06040E3A RID: 265786 RVA: 0x00FB9DF0 File Offset: 0x00FB7FF0
		public void AddGeneratedCross()
		{
			int generatedCrossCount = this.GeneratedCrossCount;
			this.GeneratedCrossCount = generatedCrossCount + 1;
		}

		// Token: 0x06040E3B RID: 265787 RVA: 0x00FB9E10 File Offset: 0x00FB8010
		public void AddGeneratedUltimate()
		{
			int generatedUltimateCount = this.GeneratedUltimateCount;
			this.GeneratedUltimateCount = generatedUltimateCount + 1;
		}

		// Token: 0x06040E3C RID: 265788 RVA: 0x00FB9E30 File Offset: 0x00FB8030
		public void AddClearedBomb()
		{
			int clearedBombCount = this.ClearedBombCount;
			this.ClearedBombCount = clearedBombCount + 1;
		}

		// Token: 0x06040E3D RID: 265789 RVA: 0x00FB9E50 File Offset: 0x00FB8050
		public void AddClearedCross()
		{
			int clearedCrossCount = this.ClearedCrossCount;
			this.ClearedCrossCount = clearedCrossCount + 1;
		}

		// Token: 0x06040E3E RID: 265790 RVA: 0x00FB9E70 File Offset: 0x00FB8070
		public void OnSequencesSolved(SolvedData solved)
		{
			this.MaxSegmentScore = Math.Max(this.MaxSegmentScore, solved.SegmentScore);
			this.HourglassTurnGain += solved.SegmentTurnGain;
			this.TurnScore += solved.SegmentScore;
			List<EPieceType> clearedThisSegment = solved.ClearedThisSegment;
			for (int i = 0; i < clearedThisSegment.Count; i++)
			{
				if (clearedThisSegment[i] == EPieceType.Ultimate)
				{
					int clearedUltimateCount = this.ClearedUltimateCount;
					this.ClearedUltimateCount = clearedUltimateCount + 1;
				}
			}
		}

		// Token: 0x06040E3F RID: 265791 RVA: 0x00FB9EEC File Offset: 0x00FB80EC
		public void BeginTurn()
		{
			this.TurnScore = 0;
		}

		// Token: 0x06040E40 RID: 265792 RVA: 0x00FB9EF8 File Offset: 0x00FB80F8
		public unsafe void CountTurnGrade()
		{
			if (this.TurnScore <= 0)
			{
				return;
			}
			int num;
			MatchThreeConfig.Instance.GetCommentConfig(this.TurnScore, out num);
			int[] array = this.EnsureGradeRoundCounts();
			int num2 = num - 1;
			if (num2 < 0 || num2 >= array.Length)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.MatchThree;
				ELogAuthor author = ELogAuthor.CB;
				string message = "[CountTurnGrade] 档位越界，本回合不计入";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("GradeLevel", num);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("TurnScore", this.TurnScore);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("档数", array.Length);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				return;
			}
			array[num2]++;
		}

		// Token: 0x06040E41 RID: 265793 RVA: 0x00FB9FCB File Offset: 0x00FB81CB
		private int[] EnsureGradeRoundCounts()
		{
			if (this.GradeRoundCounts.Length == 0)
			{
				this.GradeRoundCounts = new int[MatchThreeConfig.Instance.ScoreGradeCount];
			}
			return this.GradeRoundCounts;
		}

		// Token: 0x06040E42 RID: 265794 RVA: 0x00FB9FF4 File Offset: 0x00FB81F4
		public void Reset()
		{
			this.BigSkillCount = 0;
			this.SmallSkillCount = 0;
			this.GeneratedBombCount = 0;
			this.GeneratedCrossCount = 0;
			this.GeneratedUltimateCount = 0;
			this.ClearedBombCount = 0;
			this.ClearedCrossCount = 0;
			this.ClearedUltimateCount = 0;
			this.MaxSegmentScore = 0;
			this.HourglassTurnGain = 0;
			this.TurnScore = 0;
			this.GradeRoundCounts = Array.Empty<int>();
		}

		// Token: 0x04021D2C RID: 138540
		private int[] GradeRoundCounts = Array.Empty<int>();

		// Token: 0x04021D2D RID: 138541
		private int TurnScore;
	}
}
