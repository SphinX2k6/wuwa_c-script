using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F1C RID: 28444
	public static class IGameplayPose1InteractVerify
	{
		// Token: 0x06031398 RID: 201624 RVA: 0x006AB906 File Offset: 0x006A9B06
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
