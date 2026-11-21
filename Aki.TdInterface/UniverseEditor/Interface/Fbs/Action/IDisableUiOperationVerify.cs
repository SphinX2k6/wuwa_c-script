using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C6A RID: 27754
	public static class IDisableUiOperationVerify
	{
		// Token: 0x0602FCE5 RID: 195813 RVA: 0x00682A1A File Offset: 0x00680C1A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
