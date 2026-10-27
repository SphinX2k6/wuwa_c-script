using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005337 RID: 21303
	public static class IGroupAiModeVerify
	{
		// Token: 0x06022D5F RID: 142687 RVA: 0x004D39A6 File Offset: 0x004D1BA6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
