using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200746A RID: 29802
	public static class IPlayerBlendAnimTargetVerify
	{
		// Token: 0x060342C0 RID: 213696 RVA: 0x0070756E File Offset: 0x0070576E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
