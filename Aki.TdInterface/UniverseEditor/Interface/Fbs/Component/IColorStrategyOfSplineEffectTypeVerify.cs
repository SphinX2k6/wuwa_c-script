using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200551C RID: 21788
	public static class IColorStrategyOfSplineEffectTypeVerify
	{
		// Token: 0x06022704 RID: 141060 RVA: 0x004BEB7E File Offset: 0x004BCD7E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
