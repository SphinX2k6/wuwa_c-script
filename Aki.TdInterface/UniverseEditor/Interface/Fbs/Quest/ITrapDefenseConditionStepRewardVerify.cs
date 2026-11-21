using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004690 RID: 18064
	public static class ITrapDefenseConditionStepRewardVerify
	{
		// Token: 0x0601A857 RID: 108631 RVA: 0x003C61E6 File Offset: 0x003C43E6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
