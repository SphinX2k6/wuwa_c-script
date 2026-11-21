using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E2 RID: 21986
	public static class IDefaultAttachTimingVerify
	{
		// Token: 0x06022FD6 RID: 143318 RVA: 0x004D08AA File Offset: 0x004CEAAA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
