using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007330 RID: 29488
	public static class ITalkOptionFirstSelectVerify
	{
		// Token: 0x0603583D RID: 219197 RVA: 0x0074A58A File Offset: 0x0074878A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
