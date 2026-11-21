using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C58 RID: 31832
	public static class ITrapDefensePlayerOperationSpawnMonsterVerify
	{
		// Token: 0x06039610 RID: 235024 RVA: 0x007BF262 File Offset: 0x007BD462
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
