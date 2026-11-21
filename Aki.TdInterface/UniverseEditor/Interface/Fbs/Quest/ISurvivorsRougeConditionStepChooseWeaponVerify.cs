using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045A6 RID: 17830
	public static class ISurvivorsRougeConditionStepChooseWeaponVerify
	{
		// Token: 0x0601A01F RID: 106527 RVA: 0x003B5186 File Offset: 0x003B3386
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
