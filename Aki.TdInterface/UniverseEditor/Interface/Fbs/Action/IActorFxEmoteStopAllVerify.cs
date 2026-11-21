using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200671A RID: 26394
	public static class IActorFxEmoteStopAllVerify
	{
		// Token: 0x0602CB4C RID: 183116 RVA: 0x0061DD82 File Offset: 0x0061BF82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
