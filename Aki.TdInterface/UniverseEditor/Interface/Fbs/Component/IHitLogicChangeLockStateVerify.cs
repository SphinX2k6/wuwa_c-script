using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200591D RID: 22813
	public static class IHitLogicChangeLockStateVerify
	{
		// Token: 0x0602516D RID: 151917 RVA: 0x0051725E File Offset: 0x0051545E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
