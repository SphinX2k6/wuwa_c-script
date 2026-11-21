using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046F9 RID: 18169
	public static class IWaveConfigVerify
	{
		// Token: 0x0601ABB2 RID: 109490 RVA: 0x003CC646 File Offset: 0x003CA846
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
