using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CB6 RID: 23734
	public static class IPasserbyNpcSourceVerify
	{
		// Token: 0x06027624 RID: 161316 RVA: 0x0056410E File Offset: 0x0056230E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
