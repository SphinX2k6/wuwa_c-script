using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200725E RID: 29278
	public static class ISwitchEffectStateEffectBaseVerify
	{
		// Token: 0x06033F05 RID: 212741 RVA: 0x006FC512 File Offset: 0x006FA712
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
