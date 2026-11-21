using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056E7 RID: 22247
	public static class IEntityGroupFailureConditionVerify
	{
		// Token: 0x06023B2E RID: 146222 RVA: 0x004E882A File Offset: 0x004E6A2A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
