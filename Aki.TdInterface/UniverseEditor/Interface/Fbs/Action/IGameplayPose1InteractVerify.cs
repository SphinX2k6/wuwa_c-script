using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200687B RID: 26747
	public static class IGameplayPose1InteractVerify
	{
		// Token: 0x0602EA5E RID: 191070 RVA: 0x0065C886 File Offset: 0x0065AA86
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
