using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C2 RID: 30402
	public static class ISceneItemMoveMotionTypeVerify
	{
		// Token: 0x06035548 RID: 218440 RVA: 0x007275E2 File Offset: 0x007257E2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
