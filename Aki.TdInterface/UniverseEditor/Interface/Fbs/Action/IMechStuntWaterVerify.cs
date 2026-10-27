using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A9F RID: 27295
	public static class IMechStuntWaterVerify
	{
		// Token: 0x0602FD4D RID: 195917 RVA: 0x00681DEE File Offset: 0x0067FFEE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
