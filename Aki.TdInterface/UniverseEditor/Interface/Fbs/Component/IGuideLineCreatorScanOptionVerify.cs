using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058E4 RID: 22756
	public static class IGuideLineCreatorScanOptionVerify
	{
		// Token: 0x06024F59 RID: 151385 RVA: 0x00512E7E File Offset: 0x0051107E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
