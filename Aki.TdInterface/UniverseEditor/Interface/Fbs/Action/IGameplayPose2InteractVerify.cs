using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200687E RID: 26750
	public static class IGameplayPose2InteractVerify
	{
		// Token: 0x0602EA70 RID: 191088 RVA: 0x0065C9FE File Offset: 0x0065ABFE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
