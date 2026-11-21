using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F86 RID: 24454
	public static class ISpeedCurveMotionVerify
	{
		// Token: 0x060291BC RID: 168380 RVA: 0x0059D02D File Offset: 0x0059B22D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
