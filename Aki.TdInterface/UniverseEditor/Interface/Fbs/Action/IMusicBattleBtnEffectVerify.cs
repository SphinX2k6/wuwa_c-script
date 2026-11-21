using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072D9 RID: 29401
	public static class IMusicBattleBtnEffectVerify
	{
		// Token: 0x06033428 RID: 209960 RVA: 0x006EA37A File Offset: 0x006E857A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
