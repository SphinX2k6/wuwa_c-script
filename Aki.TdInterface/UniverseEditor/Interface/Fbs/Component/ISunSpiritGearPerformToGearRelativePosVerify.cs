using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A06 RID: 23046
	public static class ISunSpiritGearPerformToGearRelativePosVerify
	{
		// Token: 0x060271CF RID: 160207 RVA: 0x0056157E File Offset: 0x0055F77E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
