using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069A2 RID: 27042
	public static class IChangeTimerTypeVerify
	{
		// Token: 0x0602E63B RID: 190011 RVA: 0x00654DA2 File Offset: 0x00652FA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
