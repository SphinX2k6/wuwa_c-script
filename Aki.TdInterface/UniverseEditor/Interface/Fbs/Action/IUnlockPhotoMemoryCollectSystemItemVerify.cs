using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CD3 RID: 31955
	public static class IUnlockPhotoMemoryCollectSystemItemVerify
	{
		// Token: 0x06039A4B RID: 236107 RVA: 0x007C6CE0 File Offset: 0x007C4EE0
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
