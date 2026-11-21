using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004555 RID: 17749
	public static class ISheriffClueDetailBoardConfigVerify
	{
		// Token: 0x06019CFC RID: 105724 RVA: 0x003AEFAE File Offset: 0x003AD1AE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
