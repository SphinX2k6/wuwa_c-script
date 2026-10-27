using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072AC RID: 29356
	public static class ITalkEffectActionTypeVerify
	{
		// Token: 0x0603416C RID: 213356 RVA: 0x007005D6 File Offset: 0x006FE7D6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
