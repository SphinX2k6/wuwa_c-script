using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076DD RID: 30429
	public static class ISceneUiSubtitleOperationBaseVerify
	{
		// Token: 0x0603563E RID: 218686 RVA: 0x007293AE File Offset: 0x007275AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
