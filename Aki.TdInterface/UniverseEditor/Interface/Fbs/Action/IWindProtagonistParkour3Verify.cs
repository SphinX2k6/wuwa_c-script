using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200760F RID: 30223
	public static class IWindProtagonistParkour3Verify
	{
		// Token: 0x060370D7 RID: 225495 RVA: 0x00777C96 File Offset: 0x00775E96
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
