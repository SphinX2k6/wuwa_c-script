using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005592 RID: 21906
	public static class IMonsterNpcInteractionSwordRidingVerify
	{
		// Token: 0x06024440 RID: 148544 RVA: 0x00501EC2 File Offset: 0x005000C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
