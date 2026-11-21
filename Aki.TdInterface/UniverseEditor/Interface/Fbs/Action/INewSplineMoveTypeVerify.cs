using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020072E8 RID: 29416
	public static class INewSplineMoveTypeVerify
	{
		// Token: 0x060334B0 RID: 210096 RVA: 0x006EB382 File Offset: 0x006E9582
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
