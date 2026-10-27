using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200680C RID: 26636
	public static class IFlowDefineNpcMotorcycleSharingPerformVerify
	{
		// Token: 0x0602E621 RID: 189985 RVA: 0x00654847 File Offset: 0x00652A47
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
