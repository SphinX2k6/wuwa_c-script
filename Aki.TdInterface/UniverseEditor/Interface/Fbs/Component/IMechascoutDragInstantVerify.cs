using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200552C RID: 21804
	public static class IMechascoutDragInstantVerify
	{
		// Token: 0x06024072 RID: 147570 RVA: 0x004FA68A File Offset: 0x004F888A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
