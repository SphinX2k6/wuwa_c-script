using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007465 RID: 29797
	public static class ITrapDefensePlayerOperationSpawnMonsterVerify
	{
		// Token: 0x06036227 RID: 221735 RVA: 0x0075C536 File Offset: 0x0075A736
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
