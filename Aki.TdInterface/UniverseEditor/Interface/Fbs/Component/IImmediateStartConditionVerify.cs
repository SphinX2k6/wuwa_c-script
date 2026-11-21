using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005974 RID: 22900
	public static class IImmediateStartConditionVerify
	{
		// Token: 0x06025546 RID: 152902 RVA: 0x0051FAE6 File Offset: 0x0051DCE6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
