using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004231 RID: 16945
	public static class ITrapDefenseConditionStepPreviewVerify
	{
		// Token: 0x060190D9 RID: 102617 RVA: 0x0039A996 File Offset: 0x00398B96
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
