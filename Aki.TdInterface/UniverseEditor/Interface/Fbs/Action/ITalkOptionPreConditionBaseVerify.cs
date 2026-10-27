using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200733C RID: 29500
	public static class ITalkOptionPreConditionBaseVerify
	{
		// Token: 0x06035893 RID: 219283 RVA: 0x0074AD9A File Offset: 0x00748F9A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
