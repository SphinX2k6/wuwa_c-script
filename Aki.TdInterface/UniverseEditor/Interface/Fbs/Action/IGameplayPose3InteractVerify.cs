using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F22 RID: 28450
	public static class IGameplayPose3InteractVerify
	{
		// Token: 0x060313BC RID: 201660 RVA: 0x006ABBF6 File Offset: 0x006A9DF6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
