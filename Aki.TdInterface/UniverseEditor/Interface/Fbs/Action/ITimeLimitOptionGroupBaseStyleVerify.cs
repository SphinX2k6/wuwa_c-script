using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073DE RID: 29662
	public static class ITimeLimitOptionGroupBaseStyleVerify
	{
		// Token: 0x06035E30 RID: 220720 RVA: 0x00755966 File Offset: 0x00753B66
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
