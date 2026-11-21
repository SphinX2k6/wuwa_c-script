using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200453D RID: 17725
	public static class ISaveConfigTypeVerify
	{
		// Token: 0x06019AB3 RID: 105139 RVA: 0x003A7C46 File Offset: 0x003A5E46
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
