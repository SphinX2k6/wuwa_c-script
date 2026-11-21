using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AAC RID: 19116
	public static class IEquipGraduatedWeaponToTeamVerify
	{
		// Token: 0x0601CBC7 RID: 117703 RVA: 0x0040CC9A File Offset: 0x0040AE9A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
