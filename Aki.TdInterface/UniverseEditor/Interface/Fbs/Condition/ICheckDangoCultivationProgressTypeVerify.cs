using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E77 RID: 20087
	public static class ICheckDangoCultivationProgressTypeVerify
	{
		// Token: 0x0601F1CE RID: 127438 RVA: 0x0045747E File Offset: 0x0045567E
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
