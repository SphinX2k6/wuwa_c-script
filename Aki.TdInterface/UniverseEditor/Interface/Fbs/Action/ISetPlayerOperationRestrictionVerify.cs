using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007051 RID: 28753
	public static class ISetPlayerOperationRestrictionVerify
	{
		// Token: 0x06032E24 RID: 208420 RVA: 0x006DCF66 File Offset: 0x006DB166
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
