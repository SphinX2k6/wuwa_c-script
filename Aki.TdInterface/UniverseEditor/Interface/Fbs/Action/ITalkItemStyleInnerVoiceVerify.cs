using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007303 RID: 29443
	public static class ITalkItemStyleInnerVoiceVerify
	{
		// Token: 0x06034FFD RID: 217085 RVA: 0x0072E82E File Offset: 0x0072CA2E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
