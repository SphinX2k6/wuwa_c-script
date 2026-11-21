using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Jigsaw
{
	// Token: 0x020062A6 RID: 25254
	[NullableContext(1)]
	[Nullable(0)]
	public class JigsawIndex
	{
		// Token: 0x0603CF39 RID: 249657 RVA: 0x01183884 File Offset: 0x01181A84
		public JigsawIndex(int row, int col)
		{
		}

		// Token: 0x0603CF3A RID: 249658 RVA: 0x0118389A File Offset: 0x01181A9A
		public void DeepCopy(JigsawIndex other)
		{
			this.Row = other.Row;
			this.Col = other.Col;
		}

		// Token: 0x0603CF3B RID: 249659 RVA: 0x011838B4 File Offset: 0x01181AB4
		public void SetValue(int row, int col)
		{
			this.Row = row;
			this.Col = col;
		}

		// Token: 0x0603CF3C RID: 249660 RVA: 0x011838C4 File Offset: 0x01181AC4
		public bool Equels(JigsawIndex other)
		{
			return this.Row == other.Row && this.Col == other.Col;
		}

		// Token: 0x0603CF3D RID: 249661 RVA: 0x011838E4 File Offset: 0x01181AE4
		public string GetKey()
		{
			if (this.Key == null || this.KeyRow != this.Row || this.KeyCol != this.Col)
			{
				this.Key = this.Row.ToString() + "," + this.Col.ToString();
				this.KeyRow = this.Row;
				this.KeyCol = this.Col;
			}
			return this.Key;
		}

		// Token: 0x0603CF3E RID: 249662 RVA: 0x0118395C File Offset: 0x01181B5C
		public static JigsawIndex GenObjFromKey(string key)
		{
			string[] array = key.Split(',', StringSplitOptions.None);
			return new JigsawIndex(int.Parse(array[0]), int.Parse(array[1]));
		}

		// Token: 0x0603CF3F RID: 249663 RVA: 0x01183988 File Offset: 0x01181B88
		public static string GenKey(int row, int col)
		{
			return row.ToString() + "," + col.ToString();
		}

		// Token: 0x04020527 RID: 132391
		public int Row = row;

		// Token: 0x04020528 RID: 132392
		public int Col = col;

		// Token: 0x04020529 RID: 132393
		[Nullable(2)]
		private string Key;

		// Token: 0x0402052A RID: 132394
		private int KeyRow;

		// Token: 0x0402052B RID: 132395
		private int KeyCol;
	}
}
