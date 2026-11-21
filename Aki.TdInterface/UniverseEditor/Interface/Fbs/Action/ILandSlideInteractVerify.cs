using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007090 RID: 28816
	public static class ILandSlideInteractVerify
	{
		// Token: 0x06031FD6 RID: 204758 RVA: 0x006C3C52 File Offset: 0x006C1E52
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
