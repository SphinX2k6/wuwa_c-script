using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200430F RID: 17167
	public static class IKuroSimpleCombatKillMonsterSystemConfigVerify
	{
		// Token: 0x06018245 RID: 98885 RVA: 0x00371BBA File Offset: 0x0036FDBA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
