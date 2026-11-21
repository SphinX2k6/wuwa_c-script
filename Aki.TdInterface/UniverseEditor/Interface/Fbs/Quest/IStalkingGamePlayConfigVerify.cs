using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004588 RID: 17800
	public static class IStalkingGamePlayConfigVerify
	{
		// Token: 0x06019ED9 RID: 106201 RVA: 0x003B271A File Offset: 0x003B091A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
