using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F29 RID: 28457
	public static class ISceneActorMusicPlantsEventVerify
	{
		// Token: 0x06032466 RID: 205926 RVA: 0x006CA602 File Offset: 0x006C8802
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
