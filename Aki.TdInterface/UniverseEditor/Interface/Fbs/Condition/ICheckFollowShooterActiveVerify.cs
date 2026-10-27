using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A2F RID: 18991
	public static class ICheckFollowShooterActiveVerify
	{
		// Token: 0x0601DB8C RID: 121740 RVA: 0x0042E110 File Offset: 0x0042C310
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 8, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
