using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006888 RID: 26760
	public static class IBossPilingEnterNextInstVerify
	{
		// Token: 0x0602DBE4 RID: 187364 RVA: 0x00640EEE File Offset: 0x0063F0EE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
