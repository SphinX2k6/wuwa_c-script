using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020040BD RID: 16573
	public static class IRoleSkinTrialActivitiesVerify
	{
		// Token: 0x0601825B RID: 98907 RVA: 0x0037B002 File Offset: 0x00379202
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
