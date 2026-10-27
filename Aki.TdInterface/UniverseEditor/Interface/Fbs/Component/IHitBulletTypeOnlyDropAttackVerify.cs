using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200537C RID: 21372
	public static class IHitBulletTypeOnlyDropAttackVerify
	{
		// Token: 0x06022FB1 RID: 143281 RVA: 0x004D7DE2 File Offset: 0x004D5FE2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
