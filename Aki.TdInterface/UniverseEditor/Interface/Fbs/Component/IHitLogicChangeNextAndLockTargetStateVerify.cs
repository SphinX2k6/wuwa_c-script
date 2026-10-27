using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200539A RID: 21402
	public static class IHitLogicChangeNextAndLockTargetStateVerify
	{
		// Token: 0x060230D1 RID: 143569 RVA: 0x004DA5B3 File Offset: 0x004D87B3
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
