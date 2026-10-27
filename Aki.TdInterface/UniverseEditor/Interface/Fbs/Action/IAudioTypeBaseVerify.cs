using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061B7 RID: 25015
	public static class IAudioTypeBaseVerify
	{
		// Token: 0x0602B1B1 RID: 176561 RVA: 0x005F182E File Offset: 0x005EFA2E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
