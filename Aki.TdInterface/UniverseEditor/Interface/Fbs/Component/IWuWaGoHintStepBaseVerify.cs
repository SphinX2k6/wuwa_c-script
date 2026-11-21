using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061CA RID: 25034
	public static class IWuWaGoHintStepBaseVerify
	{
		// Token: 0x0602A90C RID: 174348 RVA: 0x005CDF7A File Offset: 0x005CC17A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
