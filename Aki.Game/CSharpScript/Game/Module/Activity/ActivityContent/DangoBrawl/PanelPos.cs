using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x0200678B RID: 26507
	public struct PanelPos : IEquatable<PanelPos>
	{
		// Token: 0x060421DC RID: 270812 RVA: 0x0100A20C File Offset: 0x0100840C
		public PanelPos(int rowIndex, int colIndex)
		{
			this.RowIndex = rowIndex;
			this.ColIndex = colIndex;
		}

		// Token: 0x060421DD RID: 270813 RVA: 0x0100A21C File Offset: 0x0100841C
		public bool Equals(PanelPos other)
		{
			return this.RowIndex == other.RowIndex && this.ColIndex == other.ColIndex;
		}

		// Token: 0x060421DE RID: 270814 RVA: 0x0100A23C File Offset: 0x0100843C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is PanelPos)
			{
				PanelPos other = (PanelPos)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x060421DF RID: 270815 RVA: 0x0100A261 File Offset: 0x01008461
		public override int GetHashCode()
		{
			return this.RowIndex << 16 ^ this.ColIndex;
		}

		// Token: 0x060421E0 RID: 270816 RVA: 0x0100A273 File Offset: 0x01008473
		public static bool operator ==(PanelPos left, PanelPos right)
		{
			return left.Equals(right);
		}

		// Token: 0x060421E1 RID: 270817 RVA: 0x0100A27D File Offset: 0x0100847D
		public static bool operator !=(PanelPos left, PanelPos right)
		{
			return !left.Equals(right);
		}

		// Token: 0x04022801 RID: 141313
		public int ColIndex;

		// Token: 0x04022802 RID: 141314
		public int RowIndex;
	}
}
