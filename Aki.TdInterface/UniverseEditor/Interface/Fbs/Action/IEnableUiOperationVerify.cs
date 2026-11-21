using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D18 RID: 27928
	public static class IEnableUiOperationVerify
	{
		// Token: 0x060302AD RID: 197293 RVA: 0x0068CC56 File Offset: 0x0068AE56
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
