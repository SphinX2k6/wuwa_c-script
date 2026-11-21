using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004150 RID: 16720
	public static class IBossRushBuffInfoViewVerify
	{
		// Token: 0x06016F90 RID: 94096 RVA: 0x00346E76 File Offset: 0x00345076
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
