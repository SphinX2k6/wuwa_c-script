using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020046F0 RID: 18160
	public static class IWarningPreformFadeInScreenVerify
	{
		// Token: 0x0601AB80 RID: 109440 RVA: 0x003CC20E File Offset: 0x003CA40E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
