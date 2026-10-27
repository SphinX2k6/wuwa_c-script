using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200537F RID: 21375
	public static class IHitBulletTypePlayerAttackVerify
	{
		// Token: 0x06022FC3 RID: 143299 RVA: 0x004D7F5A File Offset: 0x004D615A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
