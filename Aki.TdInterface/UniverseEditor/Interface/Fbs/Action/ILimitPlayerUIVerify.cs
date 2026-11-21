using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070DE RID: 28894
	public static class ILimitPlayerUIVerify
	{
		// Token: 0x060322D7 RID: 205527 RVA: 0x006C9DCA File Offset: 0x006C7FCA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
