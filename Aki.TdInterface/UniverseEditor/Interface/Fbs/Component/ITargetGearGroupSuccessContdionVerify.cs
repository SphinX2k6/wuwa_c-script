using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A36 RID: 23094
	public static class ITargetGearGroupSuccessContdionVerify
	{
		// Token: 0x06027421 RID: 160801 RVA: 0x00566DE2 File Offset: 0x00564FE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
