using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F8A RID: 20362
	public static class IChargeSlashControlVerify
	{
		// Token: 0x06020568 RID: 132456 RVA: 0x0047FAD1 File Offset: 0x0047DCD1
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
