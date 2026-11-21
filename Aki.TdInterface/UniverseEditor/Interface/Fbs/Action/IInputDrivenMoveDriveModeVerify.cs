using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007018 RID: 28696
	public static class IInputDrivenMoveDriveModeVerify
	{
		// Token: 0x06031B83 RID: 203651 RVA: 0x006BB69A File Offset: 0x006B989A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
