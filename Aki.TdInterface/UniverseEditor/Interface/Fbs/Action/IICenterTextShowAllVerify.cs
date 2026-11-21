using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FF4 RID: 28660
	public static class IICenterTextShowAllVerify
	{
		// Token: 0x06031A9B RID: 203419 RVA: 0x006BA22A File Offset: 0x006B842A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
