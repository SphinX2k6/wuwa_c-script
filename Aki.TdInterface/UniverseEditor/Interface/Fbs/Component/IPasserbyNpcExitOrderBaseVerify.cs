using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C6E RID: 23662
	public static class IPasserbyNpcExitOrderBaseVerify
	{
		// Token: 0x06027414 RID: 160788 RVA: 0x0056082A File Offset: 0x0055EA2A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
