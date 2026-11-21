using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200451C RID: 17692
	public static class IRoleTowerConditionStepPrepareVerify
	{
		// Token: 0x060199B0 RID: 104880 RVA: 0x003A5EAE File Offset: 0x003A40AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
