using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B30 RID: 23344
	public static class IMonsterNpcInteractionSwordRidingVerify
	{
		// Token: 0x0602664D RID: 157261 RVA: 0x0054243A File Offset: 0x0054063A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
