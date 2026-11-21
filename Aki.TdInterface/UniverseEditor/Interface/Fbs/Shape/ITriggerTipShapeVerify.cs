using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200407E RID: 16510
	public static class ITriggerTipShapeVerify
	{
		// Token: 0x06016BB4 RID: 93108 RVA: 0x0033F65A File Offset: 0x0033D85A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
