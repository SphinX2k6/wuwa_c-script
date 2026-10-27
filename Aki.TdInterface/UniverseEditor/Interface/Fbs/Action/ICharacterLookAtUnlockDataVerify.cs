using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006351 RID: 25425
	public static class ICharacterLookAtUnlockDataVerify
	{
		// Token: 0x0602BFA7 RID: 180135 RVA: 0x0060B1BA File Offset: 0x006093BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
