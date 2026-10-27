using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005206 RID: 20998
	public static class IExploreSkillRagDollDestroySolidRockVerify
	{
		// Token: 0x060221E5 RID: 139749 RVA: 0x004BC0F2 File Offset: 0x004BA2F2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
