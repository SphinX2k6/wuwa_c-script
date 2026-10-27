using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C89 RID: 27785
	public static class IPerformerAiMoveToPlayerVerify
	{
		// Token: 0x06030F62 RID: 200546 RVA: 0x006A5C4E File Offset: 0x006A3E4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
