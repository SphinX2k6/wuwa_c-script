using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007315 RID: 29461
	public static class INpcGroupSequenceBlendAnimTypeBaseVerify
	{
		// Token: 0x060335F6 RID: 210422 RVA: 0x006ED592 File Offset: 0x006EB792
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
