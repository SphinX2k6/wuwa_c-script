using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EDA RID: 16090
	public static class IKurotatoConditionStepBattleVerify
	{
		// Token: 0x06016C2C RID: 93228 RVA: 0x00348FAE File Offset: 0x003471AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
