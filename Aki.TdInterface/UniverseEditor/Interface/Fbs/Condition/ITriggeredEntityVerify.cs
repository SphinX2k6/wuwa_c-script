using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005204 RID: 20996
	public static class ITriggeredEntityVerify
	{
		// Token: 0x06021116 RID: 135446 RVA: 0x00491AA2 File Offset: 0x0048FCA2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
