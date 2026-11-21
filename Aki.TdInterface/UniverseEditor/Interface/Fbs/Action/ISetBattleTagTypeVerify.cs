using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200778E RID: 30606
	public static class ISetBattleTagTypeVerify
	{
		// Token: 0x06035B9B RID: 220059 RVA: 0x00732E1E File Offset: 0x0073101E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
