using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005959 RID: 22873
	public static class IHookLockScreenDetectTypeCentralEllipseVerify
	{
		// Token: 0x06025430 RID: 152624 RVA: 0x0051D872 File Offset: 0x0051BA72
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
