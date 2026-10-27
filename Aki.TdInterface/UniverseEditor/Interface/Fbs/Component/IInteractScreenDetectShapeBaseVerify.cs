using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200546C RID: 21612
	public static class IInteractScreenDetectShapeBaseVerify
	{
		// Token: 0x060238DC RID: 145628 RVA: 0x004EAD9E File Offset: 0x004E8F9E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
