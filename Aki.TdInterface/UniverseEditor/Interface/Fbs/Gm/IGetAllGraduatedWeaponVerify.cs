using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AC1 RID: 19137
	public static class IGetAllGraduatedWeaponVerify
	{
		// Token: 0x0601CC83 RID: 117891 RVA: 0x0040E03E File Offset: 0x0040C23E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
