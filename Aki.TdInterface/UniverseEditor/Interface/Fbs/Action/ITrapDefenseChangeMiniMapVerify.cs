using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007459 RID: 29785
	public static class ITrapDefenseChangeMiniMapVerify
	{
		// Token: 0x060361D0 RID: 221648 RVA: 0x0075BC22 File Offset: 0x00759E22
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
