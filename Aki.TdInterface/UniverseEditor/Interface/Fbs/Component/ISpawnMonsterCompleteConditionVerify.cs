using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F56 RID: 24406
	public static class ISpawnMonsterCompleteConditionVerify
	{
		// Token: 0x0602903D RID: 167997 RVA: 0x0059A38A File Offset: 0x0059858A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
