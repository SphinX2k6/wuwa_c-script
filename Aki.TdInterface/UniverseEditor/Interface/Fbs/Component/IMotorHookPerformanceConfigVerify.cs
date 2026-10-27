using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055BF RID: 21951
	public static class IMotorHookPerformanceConfigVerify
	{
		// Token: 0x060245DC RID: 148956 RVA: 0x00505279 File Offset: 0x00503479
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 8UL, 8UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
