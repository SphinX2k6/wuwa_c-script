using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C6 RID: 29638
	public static class IPainCoveringHeadVerify
	{
		// Token: 0x06033D71 RID: 212337 RVA: 0x006FDE4E File Offset: 0x006FC04E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
