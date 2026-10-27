using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004294 RID: 17044
	public static class IWarningPreformFadeInScreenVerify
	{
		// Token: 0x06019414 RID: 103444 RVA: 0x003A0B36 File Offset: 0x0039ED36
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
