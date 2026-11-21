using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E04 RID: 15876
	public static class IBvbCardFilterBaseVerify
	{
		// Token: 0x06015550 RID: 87376 RVA: 0x00315206 File Offset: 0x00313406
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
