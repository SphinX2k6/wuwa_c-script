using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F6 RID: 30710
	public static class ISetMoveSpeedVerify
	{
		// Token: 0x06035F2E RID: 220974 RVA: 0x0073A052 File Offset: 0x00738252
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
