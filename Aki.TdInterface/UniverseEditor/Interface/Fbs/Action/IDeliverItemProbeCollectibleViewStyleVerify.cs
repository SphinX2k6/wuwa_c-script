using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006572 RID: 25970
	public static class IDeliverItemProbeCollectibleViewStyleVerify
	{
		// Token: 0x0602D0E9 RID: 184553 RVA: 0x0062EB56 File Offset: 0x0062CD56
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
