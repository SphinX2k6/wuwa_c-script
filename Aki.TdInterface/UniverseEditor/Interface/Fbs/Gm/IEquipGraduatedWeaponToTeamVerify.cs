using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004644 RID: 17988
	public static class IEquipGraduatedWeaponToTeamVerify
	{
		// Token: 0x0601B3F2 RID: 111602 RVA: 0x003E09FE File Offset: 0x003DEBFE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
