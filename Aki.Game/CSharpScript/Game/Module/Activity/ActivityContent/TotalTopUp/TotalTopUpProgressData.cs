using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.TotalTopUp
{
	// Token: 0x02005F89 RID: 24457
	public class TotalTopUpProgressData
	{
		// Token: 0x0603E113 RID: 254227 RVA: 0x00EFC63A File Offset: 0x00EFA83A
		public void Reset()
		{
			this.Score = 0;
			this.Level.Clear();
		}

		// Token: 0x0603E114 RID: 254228 RVA: 0x00EFC64E File Offset: 0x00EFA84E
		public void PushLevel(int level)
		{
			this.Level.Add(level);
		}

		// Token: 0x0603E115 RID: 254229 RVA: 0x00EFC65C File Offset: 0x00EFA85C
		public void SortLevel()
		{
			this.Level.Sort((int a, int b) => a - b);
			if (this.Level.Count > 0)
			{
				this.MaxScoreByLevel = this.Level[this.Level.Count - 1];
			}
		}

		// Token: 0x0603E116 RID: 254230 RVA: 0x00EFC6BF File Offset: 0x00EFA8BF
		public void SetScore(int score)
		{
			this.Score = score;
		}

		// Token: 0x17008FE3 RID: 36835
		// (get) Token: 0x0603E117 RID: 254231 RVA: 0x00EFC6C8 File Offset: 0x00EFA8C8
		public int CurrentScore
		{
			get
			{
				return Math.Min(this.Score, this.MaxScoreByLevel);
			}
		}

		// Token: 0x17008FE4 RID: 36836
		// (get) Token: 0x0603E118 RID: 254232 RVA: 0x00EFC6DC File Offset: 0x00EFA8DC
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

		// Token: 0x04020691 RID: 132753
		public int Score;

		// Token: 0x04020692 RID: 132754
		[Nullable(1)]
		public List<int> Level = new List<int>();

		// Token: 0x04020693 RID: 132755
		private int MaxScoreByLevel;
	}
}
