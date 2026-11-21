using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045D0 RID: 17872
	public static class ITakePhoto2ModeBaseVerify
	{
		// Token: 0x0601A1A2 RID: 106914 RVA: 0x003B841E File Offset: 0x003B661E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
