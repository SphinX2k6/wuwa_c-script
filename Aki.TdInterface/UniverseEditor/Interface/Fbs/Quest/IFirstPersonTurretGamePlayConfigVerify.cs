using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E56 RID: 15958
	public static class IFirstPersonTurretGamePlayConfigVerify
	{
		// Token: 0x06016760 RID: 92000 RVA: 0x0033F55A File Offset: 0x0033D75A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
