using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007494 RID: 29844
	public static class IPlayGuestCartethyiaVerify
	{
		// Token: 0x060343FB RID: 214011 RVA: 0x00709636 File Offset: 0x00707836
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
