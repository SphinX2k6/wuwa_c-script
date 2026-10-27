using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006665 RID: 26213
	public static class IEnableFunctionVerify
	{
		// Token: 0x0602D89A RID: 186522 RVA: 0x0063C39A File Offset: 0x0063A59A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
