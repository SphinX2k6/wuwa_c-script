using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200760C RID: 30220
	public static class IWindProtagonistParkour2Verify
	{
		// Token: 0x060370C5 RID: 225477 RVA: 0x00777B1E File Offset: 0x00775D1E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
