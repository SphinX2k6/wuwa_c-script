using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C04 RID: 31748
	public static class IToggleRideFlyingCarUiGameplayConfigVerify
	{
		// Token: 0x06039397 RID: 234391 RVA: 0x007BAF06 File Offset: 0x007B9106
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
