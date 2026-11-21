using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004510 RID: 17680
	public static class IRoleTowerConditionStepBaseVerify
	{
		// Token: 0x06019966 RID: 104806 RVA: 0x003A5836 File Offset: 0x003A3A36
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
