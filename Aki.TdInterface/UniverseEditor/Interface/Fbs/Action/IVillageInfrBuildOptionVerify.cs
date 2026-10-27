using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007540 RID: 30016
	public static class IVillageInfrBuildOptionVerify
	{
		// Token: 0x060369CF RID: 223695 RVA: 0x0076B652 File Offset: 0x00769852
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
