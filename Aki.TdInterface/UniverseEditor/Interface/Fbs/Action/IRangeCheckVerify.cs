using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007587 RID: 30087
	public static class IRangeCheckVerify
	{
		// Token: 0x06034C75 RID: 216181 RVA: 0x00718DD6 File Offset: 0x00716FD6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
