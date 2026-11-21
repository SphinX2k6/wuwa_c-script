using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055A3 RID: 21923
	public static class ICreateBulletDestroyConditionVerify
	{
		// Token: 0x06022DEA RID: 142826 RVA: 0x004CD63A File Offset: 0x004CB83A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
