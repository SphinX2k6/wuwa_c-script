using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.AIGearStrategy;

namespace CSharpScript.Game.LevelGamePlay.Chess.TicTacToe
{
	// Token: 0x020060BA RID: 24762
	[NullableContext(1)]
	[Nullable(0)]
	public class TicTacToeAiController : TicTacToeController
	{
		// Token: 0x0603B602 RID: 243202 RVA: 0x010CD770 File Offset: 0x010CB970
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

		// Token: 0x0603B603 RID: 243203 RVA: 0x010CD80C File Offset: 0x010CBA0C
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

		// Token: 0x0603B604 RID: 243204 RVA: 0x010CD888 File Offset: 0x010CBA88
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

		// Token: 0x0603B605 RID: 243205 RVA: 0x010CD95B File Offset: 0x010CBB5B
		public override void OnStartGame()
		{
			base.OnStartGame();
			this.HistoryOperates.Clear();
			this.LostWeight = this.SourceLostWeight;
		}

		// Token: 0x0603B606 RID: 243206 RVA: 0x010CD97A File Offset: 0x010CBB7A
		private int CalculateHistoryOperateValue(int index, int moveTo)
		{
			return index * 100 + moveTo;
		}

		// Token: 0x0603B607 RID: 243207 RVA: 0x010CD984 File Offset: 0x010CBB84
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

		// Token: 0x0603B608 RID: 243208 RVA: 0x010CDB50 File Offset: 0x010CBD50
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

		// Token: 0x0603B609 RID: 243209 RVA: 0x010CDCD0 File Offset: 0x010CBED0
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

		// Token: 0x0603B60A RID: 243210 RVA: 0x010CE050 File Offset: 0x010CC250
		public void RefreshAiInfo(BP_AIGearStrategy_C aiInfo)
		{
			this.SourceLostWeight = aiInfo.LostWeight;
			this.RoundDecay = aiInfo.RoundDecay;
			this.IterationCount = aiInfo.IterationCount;
			this.PlayerIterationCount = aiInfo.PlayerIterationCount;
			this.IterationDecay = aiInfo.IterationDecay;
		}

		// Token: 0x0603B60B RID: 243211 RVA: 0x010CE090 File Offset: 0x010CC290
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

		// Token: 0x0603B60C RID: 243212 RVA: 0x010CE21C File Offset: 0x010CC41C
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

		// Token: 0x0603B60D RID: 243213 RVA: 0x010CE3F8 File Offset: 0x010CC5F8
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

		// Token: 0x0401F49D RID: 128157
		private const int MAX_AI_ITERATION_COUNT = 20;

		// Token: 0x0401F49E RID: 128158
		private const int MAX_PLAYER_ITERATION_COUNT = 5;

		// Token: 0x0401F49F RID: 128159
		private ETicTacToeBoardContent PlayerCamp = ETicTacToeBoardContent.White;

		// Token: 0x0401F4A0 RID: 128160
		private readonly List<int> BoardInfo = new List<int>();

		// Token: 0x0401F4A1 RID: 128161
		private readonly List<int> NextPoints = new List<int>();

		// Token: 0x0401F4A2 RID: 128162
		private readonly List<int> PrePoints = new List<int>();

		// Token: 0x0401F4A3 RID: 128163
		private readonly List<int> CirclePoints = new List<int>();

		// Token: 0x0401F4A4 RID: 128164
		private readonly List<int> BoardInfoCopy = new List<int>();

		// Token: 0x0401F4A5 RID: 128165
		private readonly List<int[]> IterationInfos = new List<int[]>();

		// Token: 0x0401F4A6 RID: 128166
		private readonly List<int[]> PlayerIterationInfos = new List<int[]>();

		// Token: 0x0401F4A7 RID: 128167
		private readonly List<int> HistoryOperates = new List<int>();

		// Token: 0x0401F4A8 RID: 128168
		private readonly int SourceWinWeight = 100;

		// Token: 0x0401F4A9 RID: 128169
		private readonly int WinWeight = 5;

		// Token: 0x0401F4AA RID: 128170
		private float SourceLostWeight = -5f;

		// Token: 0x0401F4AB RID: 128171
		private float LostWeight = -5f;

		// Token: 0x0401F4AC RID: 128172
		private float RoundDecay = 0.8f;

		// Token: 0x0401F4AD RID: 128173
		private readonly int CenterBlockWeight = 5;

		// Token: 0x0401F4AE RID: 128174
		private readonly int LineBlockWeight = 8;

		// Token: 0x0401F4AF RID: 128175
		private readonly int StepCost = 3;

		// Token: 0x0401F4B0 RID: 128176
		private int IterationCount = 3;

		// Token: 0x0401F4B1 RID: 128177
		private int PlayerIterationCount = 2;

		// Token: 0x0401F4B2 RID: 128178
		private float IterationDecay = 0.8f;

		// Token: 0x0401F4B3 RID: 128179
		private readonly int HistoryQueueMemberCount = 5;

		// Token: 0x0401F4B4 RID: 128180
		private readonly int RepeatOperationWeight = -300;
	}
}
