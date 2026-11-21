using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C2F RID: 23599
	public static class INpcUiInteractTypeVerify
	{
		// Token: 0x060271B9 RID: 160185 RVA: 0x0055BCCE File Offset: 0x00559ECE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
