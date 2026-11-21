using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B5F RID: 31583
	public static class ITeleportConfigVerify
	{
		// Token: 0x06038DF6 RID: 232950 RVA: 0x007B0412 File Offset: 0x007AE612
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
