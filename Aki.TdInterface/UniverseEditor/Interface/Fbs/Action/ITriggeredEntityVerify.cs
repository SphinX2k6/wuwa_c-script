using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200747D RID: 29821
	public static class ITriggeredEntityVerify
	{
		// Token: 0x06036317 RID: 221975 RVA: 0x0075E3EE File Offset: 0x0075C5EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
