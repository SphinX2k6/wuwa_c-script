using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005583 RID: 21891
	public static class IMonsterNpcInteractionConfigVerify
	{
		// Token: 0x060243D6 RID: 148438 RVA: 0x005012DA File Offset: 0x004FF4DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
