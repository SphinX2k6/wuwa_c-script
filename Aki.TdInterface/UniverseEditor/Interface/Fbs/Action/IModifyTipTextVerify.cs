using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AD8 RID: 27352
	public static class IModifyTipTextVerify
	{
		// Token: 0x0602FF1D RID: 196381 RVA: 0x006852E8 File Offset: 0x006834E8
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 4UL, 4UL, false) && verifier.VerifyString(tablePos, 8, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
