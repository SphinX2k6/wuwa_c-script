using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007898 RID: 30872
	public static class ISheriffUnlockClueVerify
	{
		// Token: 0x060364F3 RID: 222451 RVA: 0x00745C4E File Offset: 0x00743E4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
