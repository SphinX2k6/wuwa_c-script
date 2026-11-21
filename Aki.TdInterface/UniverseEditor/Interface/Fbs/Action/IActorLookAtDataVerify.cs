using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006738 RID: 26424
	public static class IActorLookAtDataVerify
	{
		// Token: 0x0602CC4E RID: 183374 RVA: 0x0061FE66 File Offset: 0x0061E066
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
