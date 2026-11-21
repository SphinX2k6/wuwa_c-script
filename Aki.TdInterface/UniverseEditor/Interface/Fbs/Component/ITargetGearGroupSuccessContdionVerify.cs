using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006043 RID: 24643
	public static class ITargetGearGroupSuccessContdionVerify
	{
		// Token: 0x06029999 RID: 170393 RVA: 0x005ADDA6 File Offset: 0x005ABFA6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
