using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x020064FF RID: 25855
	public struct ItemSequence
	{
		// Token: 0x06040E7F RID: 265855 RVA: 0x00FBB084 File Offset: 0x00FB9284
		[NullableContext(1)]
		public void ForEachCell(Action<int, int> action)
		{
			for (int i = 0; i < this.HLen; i++)
			{
				action(this.HStartRow, this.HStartCol + i);
			}
			for (int j = 0; j < this.VLen; j++)
			{
				int num = this.VStartRow + j;
				if (this.HLen <= 0 || num != this.HStartRow || this.VStartCol < this.HStartCol || this.VStartCol >= this.HStartCol + this.HLen)
				{
					action(num, this.VStartCol);
				}
			}
		}

		// Token: 0x06040E80 RID: 265856 RVA: 0x00FBB114 File Offset: 0x00FB9314
		public bool Covers(int row, int col)
		{
			return (this.HLen > 0 && row == this.HStartRow && col >= this.HStartCol && col < this.HStartCol + this.HLen) || (this.VLen > 0 && col == this.VStartCol && row >= this.VStartRow && row < this.VStartRow + this.VLen);
		}

		// Token: 0x17009509 RID: 38153
		// (get) Token: 0x06040E81 RID: 265857 RVA: 0x00FBB17C File Offset: 0x00FB937C
		public int CellCount
		{
			get
			{
				int num = this.HLen + this.VLen;
				if (this.HLen > 0 && this.VLen > 0)
				{
					num--;
				}
				return num;
			}
		}

		// Token: 0x04021D47 RID: 138567
		public int HStartRow;

		// Token: 0x04021D48 RID: 138568
		public int HStartCol;

		// Token: 0x04021D49 RID: 138569
		public int HLen;

		// Token: 0x04021D4A RID: 138570
		public int VStartRow;

		// Token: 0x04021D4B RID: 138571
		public int VStartCol;

		// Token: 0x04021D4C RID: 138572
		public int VLen;

		// Token: 0x04021D4D RID: 138573
		public EMatchShape Shape;

		// Token: 0x04021D4E RID: 138574
		public EPieceType Type;

		// Token: 0x04021D4F RID: 138575
		public int CenterRow;

		// Token: 0x04021D50 RID: 138576
		public int CenterCol;

		// Token: 0x04021D51 RID: 138577
		public int Score;

		// Token: 0x04021D52 RID: 138578
		public int Charge;
	}
}
