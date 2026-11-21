using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02004F70 RID: 20336
	public class TotalTopUpProgressData
	{
		// Token: 0x060330AD RID: 209069 RVA: 0x00E4E2F2 File Offset: 0x00E4C4F2
		public void Reset()
		{
			this.Score = 0;
			this.Level.Clear();
		}

		// Token: 0x060330AE RID: 209070 RVA: 0x00E4E306 File Offset: 0x00E4C506
		public void PushLevel(int level)
		{
			this.Level.Add(level);
		}

		// Token: 0x060330AF RID: 209071 RVA: 0x00E4E314 File Offset: 0x00E4C514
		public void SortLevel()
		{
			this.Level.Sort((int a, int b) => a - b);
			if (this.Level.Count > 0)
			{
				this.MaxScoreByLevel = this.Level[this.Level.Count - 1];
			}
		}

		// Token: 0x060330B0 RID: 209072 RVA: 0x00E4E377 File Offset: 0x00E4C577
		public void SetScore(int score)
		{
			this.Score = score;
		}

		// Token: 0x170063B5 RID: 25525
		// (get) Token: 0x060330B1 RID: 209073 RVA: 0x00E4E380 File Offset: 0x00E4C580
		public int CurrentScore
		{
			get
			{
				return Math.Min(this.Score, this.MaxScoreByLevel);
			}
		}

		// Token: 0x170063B6 RID: 25526
		// (get) Token: 0x060330B2 RID: 209074 RVA: 0x00E4E394 File Offset: 0x00E4C594
		public int NextScore
		{
			get
			{
				foreach (int num in this.Level)
				{
					if (num > this.CurrentScore)
					{
						return num;
					}
				}
				if (this.Level.Count <= 0)
				{
					return 0;
				}
				return this.Level[this.Level.Count - 1];
			}
		}

		// Token: 0x0401B163 RID: 110947
		public int Score;

		// Token: 0x0401B164 RID: 110948
		[Nullable(1)]
		public List<int> Level = new List<int>();

		// Token: 0x0401B165 RID: 110949
		private int MaxScoreByLevel;
	}
}
