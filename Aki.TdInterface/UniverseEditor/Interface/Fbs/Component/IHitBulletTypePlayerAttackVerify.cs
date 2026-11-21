using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005905 RID: 22789
	public static class IHitBulletTypePlayerAttackVerify
	{
		// Token: 0x06025077 RID: 151671 RVA: 0x00514E2E File Offset: 0x0051302E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
