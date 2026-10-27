using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C7D RID: 27773
	public static class IPerformerAiMoveConfigVerify
	{
		// Token: 0x06030F0B RID: 200459 RVA: 0x006A52CA File Offset: 0x006A34CA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
