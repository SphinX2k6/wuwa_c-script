using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02005FEA RID: 24554
	[NullableContext(1)]
	[Nullable(0)]
	public class TetrisBoardData
	{
		// Token: 0x0603E371 RID: 254833 RVA: 0x00F0580C File Offset: 0x00F03A0C
		public TetrisBoardData()
		{
			for (int i = 0; i < 8; i++)
			{
				this.CellsInternal[i] = new TetrisCellData[8];
				for (int j = 0; j < 8; j++)
				{
					this.CellsInternal[i][j] = new TetrisCellData();
				}
			}
		}

		// Token: 0x0603E372 RID: 254834 RVA: 0x00F05860 File Offset: 0x00F03A60
		public void Reset()
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					this.CellsInternal[i][j].Reset();
				}
			}
		}

		// Token: 0x17009049 RID: 36937
		// (get) Token: 0x0603E373 RID: 254835 RVA: 0x00F05894 File Offset: 0x00F03A94
		public TetrisCellData[][] Cells
		{
			get
			{
				return this.CellsInternal;
			}
		}

		// Token: 0x0603E374 RID: 254836 RVA: 0x00F0589C File Offset: 0x00F03A9C
		public bool[][] GetBoardOccupancy()
		{
			bool[][] array = new bool[8][];
			for (int i = 0; i < 8; i++)
			{
				array[i] = new bool[8];
				for (int j = 0; j < 8; j++)
				{
					array[i][j] = this.CellsInternal[i][j].IsOccupied;
				}
			}
			return array;
		}

		// Token: 0x0603E375 RID: 254837 RVA: 0x00F058E8 File Offset: 0x00F03AE8
		public TetrisCellData[][] CloneCells()
		{
			TetrisCellData[][] array = new TetrisCellData[8][];
			for (int i = 0; i < 8; i++)
			{
				array[i] = new TetrisCellData[8];
				for (int j = 0; j < 8; j++)
				{
					array[i][j] = this.CellsInternal[i][j].Clone();
				}
			}
			return array;
		}

		// Token: 0x0603E376 RID: 254838 RVA: 0x00F05934 File Offset: 0x00F03B34
		public void RestoreFromSnapshot(TetrisCellData[][] snapshot)
		{
			for (int i = 0; i < 8; i++)
			{
				for (int j = 0; j < 8; j++)
				{
					TetrisCellData tetrisCellData = snapshot[i][j];
					TetrisCellData tetrisCellData2 = this.CellsInternal[i][j];
					tetrisCellData2.Type = tetrisCellData.Type;
					tetrisCellData2.SealState = tetrisCellData.SealState;
					tetrisCellData2.GemType = tetrisCellData.GemType;
					tetrisCellData2.ColorId = tetrisCellData.ColorId;
				}
			}
		}

		// Token: 0x040207FD RID: 133117
		public TetrisCellData[][] CellsInternal = new TetrisCellData[8][];
	}
}
