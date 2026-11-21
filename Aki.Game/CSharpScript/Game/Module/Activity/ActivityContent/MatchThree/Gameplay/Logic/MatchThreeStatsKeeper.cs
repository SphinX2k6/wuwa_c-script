using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x02005474 RID: 21620
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreeStatsKeeper : ISolvedSequencesConsumer
	{
		// Token: 0x17006858 RID: 26712
		// (get) Token: 0x06035AE7 RID: 219879 RVA: 0x00F00D18 File Offset: 0x00EFEF18
		// (set) Token: 0x06035AE8 RID: 219880 RVA: 0x00F00D20 File Offset: 0x00EFEF20
		public int BigSkillCount { get; private set; }

		// Token: 0x17006859 RID: 26713
		// (get) Token: 0x06035AE9 RID: 219881 RVA: 0x00F00D29 File Offset: 0x00EFEF29
		// (set) Token: 0x06035AEA RID: 219882 RVA: 0x00F00D31 File Offset: 0x00EFEF31
		public int SmallSkillCount { get; private set; }

		// Token: 0x1700685A RID: 26714
		// (get) Token: 0x06035AEB RID: 219883 RVA: 0x00F00D3A File Offset: 0x00EFEF3A
		// (set) Token: 0x06035AEC RID: 219884 RVA: 0x00F00D42 File Offset: 0x00EFEF42
		public int GeneratedBombCount { get; private set; }

		// Token: 0x1700685B RID: 26715
		// (get) Token: 0x06035AED RID: 219885 RVA: 0x00F00D4B File Offset: 0x00EFEF4B
		// (set) Token: 0x06035AEE RID: 219886 RVA: 0x00F00D53 File Offset: 0x00EFEF53
		public int GeneratedCrossCount { get; private set; }

		// Token: 0x1700685C RID: 26716
		// (get) Token: 0x06035AEF RID: 219887 RVA: 0x00F00D5C File Offset: 0x00EFEF5C
		// (set) Token: 0x06035AF0 RID: 219888 RVA: 0x00F00D64 File Offset: 0x00EFEF64
		public int GeneratedUltimateCount { get; private set; }

		// Token: 0x1700685D RID: 26717
		// (get) Token: 0x06035AF1 RID: 219889 RVA: 0x00F00D6D File Offset: 0x00EFEF6D
		// (set) Token: 0x06035AF2 RID: 219890 RVA: 0x00F00D75 File Offset: 0x00EFEF75
		public int ClearedBombCount { get; private set; }

		// Token: 0x1700685E RID: 26718
		// (get) Token: 0x06035AF3 RID: 219891 RVA: 0x00F00D7E File Offset: 0x00EFEF7E
		// (set) Token: 0x06035AF4 RID: 219892 RVA: 0x00F00D86 File Offset: 0x00EFEF86
		public int ClearedCrossCount { get; private set; }

		// Token: 0x1700685F RID: 26719
		// (get) Token: 0x06035AF5 RID: 219893 RVA: 0x00F00D8F File Offset: 0x00EFEF8F
		// (set) Token: 0x06035AF6 RID: 219894 RVA: 0x00F00D97 File Offset: 0x00EFEF97
		public int ClearedUltimateCount { get; private set; }

		// Token: 0x17006860 RID: 26720
		// (get) Token: 0x06035AF7 RID: 219895 RVA: 0x00F00DA0 File Offset: 0x00EFEFA0
		// (set) Token: 0x06035AF8 RID: 219896 RVA: 0x00F00DA8 File Offset: 0x00EFEFA8
		public int MaxSegmentScore { get; private set; }

		// Token: 0x17006861 RID: 26721
		// (get) Token: 0x06035AF9 RID: 219897 RVA: 0x00F00DB1 File Offset: 0x00EFEFB1
		// (set) Token: 0x06035AFA RID: 219898 RVA: 0x00F00DB9 File Offset: 0x00EFEFB9
		public int HourglassTurnGain { get; private set; }

		// Token: 0x17006862 RID: 26722
		// (get) Token: 0x06035AFB RID: 219899 RVA: 0x00F00DC2 File Offset: 0x00EFEFC2
		public IReadOnlyList<int> RoundCountByGrade
		{
			get
			{
				return this.EnsureGradeRoundCounts();
			}
		}

		// Token: 0x06035AFC RID: 219900 RVA: 0x00F00DCC File Offset: 0x00EFEFCC
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

		// Token: 0x06035AFD RID: 219901 RVA: 0x00F00E00 File Offset: 0x00EFF000
		public void AddGeneratedBomb()
		{
			int generatedBombCount = this.GeneratedBombCount;
			this.GeneratedBombCount = generatedBombCount + 1;
		}

		// Token: 0x06035AFE RID: 219902 RVA: 0x00F00E20 File Offset: 0x00EFF020
		public void AddGeneratedCross()
		{
			int generatedCrossCount = this.GeneratedCrossCount;
			this.GeneratedCrossCount = generatedCrossCount + 1;
		}

		// Token: 0x06035AFF RID: 219903 RVA: 0x00F00E40 File Offset: 0x00EFF040
		public void AddGeneratedUltimate()
		{
			int generatedUltimateCount = this.GeneratedUltimateCount;
			this.GeneratedUltimateCount = generatedUltimateCount + 1;
		}

		// Token: 0x06035B00 RID: 219904 RVA: 0x00F00E60 File Offset: 0x00EFF060
		public void AddClearedBomb()
		{
			int clearedBombCount = this.ClearedBombCount;
			this.ClearedBombCount = clearedBombCount + 1;
		}

		// Token: 0x06035B01 RID: 219905 RVA: 0x00F00E80 File Offset: 0x00EFF080
		public void AddClearedCross()
		{
			int clearedCrossCount = this.ClearedCrossCount;
			this.ClearedCrossCount = clearedCrossCount + 1;
		}

		// Token: 0x06035B02 RID: 219906 RVA: 0x00F00EA0 File Offset: 0x00EFF0A0
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

		// Token: 0x06035B03 RID: 219907 RVA: 0x00F00F1C File Offset: 0x00EFF11C
		public void BeginTurn()
		{
			this.TurnScore = 0;
		}

		// Token: 0x06035B04 RID: 219908 RVA: 0x00F00F28 File Offset: 0x00EFF128
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

		// Token: 0x06035B05 RID: 219909 RVA: 0x00F00FFB File Offset: 0x00EFF1FB
		private int[] EnsureGradeRoundCounts()
		{
			if (this.GradeRoundCounts.Length == 0)
			{
				this.GradeRoundCounts = new int[MatchThreeConfig.Instance.ScoreGradeCount];
			}
			return this.GradeRoundCounts;
		}

		// Token: 0x06035B06 RID: 219910 RVA: 0x00F01024 File Offset: 0x00EFF224
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

		// Token: 0x0401C65D RID: 116317
		private int[] GradeRoundCounts = Array.Empty<int>();

		// Token: 0x0401C65E RID: 116318
		private int TurnScore;
	}
}
