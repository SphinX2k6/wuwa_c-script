using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005949 RID: 22857
	public static class ISpawnMonsterCompleteConditionVerify
	{
		// Token: 0x06026AD3 RID: 158419 RVA: 0x0055371E File Offset: 0x0055191E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
