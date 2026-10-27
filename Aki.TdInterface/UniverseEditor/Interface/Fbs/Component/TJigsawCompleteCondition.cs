using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C51 RID: 23633
	public enum TJigsawCompleteCondition : byte
	{
		// Token: 0x0400F47A RID: 62586
		NONE,
		// Token: 0x0400F47B RID: 62587
		IActivateAllCorrectPiece,
		// Token: 0x0400F47C RID: 62588
		IActivateSpecifiedPiece,
		// Token: 0x0400F47D RID: 62589
		IActiveRenjuPiece,
		// Token: 0x0400F47E RID: 62590
		IPutInTheSpecifiedPiece
	}
}
