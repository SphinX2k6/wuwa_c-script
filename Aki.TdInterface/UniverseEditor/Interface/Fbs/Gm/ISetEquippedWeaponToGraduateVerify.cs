using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200468F RID: 18063
	public static class ISetEquippedWeaponToGraduateVerify
	{
		// Token: 0x0601B6C6 RID: 112326 RVA: 0x003E555A File Offset: 0x003E375A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
