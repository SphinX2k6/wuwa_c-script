using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CF7 RID: 27895
	public static class IEnableSceneInteractionOperationVerify
	{
		// Token: 0x0603016F RID: 196975 RVA: 0x0068A9B6 File Offset: 0x00688BB6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
