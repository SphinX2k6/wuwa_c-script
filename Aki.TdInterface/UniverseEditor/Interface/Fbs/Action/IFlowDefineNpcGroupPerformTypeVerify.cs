using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006803 RID: 26627
	public static class IFlowDefineNpcGroupPerformTypeVerify
	{
		// Token: 0x0602E5DD RID: 189917 RVA: 0x006541DA File Offset: 0x006523DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
