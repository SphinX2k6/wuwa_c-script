using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E62 RID: 28258
	public static class IFixTeleControllerResetPosVerify
	{
		// Token: 0x06030D04 RID: 199940 RVA: 0x0069FA2E File Offset: 0x0069DC2E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
