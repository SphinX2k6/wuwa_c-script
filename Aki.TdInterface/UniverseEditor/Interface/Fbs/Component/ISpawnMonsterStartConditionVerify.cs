using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F71 RID: 24433
	public static class ISpawnMonsterStartConditionVerify
	{
		// Token: 0x06029132 RID: 168242 RVA: 0x0059C1E6 File Offset: 0x0059A3E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
