using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200533A RID: 21306
	public static class IGroupAiModeDefaultVerify
	{
		// Token: 0x06022D71 RID: 142705 RVA: 0x004D3B1E File Offset: 0x004D1D1E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
