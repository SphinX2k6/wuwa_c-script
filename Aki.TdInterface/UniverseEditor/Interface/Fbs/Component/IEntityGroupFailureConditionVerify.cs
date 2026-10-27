using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005182 RID: 20866
	public static class IEntityGroupFailureConditionVerify
	{
		// Token: 0x06021BD6 RID: 138198 RVA: 0x004AE80A File Offset: 0x004ACA0A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
