using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200795B RID: 31067
	public static class ISplineMoveMontageTypeVerify
	{
		// Token: 0x06036B5F RID: 224095 RVA: 0x00751E3E File Offset: 0x0075003E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
