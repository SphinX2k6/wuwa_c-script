using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005445 RID: 21573
	public static class IInteractEntityPartBindBaseVerify
	{
		// Token: 0x060237AE RID: 145326 RVA: 0x004E8E96 File Offset: 0x004E7096
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
