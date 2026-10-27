using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.AIGearStrategy;

namespace CSharpScript.Game.LevelGamePlay.Chess.TicTacToe
{
	// Token: 0x02006F39 RID: 28473
	[NullableContext(1)]
	[Nullable(0)]
	public class TicTacToeAiController : TicTacToeController
	{
		// Token: 0x06045454 RID: 283732 RVA: 0x011237C4 File Offset: 0x011219C4
		public void InitAi(TicTacToeBoard board, ETicTacToeBoardContent camp, ETicTacToeBoardContent playerCamp)
		{
			base.Init(board, camp);
			this.PlayerCamp = playerCamp;
			this.ChessBoard.GetBoardInfo(this.BoardInfo);
			this.ChessBoard.GetNextPoints(this.NextPoints);
			this.ChessBoard.GetPrePoints(this.PrePoints);
			this.ChessBoard.GetCirclePoints(this.CirclePoints);
			for (int i = 0; i < 20; i++)
			{
				this.IterationInfos.Add(new int[0]);
			}
			for (int j = 0; j < 5; j++)
			{
				this.PlayerIterationInfos.Add(new int[0]);
			}
		}

		// Token: 0x06045455 RID: 283733 RVA: 0x01123860 File Offset: 0x01121A60
		public unsafe override bool MovePiece(int newIndex)
		{
			int selectIndex = this.SelectIndex;
			bool flag = base.MovePiece(newIndex);
			if (!flag)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.LevelPlay;
				ELogAuthor author = ELogAuthor.WLJ;
				string message = "[TicTacToe]AI Move Failed";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("oldIndex", selectIndex);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("newIndex", newIndex);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			return flag;
		}

		// Token: 0x06045456 RID: 283734 RVA: 0x011238DC File Offset: 0x01121ADC
		public override void OnStartRound()
		{
			this.ChessBoard.GetBoardInfo(this.BoardInfo);
			int num = -1;
			int num2 = -99999;
			int num3 = -1;
			for (int i = 0; i < this.BoardInfo.Count; i++)
			{
				if (this.BoardInfo[i] == (int)this.SelfCamp)
				{
					ValueTuple<int, int> valueTuple = this.CalculateMoveWeight(i);
					if (valueTuple.Item1 > num2)
					{
						num = i;
						num2 = valueTuple.Item1;
						num3 = valueTuple.Item2;
					}
				}
			}
			if (num > -1)
			{
				int item = this.CalculateHistoryOperateValue(num, num3);
				this.HistoryOperates.Add(item);
				if (this.HistoryOperates.Count > this.HistoryQueueMemberCount)
				{
					this.HistoryOperates.RemoveAt(0);
				}
				this.SelectIndex = num;
				this.MovePiece(num3);
			}
			this.LostWeight *= this.RoundDecay;
		}

		// Token: 0x06045457 RID: 283735 RVA: 0x011239AF File Offset: 0x01121BAF
		public override void OnStartGame()
		{
			base.OnStartGame();
			this.HistoryOperates.Clear();
			this.LostWeight = this.SourceLostWeight;
		}

		// Token: 0x06045458 RID: 283736 RVA: 0x011239CE File Offset: 0x01121BCE
		private int CalculateHistoryOperateValue(int index, int moveTo)
		{
			return index * 100 + moveTo;
		}

		// Token: 0x06045459 RID: 283737 RVA: 0x011239D8 File Offset: 0x01121BD8
		[NullableContext(0)]
		private ValueTuple<int, int> CalculateMoveWeight(int index)
		{
			int num = -99999;
			int item = -1;
			IReadOnlyList<int> noneNeighbors = this.ChessBoard.GetNoneNeighbors(index);
			if (noneNeighbors.Count < 1)
			{
				return new ValueTuple<int, int>(num, item);
			}
			foreach (int num2 in noneNeighbors)
			{
				this.BoardInfo[index] = 0;
				this.BoardInfo[num2] = (int)this.SelfCamp;
				this.BoardInfoCopy.Clear();
				foreach (int item2 in this.BoardInfo)
				{
					this.BoardInfoCopy.Add(item2);
				}
				if (this.CheckGameOver(this.BoardInfoCopy, num2))
				{
					return new ValueTuple<int, int>(this.SourceWinWeight * this.WinWeight, num2);
				}
				int num3 = Math.Min(20, this.IterationCount) - 1;
				int item3 = this.CalculateHistoryOperateValue(index, num2);
				int num4 = this.HistoryOperates.Contains(item3) ? this.RepeatOperationWeight : 0;
				int num5 = this.CalculateWinWeight(this.BoardInfoCopy, this.SelfCamp) + this.IterationCalculateWeight(this.PlayerCamp, this.BoardInfoCopy, num3, num3, false, this.SelfCamp, this.PlayerCamp) + num4;
				if (num5 > num)
				{
					num = num5;
					item = num2;
				}
				this.BoardInfo[index] = (int)this.SelfCamp;
				this.BoardInfo[num2] = 0;
			}
			return new ValueTuple<int, int>(num, item);
		}

		// Token: 0x0604545A RID: 283738 RVA: 0x01123BA4 File Offset: 0x01121DA4
		protected bool CheckGameOver(List<int> infos, int startIndex)
		{
			int num = infos[startIndex];
			if (num == 0)
			{
				return false;
			}
			int count = this.CirclePoints.Count;
			int num2 = this.CirclePoints.Count / 2;
			if (startIndex != this.ChessBoard.CenterIndex)
			{
				int num3 = this.ChessBoard.WinLineCount - 1;
				int num4 = this.NextPoints[startIndex];
				int num5 = this.NextPoints[startIndex];
				while (num3-- > 0)
				{
					if (infos[num5] != num)
					{
						num3++;
						break;
					}
					num5 = this.NextPoints[num5];
					if (num5 == num4)
					{
						break;
					}
				}
				int num6 = this.NextPoints[startIndex];
				int num7 = this.PrePoints[startIndex];
				while (num3-- > 0)
				{
					if (infos[num7] != num)
					{
						num3++;
						break;
					}
					num7 = this.PrePoints[num7];
					if (num7 == num6)
					{
						break;
					}
				}
				if (num3 < 1)
				{
					return true;
				}
				if (num == infos[this.ChessBoard.CenterIndex])
				{
					int num8 = this.CirclePoints.IndexOf(startIndex);
					if (num8 > -1)
					{
						int index = (num8 + num2) % count;
						if (num == infos[this.CirclePoints[index]])
						{
							return true;
						}
					}
				}
			}
			else
			{
				for (int i = 0; i < num2; i++)
				{
					int index2 = (i + num2) % count;
					if (num == infos[this.CirclePoints[i]] && num == infos[this.CirclePoints[index2]])
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x0604545B RID: 283739 RVA: 0x01123D24 File Offset: 0x01121F24
		private int IterationCalculateWeight(ETicTacToeBoardContent camp, List<int> infos, int iterationCount, int startInteractionCount, bool isPlayerInteraction, ETicTacToeBoardContent selfCamp, ETicTacToeBoardContent targetCamp)
		{
			if (iterationCount < 0)
			{
				return 0;
			}
			float num = 1f;
			for (int i = startInteractionCount; i > iterationCount; i--)
			{
				num *= this.IterationDecay;
			}
			int iterationCount2 = iterationCount - 1;
			if (camp == selfCamp)
			{
				int num2 = -99999;
				for (int j = 0; j < infos.Count; j++)
				{
					if (infos[j] == (int)camp)
					{
						foreach (int num3 in this.ChessBoard.GetNoneNeighborsWithCustomInfos(infos, j))
						{
							if (infos[num3] != 0)
							{
								return -1;
							}
							infos[j] = 0;
							infos[num3] = (int)camp;
							if (this.CheckGameOver(infos, num3))
							{
								return (int)((float)(this.SourceWinWeight * this.WinWeight) * num);
							}
							int[] array;
							if (!isPlayerInteraction)
							{
								array = this.IterationInfos[startInteractionCount - iterationCount];
							}
							else
							{
								array = this.PlayerIterationInfos[startInteractionCount - iterationCount];
							}
							Array.Resize<int>(ref array, infos.Count);
							infos.CopyTo(array, 0);
							if (!isPlayerInteraction)
							{
								this.IterationInfos[startInteractionCount - iterationCount] = array;
							}
							else
							{
								this.PlayerIterationInfos[startInteractionCount - iterationCount] = array;
							}
							List<int> infos2 = new List<int>(array);
							int num4 = (int)((float)this.CalculateWinWeight(infos2, camp) * num) + this.IterationCalculateWeight(targetCamp, infos2, iterationCount2, startInteractionCount, isPlayerInteraction, selfCamp, targetCamp);
							if (num4 > num2)
							{
								num2 = num4;
							}
							infos[j] = (int)camp;
							infos[num3] = 0;
						}
					}
				}
				return num2;
			}
			int num5 = 9999;
			for (int k = 0; k < infos.Count; k++)
			{
				if (infos[k] == (int)camp)
				{
					foreach (int num6 in this.ChessBoard.GetNoneNeighborsWithCustomInfos(infos, k))
					{
						if (infos[num6] != 0)
						{
							return -1;
						}
						infos[k] = 0;
						infos[num6] = (int)camp;
						if (this.CheckGameOver(infos, num6))
						{
							return (int)((float)this.SourceWinWeight * this.LostWeight * num);
						}
						int[] array2;
						if (!isPlayerInteraction)
						{
							array2 = this.IterationInfos[startInteractionCount - iterationCount];
						}
						else
						{
							array2 = this.PlayerIterationInfos[startInteractionCount - iterationCount];
						}
						Array.Resize<int>(ref array2, infos.Count);
						infos.CopyTo(array2, 0);
						if (!isPlayerInteraction)
						{
							this.IterationInfos[startInteractionCount - iterationCount] = array2;
						}
						else
						{
							this.PlayerIterationInfos[startInteractionCount - iterationCount] = array2;
						}
						List<int> infos3 = new List<int>(array2);
						int num7;
						if (isPlayerInteraction)
						{
							num7 = (int)((float)this.CalculateWinWeight(infos, camp) * -num) + this.IterationCalculateWeight(selfCamp, infos3, iterationCount2, startInteractionCount, isPlayerInteraction, selfCamp, targetCamp);
						}
						else
						{
							int num8 = Math.Min(5, this.PlayerIterationCount) - 1;
							num7 = (int)((float)this.CalculateWinWeight(infos, camp) * -num) + (int)((float)this.IterationCalculateWeight(selfCamp, infos3, num8, num8, true, targetCamp, selfCamp) * this.IterationDecay * -num);
						}
						if (num7 < num5)
						{
							num5 = num7;
						}
						infos[k] = (int)camp;
						infos[num6] = 0;
					}
				}
			}
			return num5;
		}

		// Token: 0x0604545C RID: 283740 RVA: 0x011240A4 File Offset: 0x011222A4
		public void RefreshAiInfo(BP_AIGearStrategy_C aiInfo)
		{
			this.SourceLostWeight = aiInfo.LostWeight;
			this.RoundDecay = aiInfo.RoundDecay;
			this.IterationCount = aiInfo.IterationCount;
			this.PlayerIterationCount = aiInfo.PlayerIterationCount;
			this.IterationDecay = aiInfo.IterationDecay;
		}

		// Token: 0x0604545D RID: 283741 RVA: 0x011240E4 File Offset: 0x011222E4
		private int CalculateLineWinWeight(List<int> infos, ETicTacToeBoardContent camp, int sourceWinLineCount, bool isCenterEmpty, bool ignoreCenter)
		{
			int num = this.SourceWinWeight;
			int num2 = 0;
			int num3 = 0;
			int i = sourceWinLineCount;
			int num4 = this.NextPoints[0];
			while (i > 0)
			{
				if (infos[num4] == (int)camp)
				{
					i--;
					if (num2 > 0)
					{
						if (!ignoreCenter)
						{
							num2 = Math.Min(num2 - num3, isCenterEmpty ? this.StepCost : (this.StepCost * this.CenterBlockWeight));
						}
						num -= num2 + num3;
						num2 = 0;
						num3 = 0;
					}
				}
				else if (i < sourceWinLineCount)
				{
					num3 = ((infos[num4] == 0) ? this.StepCost : (this.StepCost * this.LineBlockWeight));
					num2 += num3;
				}
				num4 = this.NextPoints[num4];
				if (num4 == this.NextPoints[0])
				{
					break;
				}
			}
			i = this.ChessBoard.WinLineCount;
			int num5 = this.SourceWinWeight;
			num2 = 0;
			num3 = 0;
			i = sourceWinLineCount;
			int num6 = this.PrePoints[0];
			while (i > 0)
			{
				if (infos[num6] == (int)camp)
				{
					i--;
					if (num2 > 0)
					{
						if (!ignoreCenter)
						{
							num2 = Math.Min(num2 - num3, isCenterEmpty ? this.StepCost : (this.StepCost * this.CenterBlockWeight));
						}
						num5 -= num2 + num3;
						num2 = 0;
						num3 = 0;
					}
				}
				else if (i < sourceWinLineCount)
				{
					num3 = ((infos[num6] == 0) ? this.StepCost : (this.StepCost * this.LineBlockWeight));
					num2 += num3;
				}
				num6 = this.PrePoints[num6];
				if (num6 == this.PrePoints[0])
				{
					break;
				}
			}
			return Math.Max(num5, num);
		}

		// Token: 0x0604545E RID: 283742 RVA: 0x01124270 File Offset: 0x01122470
		private int CalcualteDiagonalLineWeight(List<int> infos, int centerIndex)
		{
			int num = infos[centerIndex];
			int num2 = -99999;
			int count = this.CirclePoints.Count;
			int num3 = count / 2;
			for (int i = 0; i < num3; i++)
			{
				int num4 = 0;
				int num5 = -1;
				int num6 = -1;
				for (int j = i; j < i + num3; j++)
				{
					int num7 = infos[this.CirclePoints[j]];
					if (num7 == num)
					{
						num5 = num4;
						break;
					}
					num4 += ((num7 == 0) ? this.StepCost : (this.StepCost * this.LineBlockWeight));
				}
				num4 = 0;
				for (int k = i; k > i - num3; k--)
				{
					int index = (k < 0) ? (k + count) : k;
					int num8 = infos[this.CirclePoints[index]];
					if (num8 == num)
					{
						num5 = Math.Min(num5, num4);
						break;
					}
					num4 += ((num8 == 0) ? this.StepCost : (this.StepCost * this.LineBlockWeight));
				}
				num4 = 0;
				for (int l = i + num3; l > i; l--)
				{
					int num9 = infos[this.CirclePoints[l]];
					if (num9 == num)
					{
						num6 = num4;
						break;
					}
					num4 += ((num9 == 0) ? this.StepCost : (this.StepCost * this.LineBlockWeight));
				}
				for (int m = i + num3; m < i + num3 + num3; m++)
				{
					int index2 = (m >= count) ? (m - count) : m;
					int num10 = infos[this.CirclePoints[index2]];
					if (num10 == num)
					{
						num6 = Math.Min(num6, num4);
						break;
					}
					num4 += ((num10 == 0) ? this.StepCost : (this.StepCost * this.LineBlockWeight));
				}
				num2 = Math.Max(num2, this.SourceWinWeight - num6 - num5);
			}
			return num2;
		}

		// Token: 0x0604545F RID: 283743 RVA: 0x0112444C File Offset: 0x0112264C
		private int CalculateWinWeight(List<int> infos, ETicTacToeBoardContent camp)
		{
			int centerIndex = this.ChessBoard.CenterIndex;
			int winLineCount = this.ChessBoard.WinLineCount;
			bool flag = infos[centerIndex] == 0;
			if (infos[centerIndex] != (int)camp)
			{
				int val = this.CalculateLineWinWeight(infos, camp, winLineCount, flag, false);
				int num = this.CalcualteDiagonalLineWeight(infos, centerIndex) - this.StepCost * this.CenterBlockWeight;
				if (!flag)
				{
					num -= this.StepCost * this.CenterBlockWeight;
				}
				return Math.Max(val, num);
			}
			int sourceWinLineCount = winLineCount - 1;
			int val2 = this.CalculateLineWinWeight(infos, camp, sourceWinLineCount, false, true);
			int val3 = this.CalcualteDiagonalLineWeight(infos, centerIndex) - this.StepCost * this.CenterBlockWeight;
			return Math.Max(val2, val3);
		}

		// Token: 0x040241E8 RID: 147944
		private const int MAX_AI_ITERATION_COUNT = 20;

		// Token: 0x040241E9 RID: 147945
		private const int MAX_PLAYER_ITERATION_COUNT = 5;

		// Token: 0x040241EA RID: 147946
		private ETicTacToeBoardContent PlayerCamp = ETicTacToeBoardContent.White;

		// Token: 0x040241EB RID: 147947
		private readonly List<int> BoardInfo = new List<int>();

		// Token: 0x040241EC RID: 147948
		private readonly List<int> NextPoints = new List<int>();

		// Token: 0x040241ED RID: 147949
		private readonly List<int> PrePoints = new List<int>();

		// Token: 0x040241EE RID: 147950
		private readonly List<int> CirclePoints = new List<int>();

		// Token: 0x040241EF RID: 147951
		private readonly List<int> BoardInfoCopy = new List<int>();

		// Token: 0x040241F0 RID: 147952
		private readonly List<int[]> IterationInfos = new List<int[]>();

		// Token: 0x040241F1 RID: 147953
		private readonly List<int[]> PlayerIterationInfos = new List<int[]>();

		// Token: 0x040241F2 RID: 147954
		private readonly List<int> HistoryOperates = new List<int>();

		// Token: 0x040241F3 RID: 147955
		private readonly int SourceWinWeight = 100;

		// Token: 0x040241F4 RID: 147956
		private readonly int WinWeight = 5;

		// Token: 0x040241F5 RID: 147957
		private float SourceLostWeight = -5f;

		// Token: 0x040241F6 RID: 147958
		private float LostWeight = -5f;

		// Token: 0x040241F7 RID: 147959
		private float RoundDecay = 0.8f;

		// Token: 0x040241F8 RID: 147960
		private readonly int CenterBlockWeight = 5;

		// Token: 0x040241F9 RID: 147961
		private readonly int LineBlockWeight = 8;

		// Token: 0x040241FA RID: 147962
		private readonly int StepCost = 3;

		// Token: 0x040241FB RID: 147963
		private int IterationCount = 3;

		// Token: 0x040241FC RID: 147964
		private int PlayerIterationCount = 2;

		// Token: 0x040241FD RID: 147965
		private float IterationDecay = 0.8f;

		// Token: 0x040241FE RID: 147966
		private readonly int HistoryQueueMemberCount = 5;

		// Token: 0x040241FF RID: 147967
		private readonly int RepeatOperationWeight = -300;
	}
}
