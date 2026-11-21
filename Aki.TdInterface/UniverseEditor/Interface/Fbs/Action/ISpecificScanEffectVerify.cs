using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007949 RID: 31049
	public static class ISpecificScanEffectVerify
	{
		// Token: 0x06036AF0 RID: 223984 RVA: 0x0075124A File Offset: 0x0074F44A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
