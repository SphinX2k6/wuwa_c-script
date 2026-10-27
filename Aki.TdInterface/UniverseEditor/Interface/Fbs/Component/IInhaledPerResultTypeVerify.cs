using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005415 RID: 21525
	public static class IInhaledPerResultTypeVerify
	{
		// Token: 0x060235AE RID: 144814 RVA: 0x004E4AC6 File Offset: 0x004E2CC6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
