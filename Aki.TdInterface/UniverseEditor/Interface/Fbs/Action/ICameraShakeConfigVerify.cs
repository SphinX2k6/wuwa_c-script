using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062A4 RID: 25252
	public static class ICameraShakeConfigVerify
	{
		// Token: 0x0602BA20 RID: 178720 RVA: 0x006019EE File Offset: 0x005FFBEE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
