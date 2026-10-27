using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007360 RID: 29536
	public static class ITargetEntityTypeVerify
	{
		// Token: 0x060359C1 RID: 219585 RVA: 0x0074D0CE File Offset: 0x0074B2CE
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
