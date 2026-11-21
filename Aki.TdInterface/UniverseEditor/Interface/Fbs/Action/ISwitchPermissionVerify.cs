using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A39 RID: 31289
	public static class ISwitchPermissionVerify
	{
		// Token: 0x06037235 RID: 225845 RVA: 0x0075DD6D File Offset: 0x0075BF6D
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 1UL, 1UL, false) && verifier.VerifyVectorOfStrings(tablePos, 8, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
