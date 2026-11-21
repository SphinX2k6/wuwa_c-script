using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B36 RID: 19254
	public static class IUnlockAllExploreSkillVerify
	{
		// Token: 0x0601D0C1 RID: 118977 RVA: 0x00414FAA File Offset: 0x004131AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
