using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020061AA RID: 25002
	public static class IWorldLevelBonusTypeVerify
	{
		// Token: 0x0602A7FA RID: 174074 RVA: 0x005CBF1A File Offset: 0x005CA11A
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
