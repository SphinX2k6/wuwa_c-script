using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200757C RID: 30076
	public static class IVisualNovelDisplayItemBaseVerify
	{
		// Token: 0x06036B75 RID: 224117 RVA: 0x0076DDAE File Offset: 0x0076BFAE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
