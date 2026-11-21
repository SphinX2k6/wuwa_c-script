using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200468D RID: 18061
	public static class ITrapDefenseConditionStepPreviewVerify
	{
		// Token: 0x0601A845 RID: 108613 RVA: 0x003C606E File Offset: 0x003C426E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
