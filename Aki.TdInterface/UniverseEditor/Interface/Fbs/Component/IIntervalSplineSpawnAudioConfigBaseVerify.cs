using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200548A RID: 21642
	public static class IIntervalSplineSpawnAudioConfigBaseVerify
	{
		// Token: 0x060239DE RID: 145886 RVA: 0x004ECBA2 File Offset: 0x004EADA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
