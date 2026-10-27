using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006713 RID: 26387
	public static class IExecResurrectionVerify
	{
		// Token: 0x0602DE54 RID: 187988 RVA: 0x0064691A File Offset: 0x00644B1A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
