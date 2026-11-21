using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005687 RID: 22151
	public static class IEffectSplineWholeLineModeVerify
	{
		// Token: 0x060236D9 RID: 145113 RVA: 0x004DF53A File Offset: 0x004DD73A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
