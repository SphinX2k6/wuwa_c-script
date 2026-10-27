using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D20 RID: 19744
	public static class IWeaponLevelTypeVerify
	{
		// Token: 0x0601F56F RID: 128367 RVA: 0x0045EA16 File Offset: 0x0045CC16
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
