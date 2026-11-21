using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BC9 RID: 23497
	public static class INpcModelConfigVerify
	{
		// Token: 0x06026C1B RID: 158747 RVA: 0x0054DFCA File Offset: 0x0054C1CA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
