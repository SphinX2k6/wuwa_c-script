using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070CF RID: 28879
	public static class ISheriffUnlockEndingVerify
	{
		// Token: 0x06033263 RID: 209507 RVA: 0x006E57BA File Offset: 0x006E39BA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
