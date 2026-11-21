using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Game.Module.Activity.ActivityContent.Tetris.Activity;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FB6 RID: 12214
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisScoreData
	{
		// Token: 0x0601CFDD RID: 118749 RVA: 0x008DABD5 File Offset: 0x008D8DD5
		public void Reset()
		{
			this.CurrentScore = 0;
			this.LastClearTurn = -999;
			this.ComboCount = 0;
			this.MaxComboCount = 0;
		}

		// Token: 0x0601CFDE RID: 118750 RVA: 0x008DABF8 File Offset: 0x008D8DF8
		public int Calculate(TetrisClearInfo clearInfo, int currentTurn)
		{
			int num;
			if (!clearInfo.IsBombExplosion)
			{
				if (clearInfo.Lines <= 0)
				{
					if (currentTurn - this.LastClearTurn >= 2)
					{
						this.ComboCount = 0;
					}
					return 0;
				}
				TetrisSetting value = ActivityTetrisConfig.Instance.GetSetting("BasicScore").Value;
				if (clearInfo.Lines > value.BasicScoreLength)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Log;
					ELogAuthor author = ELogAuthor.SWC;
					string message = "消除行数没有对应的分数";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("行数", clearInfo.Lines);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return 0;
				}
				num = value.BasicScore(clearInfo.Lines - 1);
				if (clearInfo.IsBoardAllCleared)
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
				num = num * num2 / 100;
				this.LastClearTurn = currentTurn;
			}
			else
			{
				TetrisSetting? setting = ActivityTetrisConfig.Instance.GetSetting("BombScore");
				if (setting != null)
				{
					TetrisSetting valueOrDefault = setting.GetValueOrDefault();
					num = 0;
					for (int i = Math.Max(clearInfo.CumulateBombCount - clearInfo.BombCount, 0); i < clearInfo.CumulateBombCount; i++)
					{
						num += valueOrDefault.BombScore(Math.Min(i, valueOrDefault.BombScoreLength - 1));
					}
					num += clearInfo.ClearedPositions.Length * 25;
					if (clearInfo.IsBoardAllCleared)
					{
						setting = ActivityTetrisConfig.Instance.GetSetting("AllClear");
						if (setting != null)
						{
							num += setting.GetValueOrDefault().AllClear;
						}
					}
				}
				else
				{
					num = 0;
				}
			}
			int currentScore = this.CurrentScore;
			this.CurrentScore = Math.Clamp(this.CurrentScore + num, 0, 999999);
			return this.CurrentScore - currentScore;
		}

		// Token: 0x0601CFDF RID: 118751 RVA: 0x008DAE56 File Offset: 0x008D9056
		public int GetScore()
		{
			return this.CurrentScore;
		}

		// Token: 0x0601CFE0 RID: 118752 RVA: 0x008DAE5E File Offset: 0x008D905E
		public void AddScore(int score)
		{
			this.CurrentScore = Math.Clamp(this.CurrentScore + score, 0, 999999);
		}

		// Token: 0x0601CFE1 RID: 118753 RVA: 0x008DAE79 File Offset: 0x008D9079
		public int GetComboCount()
		{
			return this.ComboCount;
		}

		// Token: 0x0601CFE2 RID: 118754 RVA: 0x008DAE81 File Offset: 0x008D9081
		public void SetComboCount(int count, int roundIndex)
		{
			this.ComboCount = count;
			this.LastClearTurn = roundIndex;
			if (this.ComboCount > this.MaxComboCount)
			{
				this.MaxComboCount = this.ComboCount;
			}
		}

		// Token: 0x0601CFE3 RID: 118755 RVA: 0x008DAEAB File Offset: 0x008D90AB
		public int GetMaxComboCount()
		{
			return this.MaxComboCount;
		}

		// Token: 0x0601CFE4 RID: 118756 RVA: 0x008DAEB3 File Offset: 0x008D90B3
		public TetrisScoreSnapshot CreateSnapshot()
		{
			return new TetrisScoreSnapshot
			{
				CurrentScore = this.CurrentScore,
				LastClearTurn = this.LastClearTurn,
				ComboCount = this.ComboCount,
				MaxComboCount = this.MaxComboCount
			};
		}

		// Token: 0x0601CFE5 RID: 118757 RVA: 0x008DAEEA File Offset: 0x008D90EA
		public void RestoreFromSnapshot(in TetrisScoreSnapshot snapshot)
		{
			this.CurrentScore = Math.Min(snapshot.CurrentScore, 999999);
			this.LastClearTurn = snapshot.LastClearTurn;
			this.ComboCount = snapshot.ComboCount;
			this.MaxComboCount = snapshot.MaxComboCount;
		}

		// Token: 0x0400F468 RID: 62568
		private const int MaxScore = 999999;

		// Token: 0x0400F469 RID: 62569
		private int CurrentScore;

		// Token: 0x0400F46A RID: 62570
		private int LastClearTurn = -999;

		// Token: 0x0400F46B RID: 62571
		private int ComboCount;

		// Token: 0x0400F46C RID: 62572
		private int MaxComboCount;
	}
}
