using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C34 RID: 31796
	public static class ITransitionPopupArtTextTypeBaseVerify
	{
		// Token: 0x060394FC RID: 234748 RVA: 0x007BD56A File Offset: 0x007BB76A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
