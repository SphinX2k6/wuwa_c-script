using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200539D RID: 21405
	public static class IHitLogicChangeNextStateVerify
	{
		// Token: 0x060230E3 RID: 143587 RVA: 0x004DA736 File Offset: 0x004D8936
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
