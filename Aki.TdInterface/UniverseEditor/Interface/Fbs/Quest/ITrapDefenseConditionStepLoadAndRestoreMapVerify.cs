using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004687 RID: 18055
	public static class ITrapDefenseConditionStepLoadAndRestoreMapVerify
	{
		// Token: 0x0601A821 RID: 108577 RVA: 0x003C5D7E File Offset: 0x003C3F7E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
