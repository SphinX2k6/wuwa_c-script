using System;
using System.Runtime.CompilerServices;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FB4 RID: 12212
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisBoardData
	{
		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x0601CFC4 RID: 118724 RVA: 0x008DA7E9 File Offset: 0x008D89E9
		public TetrisCellData[,] Cells { get; } = new TetrisCellData[8, 8];

		// Token: 0x0601CFC5 RID: 118725 RVA: 0x008DA7F4 File Offset: 0x008D89F4
		public void Reset()
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					this.Cells[i, j].Reset();
				}
			}
		}

		// Token: 0x0601CFC6 RID: 118726 RVA: 0x008DA82C File Offset: 0x008D8A2C
		public bool[,] GetBoardOccupancy()
		{
			bool[,] array = new bool[8, 8];
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					array[i, j] = this.Cells[i, j].IsOccupied;
				}
			}
			return array;
		}

		// Token: 0x0601CFC7 RID: 118727 RVA: 0x008DA874 File Offset: 0x008D8A74
		public TetrisCellData[,] CloneCells()
		{
			TetrisCellData[,] array = new TetrisCellData[8, 8];
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					array[i, j] = this.Cells[i, j].Clone();
				}
			}
			return array;
		}

		// Token: 0x0601CFC8 RID: 118728 RVA: 0x008DA8BC File Offset: 0x008D8ABC
		public void RestoreFromSnapshot(TetrisCellData[,] snapshot)
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					this.Cells[i, j].Assign(snapshot[i, j]);
				}
			}
		}
	}
}
