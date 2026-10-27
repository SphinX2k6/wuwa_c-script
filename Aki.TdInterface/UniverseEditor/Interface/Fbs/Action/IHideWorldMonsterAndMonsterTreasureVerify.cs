using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006914 RID: 26900
	public static class IHideWorldMonsterAndMonsterTreasureVerify
	{
		// Token: 0x0602EF5B RID: 192347 RVA: 0x006676EE File Offset: 0x006658EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
