using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005979 RID: 22905
	public static class ISpeedCurveMotionVerify
	{
		// Token: 0x06026C52 RID: 158802 RVA: 0x005563C1 File Offset: 0x005545C1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
