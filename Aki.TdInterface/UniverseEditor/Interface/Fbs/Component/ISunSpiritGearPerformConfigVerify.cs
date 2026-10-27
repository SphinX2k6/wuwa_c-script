using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059FD RID: 23037
	public static class ISunSpiritGearPerformConfigVerify
	{
		// Token: 0x06027195 RID: 160149 RVA: 0x00560F96 File Offset: 0x0055F196
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
