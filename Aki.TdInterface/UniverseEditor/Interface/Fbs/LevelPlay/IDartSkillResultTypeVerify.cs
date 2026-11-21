using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020048F8 RID: 18680
	public static class IDartSkillResultTypeVerify
	{
		// Token: 0x0601BAB0 RID: 113328 RVA: 0x003E961A File Offset: 0x003E781A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
