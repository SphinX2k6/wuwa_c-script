using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004558 RID: 17752
	public static class ISheriffMainBoardConfigVerify
	{
		// Token: 0x06019D09 RID: 105737 RVA: 0x003AF096 File Offset: 0x003AD296
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
