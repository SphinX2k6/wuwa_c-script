using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200669E RID: 26270
	public static class IEnableUiOperationVerify
	{
		// Token: 0x0602DA90 RID: 187024 RVA: 0x0063F9A2 File Offset: 0x0063DBA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
