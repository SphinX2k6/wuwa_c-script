using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200644A RID: 25674
	public static class ICloseWalkingOverlayMontageVerify
	{
		// Token: 0x0602C6F3 RID: 182003 RVA: 0x00618682 File Offset: 0x00616882
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
