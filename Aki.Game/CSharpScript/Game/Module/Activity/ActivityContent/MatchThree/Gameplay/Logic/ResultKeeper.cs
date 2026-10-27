using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x020064F8 RID: 25848
	public class ResultKeeper : ISolvedSequencesConsumer
	{
		// Token: 0x17009501 RID: 38145
		// (get) Token: 0x06040E48 RID: 265800 RVA: 0x00FBA3EB File Offset: 0x00FB85EB
		// (set) Token: 0x06040E49 RID: 265801 RVA: 0x00FBA3F3 File Offset: 0x00FB85F3
		public int Score { get; private set; }

		// Token: 0x06040E4A RID: 265802 RVA: 0x00FBA3FC File Offset: 0x00FB85FC
		public int ClearedCountOf(EPieceType type)
		{
			return this.ClearedCounts.GetValueOrDefault(type, 0);
		}

		// Token: 0x06040E4B RID: 265803 RVA: 0x00FBA40C File Offset: 0x00FB860C
		[NullableContext(1)]
		public void OnSequencesSolved(SolvedData solved)
		{
			this.Score += solved.SegmentScore;
			List<EPieceType> clearedThisSegment = solved.ClearedThisSegment;
			for (int i = 0; i < clearedThisSegment.Count; i++)
			{
				this.ClearedCounts[clearedThisSegment[i]] = this.ClearedCounts.GetValueOrDefault(clearedThisSegment[i], 0) + 1;
			}
		}

		// Token: 0x06040E4C RID: 265804 RVA: 0x00FBA46B File Offset: 0x00FB866B
		public void Reset()
		{
			this.Score = 0;
			this.ClearedCounts.Clear();
		}

		// Token: 0x04021D38 RID: 138552
		[Nullable(1)]
		private readonly Dictionary<EPieceType, int> ClearedCounts = new Dictionary<EPieceType, int>();
	}
}
