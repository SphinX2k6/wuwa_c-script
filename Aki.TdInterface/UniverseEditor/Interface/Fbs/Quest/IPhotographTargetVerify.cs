using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043D2 RID: 17362
	public static class IPhotographTargetVerify
	{
		// Token: 0x06018A6C RID: 100972 RVA: 0x00383FB2 File Offset: 0x003821B2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
