using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Logic
{
	// Token: 0x0200547D RID: 21629
	public struct ItemSequence
	{
		// Token: 0x06035B43 RID: 219971 RVA: 0x00F020B4 File Offset: 0x00F002B4
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

		// Token: 0x06035B44 RID: 219972 RVA: 0x00F02144 File Offset: 0x00F00344
		public bool Covers(int row, int col)
		{
			return (this.HLen > 0 && row == this.HStartRow && col >= this.HStartCol && col < this.HStartCol + this.HLen) || (this.VLen > 0 && col == this.VStartCol && row >= this.VStartRow && row < this.VStartRow + this.VLen);
		}

		// Token: 0x1700686B RID: 26731
		// (get) Token: 0x06035B45 RID: 219973 RVA: 0x00F021AC File Offset: 0x00F003AC
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

		// Token: 0x0401C678 RID: 116344
		public int HStartRow;

		// Token: 0x0401C679 RID: 116345
		public int HStartCol;

		// Token: 0x0401C67A RID: 116346
		public int HLen;

		// Token: 0x0401C67B RID: 116347
		public int VStartRow;

		// Token: 0x0401C67C RID: 116348
		public int VStartCol;

		// Token: 0x0401C67D RID: 116349
		public int VLen;

		// Token: 0x0401C67E RID: 116350
		public EMatchShape Shape;

		// Token: 0x0401C67F RID: 116351
		public EPieceType Type;

		// Token: 0x0401C680 RID: 116352
		public int CenterRow;

		// Token: 0x0401C681 RID: 116353
		public int CenterCol;

		// Token: 0x0401C682 RID: 116354
		public int Score;

		// Token: 0x0401C683 RID: 116355
		public int Charge;
	}
}
