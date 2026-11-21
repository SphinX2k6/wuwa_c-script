using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x02004B33 RID: 19251
	public static class IUnfreezeInstanceLimitVerify
	{
		// Token: 0x0601D0AF RID: 118959 RVA: 0x00414E32 File Offset: 0x00413032
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
