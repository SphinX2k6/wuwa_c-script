using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Chess.TicTacToe
{
	// Token: 0x02006F3B RID: 28475
	[NullableContext(1)]
	[Nullable(0)]
	public class TicTacToeBoard
	{
		// Token: 0x06045461 RID: 283745 RVA: 0x011245D8 File Offset: 0x011227D8
		public void GetBoardInfo(List<int> infos)
		{
			infos.Clear();
			foreach (int item in this.BoardInfo)
			{
				infos.Add(item);
			}
		}

		// Token: 0x06045462 RID: 283746 RVA: 0x0112460C File Offset: 0x0112280C
		public void GetNextPoints(List<int> points)
		{
			points.Clear();
			foreach (int item in this.NextPoints)
			{
				points.Add(item);
			}
		}

		// Token: 0x06045463 RID: 283747 RVA: 0x01124640 File Offset: 0x01122840
		public void GetPrePoints(List<int> points)
		{
			points.Clear();
			foreach (int item in this.PrePoints)
			{
				points.Add(item);
			}
		}

		// Token: 0x06045464 RID: 283748 RVA: 0x01124674 File Offset: 0x01122874
		public void GetCirclePoints(List<int> points)
		{
			points.Clear();
			foreach (int item in this.CirclePoints)
			{
				points.Add(item);
			}
		}

		// Token: 0x17009B22 RID: 39714
		// (get) Token: 0x06045465 RID: 283749 RVA: 0x011246A7 File Offset: 0x011228A7
		public int BoardLength
		{
			get
			{
				return this.BoardLengthInternal;
			}
		}

		// Token: 0x17009B23 RID: 39715
		// (get) Token: 0x06045466 RID: 283750 RVA: 0x011246AF File Offset: 0x011228AF
		public int CenterIndex
		{
			get
			{
				return this.CenterIndexInternal;
			}
		}

		// Token: 0x17009B24 RID: 39716
		// (get) Token: 0x06045467 RID: 283751 RVA: 0x011246B7 File Offset: 0x011228B7
		public int WinLineCount
		{
			get
			{
				return this.WinLineCountInternal;
			}
		}

		// Token: 0x06045468 RID: 283752 RVA: 0x011246BF File Offset: 0x011228BF
		public void Init(int winLineCount, Action<ETicTacToeBoardContent> onGameOver, Action onEndRound)
		{
			this.WinLineCountInternal = winLineCount;
			this.OnGameOver = onGameOver;
			this.OnEndRound = onEndRound;
		}

		// Token: 0x06045469 RID: 283753 RVA: 0x011246D8 File Offset: 0x011228D8
		public void InitOriginBoardInfo(ETicTacToeBoardContent[] originInfo)
		{
			Array.Resize<int>(ref this.OriginBoardInfo, originInfo.Length);
			Array.Resize<int>(ref this.BoardInfo, originInfo.Length);
			for (int i = 0; i < originInfo.Length; i++)
			{
				this.OriginBoardInfo[i] = (int)originInfo[i];
				this.BoardInfo[i] = (int)originInfo[i];
			}
		}

		// Token: 0x0604546A RID: 283754 RVA: 0x01124728 File Offset: 0x01122928
		public void InitBoardInfo(ETicTacToeBoardContent[] originInfo)
		{
			Array.Resize<int>(ref this.BoardInfo, originInfo.Length);
			for (int i = 0; i < originInfo.Length; i++)
			{
				this.BoardInfo[i] = (int)originInfo[i];
			}
		}

		// Token: 0x0604546B RID: 283755 RVA: 0x0112475C File Offset: 0x0112295C
		public void StartGame()
		{
		}

		// Token: 0x0604546C RID: 283756 RVA: 0x01124760 File Offset: 0x01122960
		public void ResetGame()
		{
			this.BoardInfo = new int[this.OriginBoardInfo.Length];
			for (int i = 0; i < this.OriginBoardInfo.Length; i++)
			{
				this.BoardInfo[i] = this.OriginBoardInfo[i];
			}
		}

		// Token: 0x0604546D RID: 283757 RVA: 0x011247A3 File Offset: 0x011229A3
		public bool CheckPieceSelect(int index, ETicTacToeBoardContent camp)
		{
			return this.BoardInfo.Length > index && this.BoardInfo[index] == (int)camp;
		}

		// Token: 0x0604546E RID: 283758 RVA: 0x011247C0 File Offset: 0x011229C0
		public bool CheckPieceMove(int index, int oldIndex, ETicTacToeBoardContent camp)
		{
			return this.BoardInfo[index] == (int)camp && this.BoardInfo[oldIndex] == 0 && (index == this.CenterIndexInternal || oldIndex == this.CenterIndexInternal || this.PrePoints[oldIndex] == index || this.NextPoints[oldIndex] == index);
		}

		// Token: 0x0604546F RID: 283759 RVA: 0x01124814 File Offset: 0x01122A14
		public bool OnPieceMove(int index, int newIndex)
		{
			if (this.BoardInfo[newIndex] != 0)
			{
				return false;
			}
			int num = this.BoardInfo[index];
			this.BoardInfo[index] = 0;
			this.BoardInfo[newIndex] = num;
			if (!this.CheckGameOver(newIndex) && this.OnEndRound != null)
			{
				this.OnEndRound();
			}
			return true;
		}

		// Token: 0x06045470 RID: 283760 RVA: 0x01124865 File Offset: 0x01122A65
		public bool CheckBoardValue(int index, ETicTacToeBoardContent value)
		{
			return this.BoardInfo[index] == (int)value;
		}

		// Token: 0x06045471 RID: 283761 RVA: 0x01124874 File Offset: 0x01122A74
		public IReadOnlyList<int> GetNoneNeighbors(int selectIndex)
		{
			this.SelectNeighbors.Clear();
			if (selectIndex == this.CenterIndex)
			{
				int num = selectIndex % this.BoardLengthInternal;
				int num2 = selectIndex / this.BoardLengthInternal;
				for (int i = num2 - 1; i < num2 + 2; i++)
				{
					if (i >= 0 && i < this.BoardLengthInternal)
					{
						for (int j = num - 1; j < num + 2; j++)
						{
							if (j >= 0 && j < this.BoardLengthInternal)
							{
								int num3 = i * this.BoardLengthInternal + j;
								if (this.BoardInfo[num3] == 0)
								{
									this.SelectNeighbors.Add(num3);
								}
							}
						}
					}
				}
			}
			else if (selectIndex > -1)
			{
				int num4 = selectIndex % this.BoardLengthInternal;
				int num5 = selectIndex / this.BoardLengthInternal;
				for (int k = num5 - 1; k < num5 + 2; k++)
				{
					if (k >= 0 && k < this.BoardLengthInternal)
					{
						int num6 = k * this.BoardLengthInternal + num4;
						if (this.BoardInfo[num6] == 0)
						{
							this.SelectNeighbors.Add(num6);
						}
					}
				}
				for (int l = num4 - 1; l < num4 + 2; l++)
				{
					if (l >= 0 && l < this.BoardLengthInternal)
					{
						int num7 = num5 * this.BoardLengthInternal + l;
						if (this.BoardInfo[num7] == 0)
						{
							this.SelectNeighbors.Add(num7);
						}
					}
				}
				if (this.BoardInfo[this.CenterIndexInternal] == 0 && !this.SelectNeighbors.Contains(this.CenterIndexInternal))
				{
					this.SelectNeighbors.Add(this.CenterIndexInternal);
				}
			}
			return this.SelectNeighbors;
		}

		// Token: 0x06045472 RID: 283762 RVA: 0x011249F4 File Offset: 0x01122BF4
		public IReadOnlyList<int> GetNoneNeighborsWithCustomInfos(List<int> infos, int selectIndex)
		{
			List<int> list = new List<int>();
			if (selectIndex == this.CenterIndex)
			{
				int num = selectIndex % this.BoardLengthInternal;
				int num2 = selectIndex / this.BoardLengthInternal;
				for (int i = num2 - 1; i < num2 + 2; i++)
				{
					if (i >= 0 && i < this.BoardLengthInternal)
					{
						for (int j = num - 1; j < num + 2; j++)
						{
							if (j >= 0 && j < this.BoardLengthInternal)
							{
								int num3 = i * this.BoardLengthInternal + j;
								if (infos[num3] == 0)
								{
									list.Add(num3);
								}
							}
						}
					}
				}
			}
			else if (selectIndex > -1)
			{
				int num4 = selectIndex % this.BoardLengthInternal;
				int num5 = selectIndex / this.BoardLengthInternal;
				for (int k = num5 - 1; k < num5 + 2; k++)
				{
					if (k >= 0 && k < this.BoardLengthInternal)
					{
						int num6 = k * this.BoardLengthInternal + num4;
						if (infos[num6] == 0)
						{
							list.Add(num6);
						}
					}
				}
				for (int l = num4 - 1; l < num4 + 2; l++)
				{
					if (l >= 0 && l < this.BoardLengthInternal)
					{
						int num7 = num5 * this.BoardLengthInternal + l;
						if (infos[num7] == 0)
						{
							list.Add(num7);
						}
					}
				}
				if (infos[this.CenterIndexInternal] == 0 && !list.Contains(this.CenterIndexInternal))
				{
					list.Add(this.CenterIndexInternal);
				}
			}
			return list;
		}

		// Token: 0x06045473 RID: 283763 RVA: 0x01124B54 File Offset: 0x01122D54
		public bool CheckGameOver(int startIndex)
		{
			int num = this.BoardInfo[startIndex];
			if (num == 0)
			{
				return false;
			}
			int num2 = this.CirclePoints.Length;
			int num3 = this.CirclePoints.Length / 2;
			if (startIndex != this.CenterIndexInternal)
			{
				int num4 = this.WinLineCountInternal - 1;
				int num5 = this.NextPoints[startIndex];
				while (num4-- > 0)
				{
					if (this.BoardInfo[num5] != num)
					{
						num4++;
						break;
					}
					num5 = this.NextPoints[num5];
				}
				int num6 = this.PrePoints[startIndex];
				while (num4-- > 0)
				{
					if (this.BoardInfo[num6] != num)
					{
						num4++;
						break;
					}
					num6 = this.PrePoints[num6];
				}
				if (num4 < 1)
				{
					if (this.OnGameOver != null)
					{
						this.OnGameOver((ETicTacToeBoardContent)num);
					}
					return true;
				}
				if (num == this.BoardInfo[this.CenterIndexInternal])
				{
					int num7 = Array.IndexOf<int>(this.CirclePoints, startIndex);
					if (num7 > -1)
					{
						int num8 = (num7 + num3) % num2;
						if (num == this.BoardInfo[this.CirclePoints[num8]])
						{
							if (this.OnGameOver != null)
							{
								this.OnGameOver((ETicTacToeBoardContent)num);
							}
							return true;
						}
					}
				}
			}
			else
			{
				for (int i = 0; i < num3; i++)
				{
					int num9 = (i + num3) % num2;
					if (num == this.BoardInfo[this.CirclePoints[i]] && num == this.BoardInfo[this.CirclePoints[num9]])
					{
						if (this.OnGameOver != null)
						{
							this.OnGameOver((ETicTacToeBoardContent)num);
						}
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06045474 RID: 283764 RVA: 0x01124CC4 File Offset: 0x01122EC4
		public void GetDebugBoardInfo(TArray<int> infos)
		{
			infos.Empty(true);
			foreach (int value in this.BoardInfo)
			{
				infos.Add(value);
			}
		}

		// Token: 0x04024204 RID: 147972
		protected int[] OriginBoardInfo = new int[]
		{
			0,
			0,
			2,
			2,
			1,
			1,
			0,
			1,
			2
		};

		// Token: 0x04024205 RID: 147973
		protected int[] BoardInfo = new int[]
		{
			0,
			0,
			2,
			2,
			1,
			1,
			0,
			1,
			2
		};

		// Token: 0x04024206 RID: 147974
		protected int[] NextPoints = new int[]
		{
			1,
			2,
			5,
			0,
			-1,
			8,
			3,
			6,
			7
		};

		// Token: 0x04024207 RID: 147975
		protected int[] PrePoints = new int[]
		{
			3,
			0,
			1,
			6,
			-1,
			2,
			7,
			8,
			5
		};

		// Token: 0x04024208 RID: 147976
		protected int[] CirclePoints = new int[]
		{
			1,
			2,
			5,
			8,
			7,
			6,
			3,
			0
		};

		// Token: 0x04024209 RID: 147977
		private readonly int BoardLengthInternal = 3;

		// Token: 0x0402420A RID: 147978
		private readonly int CenterIndexInternal = 4;

		// Token: 0x0402420B RID: 147979
		private int WinLineCountInternal = 3;

		// Token: 0x0402420C RID: 147980
		[Nullable(2)]
		private Action<ETicTacToeBoardContent> OnGameOver;

		// Token: 0x0402420D RID: 147981
		[Nullable(2)]
		private Action OnEndRound;

		// Token: 0x0402420E RID: 147982
		protected List<int> SelectNeighbors = new List<int>();
	}
}
