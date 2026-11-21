using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200740E RID: 29710
	public static class IPetalGrabMoveTypeVerify
	{
		// Token: 0x06033FC9 RID: 212937 RVA: 0x00701F12 File Offset: 0x00700112
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
