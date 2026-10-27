using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007609 RID: 30217
	public static class IWindProtagonistParkour1Verify
	{
		// Token: 0x060370B3 RID: 225459 RVA: 0x007779A6 File Offset: 0x00775BA6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
