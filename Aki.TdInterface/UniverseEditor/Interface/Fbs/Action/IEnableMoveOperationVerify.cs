using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006677 RID: 26231
	public static class IEnableMoveOperationVerify
	{
		// Token: 0x0602D926 RID: 186662 RVA: 0x0063D20A File Offset: 0x0063B40A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
