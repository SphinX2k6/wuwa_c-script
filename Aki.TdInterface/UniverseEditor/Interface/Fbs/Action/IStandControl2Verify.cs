using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071AD RID: 29101
	public static class IStandControl2Verify
	{
		// Token: 0x06033989 RID: 211337 RVA: 0x006F2B0A File Offset: 0x006F0D0A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
