using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200624A RID: 25162
	public static class IBvbPlayDialogVerify
	{
		// Token: 0x0602B63D RID: 177725 RVA: 0x005F9022 File Offset: 0x005F7222
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
