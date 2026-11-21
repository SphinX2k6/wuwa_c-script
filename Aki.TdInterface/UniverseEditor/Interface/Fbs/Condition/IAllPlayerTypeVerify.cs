using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E20 RID: 20000
	public static class IAllPlayerTypeVerify
	{
		// Token: 0x0601EEC6 RID: 126662 RVA: 0x00452142 File Offset: 0x00450342
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
