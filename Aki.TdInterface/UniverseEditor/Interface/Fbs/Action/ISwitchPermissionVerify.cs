using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007264 RID: 29284
	public static class ISwitchPermissionVerify
	{
		// Token: 0x06033F33 RID: 212787 RVA: 0x006FCA0D File Offset: 0x006FAC0D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
