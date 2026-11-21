using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071BB RID: 29115
	public static class IMechStuntDiveVerify
	{
		// Token: 0x06032A53 RID: 207443 RVA: 0x006D7C46 File Offset: 0x006D5E46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
