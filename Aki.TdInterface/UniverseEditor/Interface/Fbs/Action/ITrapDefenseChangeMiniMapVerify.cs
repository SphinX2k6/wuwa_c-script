using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C4C RID: 31820
	public static class ITrapDefenseChangeMiniMapVerify
	{
		// Token: 0x060395B9 RID: 234937 RVA: 0x007BE94E File Offset: 0x007BCB4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
