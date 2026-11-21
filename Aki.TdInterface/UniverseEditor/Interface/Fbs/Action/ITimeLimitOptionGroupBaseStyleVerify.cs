using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BC8 RID: 31688
	public static class ITimeLimitOptionGroupBaseStyleVerify
	{
		// Token: 0x060391E3 RID: 233955 RVA: 0x007B80DA File Offset: 0x007B62DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
