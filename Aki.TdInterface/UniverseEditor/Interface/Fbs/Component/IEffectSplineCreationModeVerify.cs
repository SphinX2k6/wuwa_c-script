using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005119 RID: 20761
	public static class IEffectSplineCreationModeVerify
	{
		// Token: 0x0602174F RID: 137039 RVA: 0x004A50EE File Offset: 0x004A32EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
