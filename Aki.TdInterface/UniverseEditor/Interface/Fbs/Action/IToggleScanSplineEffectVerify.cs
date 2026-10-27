using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007417 RID: 29719
	public static class IToggleScanSplineEffectVerify
	{
		// Token: 0x06035FCE RID: 221134 RVA: 0x0075849A File Offset: 0x0075669A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
