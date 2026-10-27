using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003ED1 RID: 16081
	public static class IKuroSimpleCombatKillMonsterSystemConfigVerify
	{
		// Token: 0x06016BEE RID: 93166 RVA: 0x003489EE File Offset: 0x00346BEE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
