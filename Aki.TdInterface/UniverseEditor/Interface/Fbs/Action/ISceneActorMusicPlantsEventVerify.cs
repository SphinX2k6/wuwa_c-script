using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B0 RID: 30384
	public static class ISceneActorMusicPlantsEventVerify
	{
		// Token: 0x060354BE RID: 218302 RVA: 0x0072656A File Offset: 0x0072476A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
