using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007212 RID: 29202
	public static class IMoneHackingDoorInteractVerify
	{
		// Token: 0x06032CFB RID: 208123 RVA: 0x006DCA2E File Offset: 0x006DAC2E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
