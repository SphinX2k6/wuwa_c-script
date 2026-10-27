using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006295 RID: 25237
	public static class ICameraOperationTypeVerify
	{
		// Token: 0x0602B994 RID: 178580 RVA: 0x0060087A File Offset: 0x005FEA7A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
