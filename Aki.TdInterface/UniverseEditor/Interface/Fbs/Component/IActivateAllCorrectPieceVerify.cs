using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E49 RID: 20041
	public static class IActivateAllCorrectPieceVerify
	{
		// Token: 0x0601F73D RID: 128829 RVA: 0x00461BF6 File Offset: 0x0045FDF6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
