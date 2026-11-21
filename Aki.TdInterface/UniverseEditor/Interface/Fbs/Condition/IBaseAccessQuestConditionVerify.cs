using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E26 RID: 20006
	public static class IBaseAccessQuestConditionVerify
	{
		// Token: 0x0601EEEE RID: 126702 RVA: 0x004524DA File Offset: 0x004506DA
		public static bool Verify(Verifier verifier, uint tablePos)
		{
			return verifier.VerifyTableStart(tablePos) && verifier.VerifyField(tablePos, 4, 1UL, 1UL, false) && verifier.VerifyTableEnd(tablePos);
		}
	}
}
