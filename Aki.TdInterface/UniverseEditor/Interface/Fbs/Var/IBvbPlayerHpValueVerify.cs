using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E5B RID: 15963
	public static class IBvbPlayerHpValueVerify
	{
		// Token: 0x060157FC RID: 88060 RVA: 0x00319D32 File Offset: 0x00317F32
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
