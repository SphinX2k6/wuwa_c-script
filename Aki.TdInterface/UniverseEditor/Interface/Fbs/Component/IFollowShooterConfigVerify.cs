using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200529F RID: 21151
	public static class IFollowShooterConfigVerify
	{
		// Token: 0x060227B1 RID: 141233 RVA: 0x004C7CA2 File Offset: 0x004C5EA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
