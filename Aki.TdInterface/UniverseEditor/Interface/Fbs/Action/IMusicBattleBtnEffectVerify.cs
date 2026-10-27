using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B93 RID: 27539
	public static class IMusicBattleBtnEffectVerify
	{
		// Token: 0x060305D0 RID: 198096 RVA: 0x00691D5A File Offset: 0x0068FF5A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
