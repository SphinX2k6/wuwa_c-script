using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200761B RID: 30235
	public static class IWriteLetterConfigVerify
	{
		// Token: 0x06037123 RID: 225571 RVA: 0x007782FE File Offset: 0x007764FE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
