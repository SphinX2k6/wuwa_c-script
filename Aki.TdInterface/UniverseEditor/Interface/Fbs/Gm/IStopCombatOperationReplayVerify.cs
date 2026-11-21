using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B1B RID: 19227
	public static class IStopCombatOperationReplayVerify
	{
		// Token: 0x0601CFD7 RID: 118743 RVA: 0x0041378E File Offset: 0x0041198E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
