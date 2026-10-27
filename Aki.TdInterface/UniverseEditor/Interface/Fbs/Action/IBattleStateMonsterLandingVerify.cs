using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061F3 RID: 25075
	public static class IBattleStateMonsterLandingVerify
	{
		// Token: 0x0602B38C RID: 177036 RVA: 0x005F49FE File Offset: 0x005F2BFE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
