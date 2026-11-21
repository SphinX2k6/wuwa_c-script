using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl
{
	// Token: 0x020056DB RID: 22235
	public struct PanelPos : IEquatable<PanelPos>
	{
		// Token: 0x06036D32 RID: 224562 RVA: 0x00F4B5F0 File Offset: 0x00F497F0
		public PanelPos(int rowIndex, int colIndex)
		{
			this.RowIndex = rowIndex;
			this.ColIndex = colIndex;
		}

		// Token: 0x06036D33 RID: 224563 RVA: 0x00F4B600 File Offset: 0x00F49800
		public bool Equals(PanelPos other)
		{
			return this.RowIndex == other.RowIndex && this.ColIndex == other.ColIndex;
		}

		// Token: 0x06036D34 RID: 224564 RVA: 0x00F4B620 File Offset: 0x00F49820
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

		// Token: 0x06036D35 RID: 224565 RVA: 0x00F4B645 File Offset: 0x00F49845
		public override int GetHashCode()
		{
			return this.RowIndex << 16 ^ this.ColIndex;
		}

		// Token: 0x06036D36 RID: 224566 RVA: 0x00F4B657 File Offset: 0x00F49857
		public static bool operator ==(PanelPos left, PanelPos right)
		{
			return left.Equals(right);
		}

		// Token: 0x06036D37 RID: 224567 RVA: 0x00F4B661 File Offset: 0x00F49861
		public static bool operator !=(PanelPos left, PanelPos right)
		{
			return !left.Equals(right);
		}

		// Token: 0x0401D05E RID: 118878
		public int ColIndex;

		// Token: 0x0401D05F RID: 118879
		public int RowIndex;
	}
}
