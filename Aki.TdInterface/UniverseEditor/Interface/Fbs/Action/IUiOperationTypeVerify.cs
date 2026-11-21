using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007C9D RID: 31901
	public static class IUiOperationTypeVerify
	{
		// Token: 0x060398C6 RID: 235718 RVA: 0x007C4546 File Offset: 0x007C2746
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
