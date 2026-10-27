using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E24 RID: 28196
	public static class IReignsCallCardVerify
	{
		// Token: 0x06031D22 RID: 204066 RVA: 0x006BE8E6 File Offset: 0x006BCAE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
