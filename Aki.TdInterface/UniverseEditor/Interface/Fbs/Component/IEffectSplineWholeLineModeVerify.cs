using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005122 RID: 20770
	public static class IEffectSplineWholeLineModeVerify
	{
		// Token: 0x06021785 RID: 137093 RVA: 0x004A55AE File Offset: 0x004A37AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
