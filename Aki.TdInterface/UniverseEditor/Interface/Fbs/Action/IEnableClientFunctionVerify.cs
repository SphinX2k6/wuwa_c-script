using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CC7 RID: 27847
	public static class IEnableClientFunctionVerify
	{
		// Token: 0x0602FFE9 RID: 196585 RVA: 0x00687FC6 File Offset: 0x006861C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
