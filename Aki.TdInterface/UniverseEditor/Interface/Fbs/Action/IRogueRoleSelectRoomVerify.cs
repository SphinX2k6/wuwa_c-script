using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007671 RID: 30321
	public static class IRogueRoleSelectRoomVerify
	{
		// Token: 0x0603532C RID: 217900 RVA: 0x00723EF6 File Offset: 0x007220F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
