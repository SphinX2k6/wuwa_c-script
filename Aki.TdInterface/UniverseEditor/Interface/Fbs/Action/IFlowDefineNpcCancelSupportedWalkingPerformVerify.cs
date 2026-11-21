using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E7D RID: 28285
	public static class IFlowDefineNpcCancelSupportedWalkingPerformVerify
	{
		// Token: 0x06030DF8 RID: 200184 RVA: 0x006A1393 File Offset: 0x0069F593
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
