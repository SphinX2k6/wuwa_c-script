using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200502D RID: 20525
	public static class ICheckSystemStateTypeVerify
	{
		// Token: 0x060200E8 RID: 131304 RVA: 0x0047294E File Offset: 0x00470B4E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
