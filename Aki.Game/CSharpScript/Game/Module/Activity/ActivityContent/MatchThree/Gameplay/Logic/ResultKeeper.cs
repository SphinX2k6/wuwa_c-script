using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x02005476 RID: 21622
	public class ResultKeeper : ISolvedSequencesConsumer
	{
		// Token: 0x17006863 RID: 26723
		// (get) Token: 0x06035B0C RID: 219916 RVA: 0x00F0141B File Offset: 0x00EFF61B
		// (set) Token: 0x06035B0D RID: 219917 RVA: 0x00F01423 File Offset: 0x00EFF623
		public int Score { get; private set; }

		// Token: 0x06035B0E RID: 219918 RVA: 0x00F0142C File Offset: 0x00EFF62C
		public int ClearedCountOf(EPieceType type)
		{
			return this.ClearedCounts.GetValueOrDefault(type, 0);
		}

		// Token: 0x06035B0F RID: 219919 RVA: 0x00F0143C File Offset: 0x00EFF63C
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

		// Token: 0x06035B10 RID: 219920 RVA: 0x00F0149B File Offset: 0x00EFF69B
		public void Reset()
		{
			this.Score = 0;
			this.ClearedCounts.Clear();
		}

		// Token: 0x0401C669 RID: 116329
		[Nullable(1)]
		private readonly Dictionary<EPieceType, int> ClearedCounts = new Dictionary<EPieceType, int>();
	}
}
