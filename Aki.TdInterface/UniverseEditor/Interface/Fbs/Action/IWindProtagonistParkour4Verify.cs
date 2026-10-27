using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007612 RID: 30226
	public static class IWindProtagonistParkour4Verify
	{
		// Token: 0x060370E9 RID: 225513 RVA: 0x00777E0E File Offset: 0x0077600E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
