using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200559B RID: 21915
	public static class IMonsterShowOnDeathConfigVerify
	{
		// Token: 0x06024476 RID: 148598 RVA: 0x005023AE File Offset: 0x005005AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
