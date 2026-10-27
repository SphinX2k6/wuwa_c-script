using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200535E RID: 21342
	public static class IGuideLineCreatorScanOptionVerify
	{
		// Token: 0x06022EA5 RID: 143013 RVA: 0x004D5FAA File Offset: 0x004D41AA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
