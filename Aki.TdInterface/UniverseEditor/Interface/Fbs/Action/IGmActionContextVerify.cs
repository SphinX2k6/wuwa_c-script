using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006899 RID: 26777
	public static class IGmActionContextVerify
	{
		// Token: 0x0602EB31 RID: 191281 RVA: 0x0065DE6D File Offset: 0x0065C06D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
