using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200680F RID: 26639
	public static class IFlowDefineNpcSupportedWalkingPerformVerify
	{
		// Token: 0x0602E639 RID: 190009 RVA: 0x00654A7B File Offset: 0x00652C7B
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
