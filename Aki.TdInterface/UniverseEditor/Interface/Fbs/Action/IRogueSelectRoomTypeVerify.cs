using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF3 RID: 28403
	public static class IRogueSelectRoomTypeVerify
	{
		// Token: 0x06032310 RID: 205584 RVA: 0x006C8536 File Offset: 0x006C6736
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
