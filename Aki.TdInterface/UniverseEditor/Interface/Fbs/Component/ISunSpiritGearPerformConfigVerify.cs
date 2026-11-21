using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200600A RID: 24586
	public static class ISunSpiritGearPerformConfigVerify
	{
		// Token: 0x0602970D RID: 169741 RVA: 0x005A7F5A File Offset: 0x005A615A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
