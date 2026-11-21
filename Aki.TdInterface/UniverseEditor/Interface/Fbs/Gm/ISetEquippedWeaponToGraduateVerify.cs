using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AF7 RID: 19191
	public static class ISetEquippedWeaponToGraduateVerify
	{
		// Token: 0x0601CE9B RID: 118427 RVA: 0x004117F6 File Offset: 0x0040F9F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
