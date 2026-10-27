using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200667D RID: 26237
	public static class IEnableSceneInteractionOperationVerify
	{
		// Token: 0x0602D952 RID: 186706 RVA: 0x0063D702 File Offset: 0x0063B902
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
