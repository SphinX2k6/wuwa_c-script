using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F2 RID: 23026
	public static class IInteractScreenDetectShapeBaseVerify
	{
		// Token: 0x06025994 RID: 154004 RVA: 0x00527E12 File Offset: 0x00526012
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
