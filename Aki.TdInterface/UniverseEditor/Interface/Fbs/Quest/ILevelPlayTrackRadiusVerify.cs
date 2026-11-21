using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004345 RID: 17221
	public static class ILevelPlayTrackRadiusVerify
	{
		// Token: 0x060183D4 RID: 99284 RVA: 0x003745DA File Offset: 0x003727DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
