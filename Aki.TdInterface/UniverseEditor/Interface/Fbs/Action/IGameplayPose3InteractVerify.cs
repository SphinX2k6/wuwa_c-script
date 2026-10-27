using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006881 RID: 26753
	public static class IGameplayPose3InteractVerify
	{
		// Token: 0x0602EA82 RID: 191106 RVA: 0x0065CB76 File Offset: 0x0065AD76
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
