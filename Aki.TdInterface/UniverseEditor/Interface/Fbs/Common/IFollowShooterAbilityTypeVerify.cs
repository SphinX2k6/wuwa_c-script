using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DAE RID: 23982
	public static class IFollowShooterAbilityTypeVerify
	{
		// Token: 0x060290C7 RID: 168135 RVA: 0x005A2E56 File Offset: 0x005A1056
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
