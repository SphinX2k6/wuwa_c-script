using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004659 RID: 18009
	public static class IGetAllGraduatedWeaponVerify
	{
		// Token: 0x0601B4AE RID: 111790 RVA: 0x003E1DA2 File Offset: 0x003DFFA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
