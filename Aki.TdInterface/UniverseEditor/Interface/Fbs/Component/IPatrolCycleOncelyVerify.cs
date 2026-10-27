using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200570C RID: 22284
	public static class IPatrolCycleOncelyVerify
	{
		// Token: 0x06025422 RID: 152610 RVA: 0x00524146 File Offset: 0x00522346
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
