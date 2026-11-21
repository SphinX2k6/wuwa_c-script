using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043D8 RID: 17368
	public static class IPhotographTargetRolesOnSceneVerify
	{
		// Token: 0x06018AA0 RID: 101024 RVA: 0x00384556 File Offset: 0x00382756
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
