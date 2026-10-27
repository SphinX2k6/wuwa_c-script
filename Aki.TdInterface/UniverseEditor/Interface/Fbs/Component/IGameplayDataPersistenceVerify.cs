using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052E4 RID: 21220
	public static class IGameplayDataPersistenceVerify
	{
		// Token: 0x06022A44 RID: 141892 RVA: 0x004CD396 File Offset: 0x004CB596
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
