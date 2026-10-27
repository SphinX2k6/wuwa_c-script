using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071CE RID: 29134
	public static class IStopGuestCartethyiaVerify
	{
		// Token: 0x06033AEA RID: 211690 RVA: 0x006F5882 File Offset: 0x006F3A82
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
