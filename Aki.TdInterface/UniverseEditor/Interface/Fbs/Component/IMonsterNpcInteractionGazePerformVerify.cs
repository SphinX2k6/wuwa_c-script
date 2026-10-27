using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200558C RID: 21900
	public static class IMonsterNpcInteractionGazePerformVerify
	{
		// Token: 0x0602441C RID: 148508 RVA: 0x00501BD2 File Offset: 0x004FFDD2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
