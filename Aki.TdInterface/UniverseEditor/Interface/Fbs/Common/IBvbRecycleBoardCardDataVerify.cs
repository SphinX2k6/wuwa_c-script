using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006394 RID: 25492
	public static class IBvbRecycleBoardCardDataVerify
	{
		// Token: 0x0602B4AD RID: 177325 RVA: 0x005E6F12 File Offset: 0x005E5112
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
