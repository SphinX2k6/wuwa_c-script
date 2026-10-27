using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A9C RID: 27292
	public static class IMechStuntLevelFlyVerify
	{
		// Token: 0x0602FD3B RID: 195899 RVA: 0x00681C76 File Offset: 0x0067FE76
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
