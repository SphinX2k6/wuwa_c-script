using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F19 RID: 16153
	public static class ILogicProgramSpecialProcessOperationVerify
	{
		// Token: 0x06016EEB RID: 93931 RVA: 0x0034F39E File Offset: 0x0034D59E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
