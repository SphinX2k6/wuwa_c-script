using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077CF RID: 30671
	public static class ISetInteractionLockStateVerify
	{
		// Token: 0x06035E14 RID: 220692 RVA: 0x00738162 File Offset: 0x00736362
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
