using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073E4 RID: 29668
	public static class IPerformerAiMoveConfigVerify
	{
		// Token: 0x06033E66 RID: 212582 RVA: 0x006FF7CA File Offset: 0x006FD9CA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
