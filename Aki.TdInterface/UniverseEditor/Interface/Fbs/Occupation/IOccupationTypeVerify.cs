using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x0200481A RID: 18458
	public static class IOccupationTypeVerify
	{
		// Token: 0x0601B510 RID: 111888 RVA: 0x003DEC1A File Offset: 0x003DCE1A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
