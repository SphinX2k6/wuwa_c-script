using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B9 RID: 29113
	public static class IStartSlidePerformTypeVerify
	{
		// Token: 0x06033A01 RID: 211457 RVA: 0x006F3B3E File Offset: 0x006F1D3E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
