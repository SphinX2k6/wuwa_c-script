using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F26 RID: 28454
	public static class ISceneActorMusicLightsEventVerify
	{
		// Token: 0x06032454 RID: 205908 RVA: 0x006CA48A File Offset: 0x006C868A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
