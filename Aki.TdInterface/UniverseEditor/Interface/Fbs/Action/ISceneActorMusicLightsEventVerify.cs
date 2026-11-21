using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076AD RID: 30381
	public static class ISceneActorMusicLightsEventVerify
	{
		// Token: 0x060354AC RID: 218284 RVA: 0x007263F2 File Offset: 0x007245F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
