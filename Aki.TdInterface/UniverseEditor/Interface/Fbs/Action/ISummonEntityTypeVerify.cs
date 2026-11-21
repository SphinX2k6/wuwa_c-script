using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A09 RID: 31241
	public static class ISummonEntityTypeVerify
	{
		// Token: 0x060370B9 RID: 225465 RVA: 0x0075B682 File Offset: 0x00759882
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
