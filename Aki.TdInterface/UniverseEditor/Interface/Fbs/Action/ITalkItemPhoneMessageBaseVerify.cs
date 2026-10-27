using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072EE RID: 29422
	public static class ITalkItemPhoneMessageBaseVerify
	{
		// Token: 0x06034E82 RID: 216706 RVA: 0x0072A826 File Offset: 0x00728A26
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
