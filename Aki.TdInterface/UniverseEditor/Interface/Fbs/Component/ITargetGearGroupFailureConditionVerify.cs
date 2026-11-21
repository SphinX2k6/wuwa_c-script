using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200603D RID: 24637
	public static class ITargetGearGroupFailureConditionVerify
	{
		// Token: 0x06029977 RID: 170359 RVA: 0x005ADAA2 File Offset: 0x005ABCA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
