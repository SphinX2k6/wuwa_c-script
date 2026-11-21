using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059B9 RID: 22969
	public static class IInteractAdditionalInfoVerify
	{
		// Token: 0x06025748 RID: 153416 RVA: 0x005231D6 File Offset: 0x005213D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
