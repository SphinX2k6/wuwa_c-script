using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076BC RID: 30396
	public static class ISceneInteractionOperationTypeVerify
	{
		// Token: 0x06035528 RID: 218408 RVA: 0x00727322 File Offset: 0x00725522
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
