using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A42 RID: 31298
	public static class ISwitchSubLevelsVerify
	{
		// Token: 0x06037279 RID: 225913 RVA: 0x0075E3D2 File Offset: 0x0075C5D2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
