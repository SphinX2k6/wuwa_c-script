using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059BE RID: 22974
	public static class IStateRepPerfSkillIdVerify
	{
		// Token: 0x06026EDA RID: 159450 RVA: 0x0055B005 File Offset: 0x00559205
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyField(tablePos, 6, 8UL, 8UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
