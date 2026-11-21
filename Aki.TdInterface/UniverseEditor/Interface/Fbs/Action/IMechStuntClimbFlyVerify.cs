using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B2 RID: 29106
	public static class IMechStuntClimbFlyVerify
	{
		// Token: 0x06032A19 RID: 207385 RVA: 0x006D770A File Offset: 0x006D590A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
