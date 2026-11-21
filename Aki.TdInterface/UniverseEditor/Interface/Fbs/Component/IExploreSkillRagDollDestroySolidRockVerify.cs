using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200576E RID: 22382
	public static class IExploreSkillRagDollDestroySolidRockVerify
	{
		// Token: 0x0602417B RID: 147835 RVA: 0x004F6BB6 File Offset: 0x004F4DB6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
