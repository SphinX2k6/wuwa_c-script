using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C0A RID: 31754
	public static class IToggleScanSplineEffectVerify
	{
		// Token: 0x060393B7 RID: 234423 RVA: 0x007BB1C6 File Offset: 0x007B93C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
