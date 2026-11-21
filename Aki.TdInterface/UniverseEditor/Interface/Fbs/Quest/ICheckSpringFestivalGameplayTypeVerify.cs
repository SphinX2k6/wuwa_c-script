using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004180 RID: 16768
	public static class ICheckSpringFestivalGameplayTypeVerify
	{
		// Token: 0x0601714E RID: 94542 RVA: 0x0034A532 File Offset: 0x00348732
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
