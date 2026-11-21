using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004AF1 RID: 19185
	public static class ISavePlayerDataVerify
	{
		// Token: 0x0601CE77 RID: 118391 RVA: 0x00411506 File Offset: 0x0040F706
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
