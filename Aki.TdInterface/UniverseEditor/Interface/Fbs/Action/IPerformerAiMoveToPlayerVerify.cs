using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073F0 RID: 29680
	public static class IPerformerAiMoveToPlayerVerify
	{
		// Token: 0x06033EBD RID: 212669 RVA: 0x0070014E File Offset: 0x006FE34E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
