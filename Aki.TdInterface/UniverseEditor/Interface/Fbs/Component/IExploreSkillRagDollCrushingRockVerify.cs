using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005203 RID: 20995
	public static class IExploreSkillRagDollCrushingRockVerify
	{
		// Token: 0x060221D3 RID: 139731 RVA: 0x004BBF7A File Offset: 0x004BA17A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
