using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Jigsaw
{
	// Token: 0x020071F1 RID: 29169
	[NullableContext(1)]
	[Nullable(0)]
	public class JigsawIndex
	{
		// Token: 0x06047637 RID: 292407 RVA: 0x01229A30 File Offset: 0x01227C30
		public JigsawIndex(int row, int col)
		{
		}

		// Token: 0x06047638 RID: 292408 RVA: 0x01229A46 File Offset: 0x01227C46
		public void DeepCopy(JigsawIndex other)
		{
			this.Row = other.Row;
			this.Col = other.Col;
		}

		// Token: 0x06047639 RID: 292409 RVA: 0x01229A60 File Offset: 0x01227C60
		public void SetValue(int row, int col)
		{
			this.Row = row;
			this.Col = col;
		}

		// Token: 0x0604763A RID: 292410 RVA: 0x01229A70 File Offset: 0x01227C70
		public bool Equels(JigsawIndex other)
		{
			return this.Row == other.Row && this.Col == other.Col;
		}

		// Token: 0x0604763B RID: 292411 RVA: 0x01229A90 File Offset: 0x01227C90
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

		// Token: 0x0604763C RID: 292412 RVA: 0x01229B08 File Offset: 0x01227D08
		public static JigsawIndex GenObjFromKey(string key)
		{
			string[] array = key.Split(',', StringSplitOptions.None);
			return new JigsawIndex(int.Parse(array[0]), int.Parse(array[1]));
		}

		// Token: 0x0604763D RID: 292413 RVA: 0x01229B34 File Offset: 0x01227D34
		public static string GenKey(int row, int col)
		{
			return row.ToString() + "," + col.ToString();
		}

		// Token: 0x040258B8 RID: 153784
		public int Row = row;

		// Token: 0x040258B9 RID: 153785
		public int Col = col;

		// Token: 0x040258BA RID: 153786
		[Nullable(2)]
		private string Key;

		// Token: 0x040258BB RID: 153787
		private int KeyRow;

		// Token: 0x040258BC RID: 153788
		private int KeyCol;
	}
}
