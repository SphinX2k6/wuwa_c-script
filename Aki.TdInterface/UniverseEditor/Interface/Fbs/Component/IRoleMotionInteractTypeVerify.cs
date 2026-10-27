using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200587E RID: 22654
	public static class IRoleMotionInteractTypeVerify
	{
		// Token: 0x060262C3 RID: 156355 RVA: 0x00543412 File Offset: 0x00541612
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
