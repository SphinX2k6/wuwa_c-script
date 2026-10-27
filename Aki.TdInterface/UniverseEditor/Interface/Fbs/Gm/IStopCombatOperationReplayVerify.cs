using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046B3 RID: 18099
	public static class IStopCombatOperationReplayVerify
	{
		// Token: 0x0601B802 RID: 112642 RVA: 0x003E74F2 File Offset: 0x003E56F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
