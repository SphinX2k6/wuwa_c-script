using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004689 RID: 18057
	public static class ISavePlayerDataVerify
	{
		// Token: 0x0601B6A2 RID: 112290 RVA: 0x003E526A File Offset: 0x003E346A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
