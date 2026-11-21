using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200703F RID: 28735
	public static class IInteractionConfirmBoxTypeVerify
	{
		// Token: 0x06031CD7 RID: 203991 RVA: 0x006BDC52 File Offset: 0x006BBE52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
