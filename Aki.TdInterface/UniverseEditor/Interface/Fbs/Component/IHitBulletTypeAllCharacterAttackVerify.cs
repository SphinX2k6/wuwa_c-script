using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058F9 RID: 22777
	public static class IHitBulletTypeAllCharacterAttackVerify
	{
		// Token: 0x06025017 RID: 151575 RVA: 0x00514462 File Offset: 0x00512662
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
