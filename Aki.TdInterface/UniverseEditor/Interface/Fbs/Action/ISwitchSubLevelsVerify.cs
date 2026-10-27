using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200726D RID: 29293
	public static class ISwitchSubLevelsVerify
	{
		// Token: 0x06033F77 RID: 212855 RVA: 0x006FD072 File Offset: 0x006FB272
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
