using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074CE RID: 29902
	public static class IUnlockCookSystemTypeVerify
	{
		// Token: 0x060365D2 RID: 222674 RVA: 0x00763186 File Offset: 0x00761386
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
