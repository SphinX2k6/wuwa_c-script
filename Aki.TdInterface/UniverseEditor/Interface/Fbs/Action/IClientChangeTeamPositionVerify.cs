using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069FE RID: 27134
	public static class IClientChangeTeamPositionVerify
	{
		// Token: 0x0602E8B7 RID: 190647 RVA: 0x00658FF6 File Offset: 0x006571F6
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 4UL, 4UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
