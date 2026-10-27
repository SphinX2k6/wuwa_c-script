using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007615 RID: 30229
	public static class IWindProtagonistParkour5Verify
	{
		// Token: 0x060370FB RID: 225531 RVA: 0x00777F86 File Offset: 0x00776186
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
