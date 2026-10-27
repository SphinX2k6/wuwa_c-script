using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006331 RID: 25393
	public static class IChangeTimerTypeVerify
	{
		// Token: 0x0602BED1 RID: 179921 RVA: 0x00609C4E File Offset: 0x00607E4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
