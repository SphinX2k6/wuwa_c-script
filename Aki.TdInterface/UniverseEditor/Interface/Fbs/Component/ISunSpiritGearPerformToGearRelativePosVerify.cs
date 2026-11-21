using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006013 RID: 24595
	public static class ISunSpiritGearPerformToGearRelativePosVerify
	{
		// Token: 0x06029747 RID: 169799 RVA: 0x005A8542 File Offset: 0x005A6742
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
