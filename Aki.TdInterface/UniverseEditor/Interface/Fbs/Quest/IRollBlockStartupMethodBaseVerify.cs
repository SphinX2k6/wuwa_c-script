using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004534 RID: 17716
	public static class IRollBlockStartupMethodBaseVerify
	{
		// Token: 0x06019A5D RID: 105053 RVA: 0x003A70C6 File Offset: 0x003A52C6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
