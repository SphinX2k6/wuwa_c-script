using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FC0 RID: 20416
	public static class IColorStrategyOfSplineEffectTypeVerify
	{
		// Token: 0x06020810 RID: 133136 RVA: 0x0048569A File Offset: 0x0048389A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
