using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007713 RID: 30483
	public static class ISeasonWeatherSetRotationLockVerify
	{
		// Token: 0x060357C4 RID: 219076 RVA: 0x0072BD1A File Offset: 0x00729F1A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
