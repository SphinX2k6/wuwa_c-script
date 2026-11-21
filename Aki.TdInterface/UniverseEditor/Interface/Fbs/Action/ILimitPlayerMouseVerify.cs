using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070CC RID: 28876
	public static class ILimitPlayerMouseVerify
	{
		// Token: 0x06032244 RID: 205380 RVA: 0x006C8D4A File Offset: 0x006C6F4A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
