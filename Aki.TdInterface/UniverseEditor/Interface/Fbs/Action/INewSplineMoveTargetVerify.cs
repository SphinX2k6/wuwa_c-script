using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072E2 RID: 29410
	public static class INewSplineMoveTargetVerify
	{
		// Token: 0x0603348C RID: 210060 RVA: 0x006EB042 File Offset: 0x006E9242
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
