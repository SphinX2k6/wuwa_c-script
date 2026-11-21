using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006720 RID: 26400
	public static class IActorFxEmoteStopSubTypeVerify
	{
		// Token: 0x0602CB7A RID: 183162 RVA: 0x0061E23A File Offset: 0x0061C43A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
