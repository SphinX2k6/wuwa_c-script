using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006276 RID: 25206
	public enum TJigsawCompleteCondition : byte
	{
		// Token: 0x040101A4 RID: 65956
		NONE,
		// Token: 0x040101A5 RID: 65957
		IActivateAllCorrectPiece,
		// Token: 0x040101A6 RID: 65958
		IActivateSpecifiedPiece,
		// Token: 0x040101A7 RID: 65959
		IActiveRenjuPiece,
		// Token: 0x040101A8 RID: 65960
		IPutInTheSpecifiedPiece
	}
}
