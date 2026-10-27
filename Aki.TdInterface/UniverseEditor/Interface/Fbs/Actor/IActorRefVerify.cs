using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Actor
{
	// Token: 0x02005EF9 RID: 24313
	public static class IActorRefVerify
	{
		// Token: 0x06029C25 RID: 171045 RVA: 0x005BAE3C File Offset: 0x005B903C
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyString(tablePos, 4, false) && verifier.VerifyString(tablePos, 6, false) && verifier.VerifyField(tablePos, 8, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 10, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
