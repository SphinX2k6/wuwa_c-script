using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200568E RID: 22158
	public static class INpcUiInteractTypeVerify
	{
		// Token: 0x06024F80 RID: 151424 RVA: 0x0051B132 File Offset: 0x00519332
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
