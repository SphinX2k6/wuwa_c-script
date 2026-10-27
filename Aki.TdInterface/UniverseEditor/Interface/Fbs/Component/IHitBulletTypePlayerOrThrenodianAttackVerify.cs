using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005382 RID: 21378
	public static class IHitBulletTypePlayerOrThrenodianAttackVerify
	{
		// Token: 0x06022FD5 RID: 143317 RVA: 0x004D80D2 File Offset: 0x004D62D2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
