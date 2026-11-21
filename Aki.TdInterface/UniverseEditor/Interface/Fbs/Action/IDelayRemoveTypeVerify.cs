using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD4 RID: 27604
	public static class IDelayRemoveTypeVerify
	{
		// Token: 0x0602F83D RID: 194621 RVA: 0x0067A7FA File Offset: 0x006789FA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
