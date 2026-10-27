using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004632 RID: 17970
	public static class IAddAllPhantomVerify
	{
		// Token: 0x0601B374 RID: 111476 RVA: 0x003DFED2 File Offset: 0x003DE0D2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
