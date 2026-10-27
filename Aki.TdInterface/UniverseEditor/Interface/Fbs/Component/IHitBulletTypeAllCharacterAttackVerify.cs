using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005373 RID: 21363
	public static class IHitBulletTypeAllCharacterAttackVerify
	{
		// Token: 0x06022F63 RID: 143203 RVA: 0x004D758E File Offset: 0x004D578E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
