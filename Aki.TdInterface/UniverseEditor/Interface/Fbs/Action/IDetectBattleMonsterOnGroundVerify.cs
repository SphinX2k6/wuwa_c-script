using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065B1 RID: 26033
	public static class IDetectBattleMonsterOnGroundVerify
	{
		// Token: 0x0602D284 RID: 184964 RVA: 0x006312DA File Offset: 0x0062F4DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
