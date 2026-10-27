using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200422B RID: 16939
	public static class ITrapDefenseConditionStepLoadAndRestoreMapVerify
	{
		// Token: 0x060190B5 RID: 102581 RVA: 0x0039A6A6 File Offset: 0x003988A6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
