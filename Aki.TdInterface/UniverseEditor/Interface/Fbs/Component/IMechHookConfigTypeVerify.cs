using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005544 RID: 21828
	public static class IMechHookConfigTypeVerify
	{
		// Token: 0x06024134 RID: 147764 RVA: 0x004FBE26 File Offset: 0x004FA026
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
