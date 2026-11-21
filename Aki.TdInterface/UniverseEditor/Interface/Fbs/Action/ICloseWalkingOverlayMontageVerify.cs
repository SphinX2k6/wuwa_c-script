using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB8 RID: 27320
	public static class ICloseWalkingOverlayMontageVerify
	{
		// Token: 0x0602EE56 RID: 192086 RVA: 0x006639C2 File Offset: 0x00661BC2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
