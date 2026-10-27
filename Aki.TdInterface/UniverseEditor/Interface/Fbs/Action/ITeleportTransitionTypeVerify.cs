using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073A5 RID: 29605
	public static class ITeleportTransitionTypeVerify
	{
		// Token: 0x06035BE4 RID: 220132 RVA: 0x00750D2E File Offset: 0x0074EF2E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
