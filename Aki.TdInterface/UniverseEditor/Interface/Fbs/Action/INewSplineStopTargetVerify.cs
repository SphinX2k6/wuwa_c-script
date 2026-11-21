using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072EE RID: 29422
	public static class INewSplineStopTargetVerify
	{
		// Token: 0x060334CE RID: 210126 RVA: 0x006EB5F6 File Offset: 0x006E97F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
