using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200734E RID: 29518
	public static class ITalkOptionQteSucceedDelayExecVerify
	{
		// Token: 0x0603590B RID: 219403 RVA: 0x0074B86E File Offset: 0x00749A6E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
