using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007378 RID: 29560
	public static class ITeleportConfigVerify
	{
		// Token: 0x06035A5B RID: 219739 RVA: 0x0074DED2 File Offset: 0x0074C0D2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
