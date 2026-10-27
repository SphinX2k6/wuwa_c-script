using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065C6 RID: 26054
	public static class IDisableAlertAreaConditionVerify
	{
		// Token: 0x0602D2FD RID: 185085 RVA: 0x00631DD2 File Offset: 0x0062FFD2
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
