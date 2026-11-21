using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005902 RID: 22786
	public static class IHitBulletTypeOnlyDropAttackVerify
	{
		// Token: 0x06025065 RID: 151653 RVA: 0x00514CB6 File Offset: 0x00512EB6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
