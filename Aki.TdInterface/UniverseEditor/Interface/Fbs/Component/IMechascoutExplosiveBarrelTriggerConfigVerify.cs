using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005538 RID: 21816
	public static class IMechascoutExplosiveBarrelTriggerConfigVerify
	{
		// Token: 0x060240BA RID: 147642 RVA: 0x004FACD2 File Offset: 0x004F8ED2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
