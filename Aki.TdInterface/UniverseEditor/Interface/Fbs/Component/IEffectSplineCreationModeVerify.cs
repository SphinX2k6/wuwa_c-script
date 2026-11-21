using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200567E RID: 22142
	public static class IEffectSplineCreationModeVerify
	{
		// Token: 0x060236A3 RID: 145059 RVA: 0x004DF07A File Offset: 0x004DD27A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
