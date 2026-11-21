using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B1D RID: 27421
	public static class ICommonTipTypeVerify
	{
		// Token: 0x0602F269 RID: 193129 RVA: 0x0066DBF2 File Offset: 0x0066BDF2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
