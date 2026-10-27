using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200422E RID: 16942
	public static class ITrapDefenseConditionStepMapChangeVerify
	{
		// Token: 0x060190C7 RID: 102599 RVA: 0x0039A81E File Offset: 0x00398A1E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
