using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200576B RID: 22379
	public static class IExploreSkillRagDollCrushingRockVerify
	{
		// Token: 0x06024169 RID: 147817 RVA: 0x004F6A3E File Offset: 0x004F4C3E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
