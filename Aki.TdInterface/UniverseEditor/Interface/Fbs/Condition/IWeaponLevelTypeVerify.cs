using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200521C RID: 21020
	public static class IWeaponLevelTypeVerify
	{
		// Token: 0x060211B6 RID: 135606 RVA: 0x004929A6 File Offset: 0x00490BA6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
