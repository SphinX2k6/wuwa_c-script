using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200535A RID: 21338
	public static class IActivateAllCorrectPieceVerify
	{
		// Token: 0x06021388 RID: 136072 RVA: 0x00495C0E File Offset: 0x00493E0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
