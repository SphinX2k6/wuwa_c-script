using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E7A RID: 28282
	public static class IFlowDefineNpcCancelMotorcycleSharingPerformVerify
	{
		// Token: 0x06030DE0 RID: 200160 RVA: 0x006A115F File Offset: 0x0069F35F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
