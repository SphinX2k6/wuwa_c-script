using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F68 RID: 24424
	public static class ISpawnMonsterPreConditonTypeVerify
	{
		// Token: 0x060290F6 RID: 168182 RVA: 0x0059BC46 File Offset: 0x00599E46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
