using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200686F RID: 26735
	public static class IGamepadShakeConfigVerify
	{
		// Token: 0x0602EA06 RID: 190982 RVA: 0x0065BE42 File Offset: 0x0065A042
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
