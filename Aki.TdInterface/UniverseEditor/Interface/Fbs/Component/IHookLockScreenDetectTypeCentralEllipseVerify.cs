using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D3 RID: 21459
	public static class IHookLockScreenDetectTypeCentralEllipseVerify
	{
		// Token: 0x06023378 RID: 144248 RVA: 0x004E0846 File Offset: 0x004DEA46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
