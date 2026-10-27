using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F8 RID: 16888
	public static class ITrackEffectTypeVerify
	{
		// Token: 0x06018EAD RID: 102061 RVA: 0x00395CD2 File Offset: 0x00393ED2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
