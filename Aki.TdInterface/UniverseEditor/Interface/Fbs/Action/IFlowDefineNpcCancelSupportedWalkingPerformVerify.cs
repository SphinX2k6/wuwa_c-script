using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067FD RID: 26621
	public static class IFlowDefineNpcCancelSupportedWalkingPerformVerify
	{
		// Token: 0x0602E5B2 RID: 189874 RVA: 0x00653C4F File Offset: 0x00651E4F
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
