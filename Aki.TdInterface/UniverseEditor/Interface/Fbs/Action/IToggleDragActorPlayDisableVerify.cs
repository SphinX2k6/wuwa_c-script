using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BE6 RID: 31718
	public static class IToggleDragActorPlayDisableVerify
	{
		// Token: 0x060392B9 RID: 234169 RVA: 0x007B9822 File Offset: 0x007B7A22
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
