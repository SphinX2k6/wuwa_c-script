using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EED RID: 28397
	public static class IRogueRoleSelectRoomVerify
	{
		// Token: 0x060322EC RID: 205548 RVA: 0x006C81C2 File Offset: 0x006C63C2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
