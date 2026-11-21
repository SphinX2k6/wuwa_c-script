using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.Chess.TicTacToe
{
	// Token: 0x020060BC RID: 24764
	[NullableContext(1)]
	[Nullable(0)]
	public class TicTacToeBoard
	{
		// Token: 0x0603B60F RID: 243215 RVA: 0x010CE584 File Offset: 0x010CC784
		public void GetBoardInfo(List<int> infos)
		{
			infos.Clear();
			foreach (int item in this.BoardInfo)
			{
				infos.Add(item);
			}
		}

		// Token: 0x0603B610 RID: 243216 RVA: 0x010CE5B8 File Offset: 0x010CC7B8
		public void GetNextPoints(List<int> points)
		{
			points.Clear();
			foreach (int item in this.NextPoints)
			{
				points.Add(item);
			}
		}

		// Token: 0x0603B611 RID: 243217 RVA: 0x010CE5EC File Offset: 0x010CC7EC
		public void GetPrePoints(List<int> points)
		{
			points.Clear();
			foreach (int item in this.PrePoints)
			{
				points.Add(item);
			}
		}

		// Token: 0x0603B612 RID: 243218 RVA: 0x010CE620 File Offset: 0x010CC820
		public void GetCirclePoints(List<int> points)
		{
			points.Clear();
			foreach (int item in this.CirclePoints)
			{
				points.Add(item);
			}
		}

		// Token: 0x17007061 RID: 28769
		// (get) Token: 0x0603B613 RID: 243219 RVA: 0x010CE653 File Offset: 0x010CC853
		public int BoardLength
		{
			get
			{
				return this.BoardLengthInternal;
			}
		}

		// Token: 0x17007062 RID: 28770
		// (get) Token: 0x0603B614 RID: 243220 RVA: 0x010CE65B File Offset: 0x010CC85B
		public int CenterIndex
		{
			get
			{
				return this.CenterIndexInternal;
			}
		}

		// Token: 0x17007063 RID: 28771
		// (get) Token: 0x0603B615 RID: 243221 RVA: 0x010CE663 File Offset: 0x010CC863
		public int WinLineCount
		{
			get
			{
				return this.WinLineCountInternal;
			}
		}

		// Token: 0x0603B616 RID: 243222 RVA: 0x010CE66B File Offset: 0x010CC86B
		public void Init(int winLineCount, Action<ETicTacToeBoardContent> onGameOver, Action onEndRound)
		{
			this.WinLineCountInternal = winLineCount;
			this.OnGameOver = onGameOver;
			this.OnEndRound = onEndRound;
		}

		// Token: 0x0603B617 RID: 243223 RVA: 0x010CE684 File Offset: 0x010CC884
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

		// Token: 0x0603B618 RID: 243224 RVA: 0x010CE6D4 File Offset: 0x010CC8D4
		public void InitBoardInfo(ETicTacToeBoardContent[] originInfo)
		{
			Array.Resize<int>(ref this.BoardInfo, originInfo.Length);
			for (int i = 0; i < originInfo.Length; i++)
			{
				this.BoardInfo[i] = (int)originInfo[i];
			}
		}

		// Token: 0x0603B619 RID: 243225 RVA: 0x010CE708 File Offset: 0x010CC908
		public void StartGame()
		{
		}

		// Token: 0x0603B61A RID: 243226 RVA: 0x010CE70C File Offset: 0x010CC90C
		public void ResetGame()
		{
			this.BoardInfo = new int[this.OriginBoardInfo.Length];
			for (int i = 0; i < this.OriginBoardInfo.Length; i++)
			{
				this.BoardInfo[i] = this.OriginBoardInfo[i];
			}
		}

		// Token: 0x0603B61B RID: 243227 RVA: 0x010CE74F File Offset: 0x010CC94F
		public bool CheckPieceSelect(int index, ETicTacToeBoardContent camp)
		{
			return this.BoardInfo.Length > index && this.BoardInfo[index] == (int)camp;
		}

		// Token: 0x0603B61C RID: 243228 RVA: 0x010CE76C File Offset: 0x010CC96C
		public bool CheckPieceMove(int index, int oldIndex, ETicTacToeBoardContent camp)
		{
			return this.BoardInfo[index] == (int)camp && this.BoardInfo[oldIndex] == 0 && (index == this.CenterIndexInternal || oldIndex == this.CenterIndexInternal || this.PrePoints[oldIndex] == index || this.NextPoints[oldIndex] == index);
		}

		// Token: 0x0603B61D RID: 243229 RVA: 0x010CE7C0 File Offset: 0x010CC9C0
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

		// Token: 0x0603B61E RID: 243230 RVA: 0x010CE811 File Offset: 0x010CCA11
		public bool CheckBoardValue(int index, ETicTacToeBoardContent value)
		{
			return this.BoardInfo[index] == (int)value;
		}

		// Token: 0x0603B61F RID: 243231 RVA: 0x010CE820 File Offset: 0x010CCA20
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

		// Token: 0x0603B620 RID: 243232 RVA: 0x010CE9A0 File Offset: 0x010CCBA0
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

		// Token: 0x0603B621 RID: 243233 RVA: 0x010CEB00 File Offset: 0x010CCD00
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

		// Token: 0x0603B622 RID: 243234 RVA: 0x010CEC70 File Offset: 0x010CCE70
		public void GetDebugBoardInfo(TArray<int> infos)
		{
			infos.Empty(true);
			foreach (int value in this.BoardInfo)
			{
				infos.Add(value);
			}
		}

		// Token: 0x0401F4B9 RID: 128185
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

		// Token: 0x0401F4BA RID: 128186
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

		// Token: 0x0401F4BB RID: 128187
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

		// Token: 0x0401F4BC RID: 128188
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

		// Token: 0x0401F4BD RID: 128189
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

		// Token: 0x0401F4BE RID: 128190
		private readonly int BoardLengthInternal = 3;

		// Token: 0x0401F4BF RID: 128191
		private readonly int CenterIndexInternal = 4;

		// Token: 0x0401F4C0 RID: 128192
		private int WinLineCountInternal = 3;

		// Token: 0x0401F4C1 RID: 128193
		[Nullable(2)]
		private Action<ETicTacToeBoardContent> OnGameOver;

		// Token: 0x0401F4C2 RID: 128194
		[Nullable(2)]
		private Action OnEndRound;

		// Token: 0x0401F4C3 RID: 128195
		protected List<int> SelectNeighbors = new List<int>();
	}
}
