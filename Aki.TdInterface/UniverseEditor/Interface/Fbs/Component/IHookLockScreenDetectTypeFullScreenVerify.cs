using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200595C RID: 22876
	public static class IHookLockScreenDetectTypeFullScreenVerify
	{
		// Token: 0x06025442 RID: 152642 RVA: 0x0051D9EA File Offset: 0x0051BBEA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
