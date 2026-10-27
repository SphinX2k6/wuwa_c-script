using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x020046CE RID: 18126
	public static class IUnlockAllExploreSkillVerify
	{
		// Token: 0x0601B8EC RID: 112876 RVA: 0x003E8D0E File Offset: 0x003E6F0E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
