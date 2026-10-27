using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A30 RID: 23088
	public static class ITargetGearGroupFailureConditionVerify
	{
		// Token: 0x060273FF RID: 160767 RVA: 0x00566ADE File Offset: 0x00564CDE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
