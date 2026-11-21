using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068BB RID: 26811
	public static class IBvbPlayDialogVerify
	{
		// Token: 0x0602DD9E RID: 187806 RVA: 0x00643E2A File Offset: 0x0064202A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
