using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071C1 RID: 29121
	public static class IMechStuntLevelFlyVerify
	{
		// Token: 0x06032A77 RID: 207479 RVA: 0x006D7F36 File Offset: 0x006D6136
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
