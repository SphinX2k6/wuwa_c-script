using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006653 RID: 26195
	public static class IEnableCameraOperationVerify
	{
		// Token: 0x0602D806 RID: 186374 RVA: 0x0063B2E6 File Offset: 0x006394E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
