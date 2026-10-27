using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200481C RID: 18460
	public static class IActorDeployConfigVerify
	{
		// Token: 0x0601C832 RID: 116786 RVA: 0x00408552 File Offset: 0x00406752
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
