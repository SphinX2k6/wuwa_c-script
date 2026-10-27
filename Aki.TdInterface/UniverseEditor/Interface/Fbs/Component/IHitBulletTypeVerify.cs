using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005370 RID: 21360
	public static class IHitBulletTypeVerify
	{
		// Token: 0x06022F51 RID: 143185 RVA: 0x004D7416 File Offset: 0x004D5616
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
