using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006861 RID: 26721
	public static class IBattleStateMonsterLandingVerify
	{
		// Token: 0x0602DAD3 RID: 187091 RVA: 0x0063F472 File Offset: 0x0063D672
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
