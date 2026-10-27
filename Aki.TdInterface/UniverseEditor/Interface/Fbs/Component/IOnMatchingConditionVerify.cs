using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056A0 RID: 22176
	public static class IOnMatchingConditionVerify
	{
		// Token: 0x0602502F RID: 151599 RVA: 0x0051C7A5 File Offset: 0x0051A9A5
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
