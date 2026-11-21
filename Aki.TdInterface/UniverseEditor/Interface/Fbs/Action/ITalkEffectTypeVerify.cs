using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A8D RID: 31373
	public static class ITalkEffectTypeVerify
	{
		// Token: 0x060374E0 RID: 226528 RVA: 0x00762632 File Offset: 0x00760832
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
