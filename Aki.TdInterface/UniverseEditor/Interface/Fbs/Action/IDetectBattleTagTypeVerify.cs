using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065BD RID: 26045
	public static class IDetectBattleTagTypeVerify
	{
		// Token: 0x0602D2D2 RID: 185042 RVA: 0x00631A76 File Offset: 0x0062FC76
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
