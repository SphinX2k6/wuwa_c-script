using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071AF RID: 29103
	public static class IMechStuntBurrowVerify
	{
		// Token: 0x06032A07 RID: 207367 RVA: 0x006D7592 File Offset: 0x006D5792
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
