using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007916 RID: 30998
	public static class ISlideRailEndTypeVerify
	{
		// Token: 0x0603694D RID: 223565 RVA: 0x0074E256 File Offset: 0x0074C456
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
