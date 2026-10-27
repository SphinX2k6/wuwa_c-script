using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FED RID: 24557
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisScoreData
	{
		// Token: 0x0603E388 RID: 254856 RVA: 0x00F059E4 File Offset: 0x00F03BE4
		public void Reset()
		{
			this.CurrentScore = 0;
			this.LastClearTurn = -999;
			this.ComboCount = 0;
			this.MaxComboCount = 0;
		}

		// Token: 0x0603E389 RID: 254857 RVA: 0x00F05A08 File Offset: 0x00F03C08
		public int Calculate(int linesCleared, bool isBoardEmpty, int currentTurn)
		{
			if (linesCleared <= 0)
			{
				if (currentTurn - this.LastClearTurn >= 2)
				{
					this.ComboCount = 0;
				}
				return 0;
			}
			TetrisSetting value = ActivityTetrisConfig.Instance.GetSetting("BasicScore").Value;
			if (linesCleared > value.BasicScoreLength)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Log;
				ELogAuthor author = ELogAuthor.SWC;
				string message = "消除行数没有对应的分数";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("行数", linesCleared);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			int num = value.BasicScore(linesCleared - 1);
			if (isBoardEmpty)
			{
				num += ActivityTetrisConfig.Instance.GetSetting("AllClear").Value.AllClear;
			}
			if (currentTurn - this.LastClearTurn < 2)
			{
				this.ComboCount++;
			}
			else
			{
				this.ComboCount = 1;
			}
			this.ComboCount = Math.Min(ActivityTetrisConfig.Instance.GetSetting("ComboAddation").Value.ComboAddationLength, this.ComboCount);
			if (this.ComboCount > this.MaxComboCount)
			{
				this.MaxComboCount = this.ComboCount;
			}
			int num2 = 100 + ActivityTetrisConfig.Instance.GetSetting("ComboAddation").Value.ComboAddation(this.ComboCount - 1);
			num = (int)Math.Floor((double)(num * num2) / 100.0);
			this.LastClearTurn = currentTurn;
			int currentScore = this.CurrentScore;
			this.CurrentScore = Math.Min(this.CurrentScore + num, TetrisScoreData.MaxScore);
			return this.CurrentScore - currentScore;
		}

		// Token: 0x0603E38A RID: 254858 RVA: 0x00F05B8D File Offset: 0x00F03D8D
		public int GetScore()
		{
			return this.CurrentScore;
		}

		// Token: 0x0603E38B RID: 254859 RVA: 0x00F05B95 File Offset: 0x00F03D95
		public void AddScore(int score)
		{
			this.CurrentScore = Math.Min(this.CurrentScore + score, TetrisScoreData.MaxScore);
		}

		// Token: 0x0603E38C RID: 254860 RVA: 0x00F05BAF File Offset: 0x00F03DAF
		public int GetComboCount()
		{
			return this.ComboCount;
		}

		// Token: 0x0603E38D RID: 254861 RVA: 0x00F05BB7 File Offset: 0x00F03DB7
		public void SetComboCount(int count, int roundIndex)
		{
			this.ComboCount = count;
			this.LastClearTurn = roundIndex;
			if (this.ComboCount > this.MaxComboCount)
			{
				this.MaxComboCount = this.ComboCount;
			}
		}

		// Token: 0x0603E38E RID: 254862 RVA: 0x00F05BE1 File Offset: 0x00F03DE1
		public int GetMaxComboCount()
		{
			return this.MaxComboCount;
		}

		// Token: 0x0603E38F RID: 254863 RVA: 0x00F05BE9 File Offset: 0x00F03DE9
		public ITetrisScoreSnapshot CreateSnapshot()
		{
			return new TetrisScoreSnapshot
			{
				CurrentScore = this.CurrentScore,
				LastClearTurn = this.LastClearTurn,
				ComboCount = this.ComboCount,
				MaxComboCount = this.MaxComboCount
			};
		}

		// Token: 0x0603E390 RID: 254864 RVA: 0x00F05C20 File Offset: 0x00F03E20
		public void RestoreFromSnapshot(ITetrisScoreSnapshot snapshot)
		{
			this.CurrentScore = Math.Min(snapshot.CurrentScore, TetrisScoreData.MaxScore);
			this.LastClearTurn = snapshot.LastClearTurn;
			this.ComboCount = snapshot.ComboCount;
			this.MaxComboCount = snapshot.MaxComboCount;
		}

		// Token: 0x04020802 RID: 133122
		private static readonly int MaxScore = 999999;

		// Token: 0x04020803 RID: 133123
		private int CurrentScore;

		// Token: 0x04020804 RID: 133124
		private int LastClearTurn = -999;

		// Token: 0x04020805 RID: 133125
		private int ComboCount;

		// Token: 0x04020806 RID: 133126
		private int MaxComboCount;
	}
}
